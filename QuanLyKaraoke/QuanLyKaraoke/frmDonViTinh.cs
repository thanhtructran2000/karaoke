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
    public partial class frmDonViTinh : Form
    {
        public frmDonViTinh()
        {
            InitializeComponent();
        }
        private Karaoke_DatabaseDataContext db;
        private string nhanvien = "admin";
        private void frmDonViTinh_Load(object sender, EventArgs e)
        {
            db = new Karaoke_DatabaseDataContext();
            ShowData();
            dgvDVT.Columns["id"].HeaderText = "Mã ĐVT";
            dgvDVT.Columns["id"].Width = 100; // bề rộng cột
            dgvDVT.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // cân giữa cột

            dgvDVT.Columns["TenDVT"].HeaderText = "Tên ĐVT";
            dgvDVT.Columns["TenDVT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // bề rộng tự giãn
        }
        private void ShowData()
        {
            var rs = (from d in db.DonViTinhs
                        select new
                        {
                            d.ID,
                            d.TenDVT
                        }).ToList();
            dgvDVT.DataSource = rs;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtDVT.Text))
            {
                DonViTinh dvt = new DonViTinh();
                dvt.TenDVT = txtDVT.Text;
                dvt.NguoiTao = nhanvien;
                dvt.NgayTao = DateTime.Now;
                db.DonViTinhs.InsertOnSubmit(dvt); // luu vào csdl
                db.SubmitChanges();
                MessageBox.Show("Thêm mới đơn vị tính thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData(); // gọi lại hàm showdata để hiển thị danh sách
                txtDVT.Text = null; // sau khi thêm thành coog thì reset lại giá trị 
            }   
            else
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính","Chú ý",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }    
        }
        private DataGridViewRow r;
        private void dgvDVT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.RowIndex.ToString());
            r = dgvDVT.Rows[e.RowIndex]; // hàng đc chọn dựa vào sự kiện clickchuot
            //MessageBox.Show(r.Cells["TenDVT"].Value.ToString());
            txtDVT.Text = r.Cells["TenDVT"].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDVT_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (r == null) // nếu k có hàng nào đc chọn
            {
                MessageBox.Show("Vui lòng chọn đơn vị tính cần cập nhật", "Chú ý!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // dừng lại ngang đây mà k thực hiện việc sửa
            }    
            if(!string.IsNullOrEmpty(txtDVT.Text))
            {
                var dvt = db.DonViTinhs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
                dvt.TenDVT = txtDVT.Text;
                dvt.NgayCapNhat = DateTime.Now;
                dvt.NguoiCapNhat = nhanvien;
                db.SubmitChanges();
                MessageBox.Show("Cập nhật đơn vị tính thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
                r = null;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên đơn vị tính", "Chú ý!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // dừng lại ngang đây mà k thực hiện việc sửa
            } 
                
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn đơn vị tính cần xóa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            if(MessageBox.Show("Bạn thực sự muốn xóa đơn vị tính" + r.Cells["TenDVT"].Value.ToString()+" ?",
                                "Xác nhận xóa",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes
               )
            {
                var dvt = db.DonViTinhs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
                db.DonViTinhs.DeleteOnSubmit(dvt);
                db.SubmitChanges();
                MessageBox.Show("Xóa đơn vị tính thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
                r = null;
            }    
        }
    }
}
