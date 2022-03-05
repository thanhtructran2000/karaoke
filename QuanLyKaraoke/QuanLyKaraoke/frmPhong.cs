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
    public partial class frmPhong : Form
    {
        public frmPhong()
        {
            InitializeComponent();
        }
        private Karaoke_DatabaseDataContext db;
        private string nhanvien = "admin";
        private void frmPhong_Load(object sender, EventArgs e)
        {
            db = new Karaoke_DatabaseDataContext();
            ShowData();

            cbbLoaiPhong.DataSource = db.LoaiPhongs;
            cbbLoaiPhong.DisplayMember = "tenloaiphong";
            cbbLoaiPhong.ValueMember = "id";
            cbbLoaiPhong.SelectedIndex = -1;

            dgvPhong.Columns["id"].HeaderText = "Mã phòng";
            dgvPhong.Columns["tenloaiphong"].HeaderText = "Loại phòng";
            dgvPhong.Columns["tenphong"].HeaderText = "Tên phòng";
            dgvPhong.Columns["dongia"].HeaderText = "Đơn giá";
            dgvPhong.Columns["succhua"].HeaderText = "Sức chứa";


            

            dgvPhong.Columns["id"].Width = 100;
            dgvPhong.Columns["tenloaiphong"].Width = 200;
            dgvPhong.Columns["succhua"].Width = 100;
            dgvPhong.Columns["dongia"].Width = 100;
            dgvPhong.Columns["tenphong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvPhong.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhong.Columns["succhua"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhong.Columns["dongia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvPhong.Columns["dongia"].DefaultCellStyle.Format = "N0";
        }
        private void ShowData()
        {
            var rs = from p in db.Phongs
                     join l in db.LoaiPhongs on p.IDLoaiPhong equals l.ID
                     select new
                     {
                         p.ID,
                         l.TenLoaiPhong,
                         p.TenPhong,
                         l.DonGia,
                         p.SucChua
                     };
            dgvPhong.DataSource = rs;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phòng", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPhong.Select();
                return;
            }
            if (cbbLoaiPhong.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            if (string.IsNullOrEmpty(txtSucChua.Text) || int.Parse(txtSucChua.Text)<=0)
            {
                MessageBox.Show("Sức chứa của phòng phải lớn hơn 0", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSucChua.Select();
                return;
            }
            var p = new Phong();
            p.TenPhong = txtTenPhong.Text;
            p.IDLoaiPhong = int.Parse(cbbLoaiPhong.SelectedValue.ToString());
            p.SucChua = int.Parse(txtSucChua.Text);

            p.NgayTao = DateTime.Now;
            p.NguoiTao = nhanvien;

            db.Phongs.InsertOnSubmit(p);
            db.SubmitChanges();

            MessageBox.Show("Thêm mới phòng thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowData();
            txtTenPhong.Text = txtSucChua.Text = null;
            cbbLoaiPhong.SelectedIndex = -1;
        }

        private void txtSucChua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // chỉ được nhập số 
            {
                e.Handled = true;
            }
        }
        private DataGridViewRow r;
        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvPhong.Rows[e.RowIndex];
                txtTenPhong.Text = r.Cells["tenphong"].Value.ToString();
                txtSucChua.Text = r.Cells["succhua"].Value.ToString();
                cbbLoaiPhong.Text = r.Cells["tenloaiphong"].Value.ToString();
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phòng", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPhong.Select();
                return;
            }
            if (cbbLoaiPhong.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtSucChua.Text) || int.Parse(txtSucChua.Text) <= 0)
            {
                MessageBox.Show("Sức chứa của phòng phải lớn hơn 0", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSucChua.Select();
                return;
            }
            var p = db.Phongs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
            p.TenPhong = txtTenPhong.Text;
            p.IDLoaiPhong = int.Parse(cbbLoaiPhong.SelectedValue.ToString());
            p.SucChua = int.Parse(txtSucChua.Text);

            p.NgayCapNhat = DateTime.Now;
            p.NguoiTao = nhanvien;

            db.SubmitChanges();
            MessageBox.Show("Cập nhật phòng thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowData();
            txtTenPhong.Text = txtSucChua.Text = null;
            cbbLoaiPhong.SelectedIndex = -1;
            r = null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn phòng muốn xóa", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (
                MessageBox.Show("Bạn có muốn xóa phòng: " + r.Cells["tenphong"].Value.ToString() + " ?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) == DialogResult.Yes)
            {
                try
                {
                    var p = db.Phongs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
                    db.Phongs.DeleteOnSubmit(p);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa phòng thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowData(); // sau khi thêm ms xog cập nhật lại danh sách hiển thị mặt hàng 


                    //reset lại giá trị cho các component 
                    txtSucChua.Text = null;
                    txtTenPhong.Text = "0";
                    r = null;
                }
                catch
                {
                    MessageBox.Show("Xóa phòng thất bại", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
