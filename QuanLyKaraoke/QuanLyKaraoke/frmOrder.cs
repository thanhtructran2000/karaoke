using QuanLyKaraoke.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKaraoke
{
    public partial class frmOrder : Form
    {
        public frmOrder(long idHoaDon,string tenphong, DataGridViewRow r)
        {
            this.idHoaDon = idHoaDon;
            this.r = r;
            this.tenphong = tenphong;
            
            InitializeComponent();
        }
        private long idHoaDon;
        private DataGridViewRow r;
        private string tenphong;

        private Karaoke_DatabaseDataContext db;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            this.lblTenMatHang.Text = "Mặt hàng yêu cầu: " +r.Cells["tenhang"].Value.ToString()+ " - ["+ r.Cells["dvt"].Value.ToString()+ "]";
            this.lblPhong.Text = string.Format("Phòng phục vụ: {0}", tenphong);
            db = new Karaoke_DatabaseDataContext();

        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // chỉ được nhập số 
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sl = 0;
            try
            {
                sl = int.Parse(txtSL.Text);
                if (sl == 0)
                {
                    MessageBox.Show("Số lượng không hợp lệ", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSL.Select();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Số lượng không hợp lệ", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSL.Select();
                return;
            }
            
            // trước khi thêm cần ktra đã có ch
            var item = db.ChiTietHoaDonBans.SingleOrDefault(x => x.IDHoaDon == idHoaDon && x.IDMatHang == int.Parse(r.Cells["mahang"].Value.ToString()));
            if (item != null) // đã gọi trước đó rồi
            {
                item.SL += sl;
                db.SubmitChanges();
            }
            else
            {
                var ct = new ChiTietHoaDonBan();
                ct.IDHoaDon = idHoaDon;
                ct.IDMatHang = int.Parse(r.Cells["mahang"].Value.ToString());
                ct.SL = sl;

                var mh = db.MatHangs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["mahang"].Value.ToString()));

                ct.DonGia = mh.DonGiaBan;

                db.ChiTietHoaDonBans.InsertOnSubmit(ct);
                db.SubmitChanges();
            }
            MessageBox.Show("Thêm mặt hàng vào phòng: " + tenphong + " thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}
