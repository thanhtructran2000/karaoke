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
    public partial class frmMatHang : Form
    {
        public frmMatHang()
        {
            InitializeComponent();
        }

        private Karaoke_DatabaseDataContext db;
        private string nhanvien = "admin";
        private DataGridViewRow r;
        private void frmMatHang_Load(object sender, EventArgs e)
        {
            db = new Karaoke_DatabaseDataContext(); // khởi tạo đối tượng db

            cbbMatHangGoc.DataSource = db.MatHangs.Where(x=>x.IdCha == null || x.IdCha == -1) ;
            cbbMatHangGoc.DisplayMember = "TenMatHang";
            cbbMatHangGoc.ValueMember = "ID";
            cbbMatHangGoc.SelectedIndex = -1;
            ShowData(); //hiển thị dữ liệu danh sách mặt hàng

            dgvMatHang.Columns["idcha"].Visible = false;
            dgvMatHang.Columns["tile"].Visible = false;

            // tinh chỉnh lại 1 số thuộc tính các cột của datagridview 
            dgvMatHang.Columns["id"].Width = 100; // set bề rộng cố định
            dgvMatHang.Columns["tendvt"].Width = 100;
            dgvMatHang.Columns["dongiaban"].Width = 100;

            dgvMatHang.Columns["tenmathang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // tự động co giãn theo form

            // cân chỉnh vị trí
            dgvMatHang.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // căn giữa cho mã hàng
            dgvMatHang.Columns["tendvt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMatHang.Columns["dongiaban"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvMatHang.Columns["dongiaban"].DefaultCellStyle.Format = "N0"; // chấm cách phần ngàn

            // đặt lại tên cột
            dgvMatHang.Columns["id"].HeaderText = "Mã hàng";
            dgvMatHang.Columns["tendvt"].HeaderText = "ĐVT";
            dgvMatHang.Columns["dongiaban"].HeaderText = "Đơn giá";
            dgvMatHang.Columns["tenmathang"].HeaderText = "Tên mặt hàng";


            // đổ dlieu vao combobox cbbDVT
            cbbDVT.DataSource = db.DonViTinhs;
            cbbDVT.DisplayMember = "TenDVT"; // thuộc tính hiển thị
            cbbDVT.ValueMember = "ID"; // thuộc tính giá trị ngầm chính là mã của đơn vị tính

            cbbDVT.SelectedIndex = -1; // k chọn đơn vị tính nào hết


        }

        private void ShowData()
        {
            var rs = from h in db.MatHangs
                     join d in db.DonViTinhs on h.DVT equals d.ID
                     select new
                     {
                         h.ID,
                         h.IdCha,
                         h.Tile,
                         h.TenMatHang,
                         d.TenDVT,
                         h.DonGiaBan
                     };
            dgvMatHang.DataSource = rs;
                     
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTenMatHang.Text)) // kiểm tra tính hợp lệ của tên mặt hàng k đc để trống
            {
                MessageBox.Show("Vui lòng nhập tên mặt hàng", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMatHang.Select(); // set focus con trỏ chuột tại vtri nay
                return; // dừng ngay đây, k thực hiện các câu lệnh phía sau
            }
            if (cbbDVT.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đơn vị tính", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // dừng ngay đây, k thực hiện các câu lệnh phía sau
            }
            if (string.IsNullOrEmpty(txtDonGiaBan.Text)) 
            {
                MessageBox.Show("Vui lòng nhập đơn giá", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGiaBan.Select(); //set focus tại textbox này
                return; // dừng ngay đây, k thực hiện các câu lệnh phía sau
            }
            int idCha = -1;
            int tile = 0;
            if(cbbMatHangGoc.SelectedIndex>=0)
            {
                idCha = int.Parse(cbbMatHangGoc.SelectedValue.ToString());
                try
                {
                    tile = int.Parse(txtTile.Text);
                    if(tile <=0)
                    {
                        MessageBox.Show("Tỷ lệ qui đổi phải lớn hơn 0", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTile.Select();
                        return;
                    }    
                }
                catch
                {
                    MessageBox.Show("Tỷ lệ qui đổi không hợp lệ", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTile.Select();
                    return;
                }
            }    
            var mh = new MatHang(); //khoi tạo 1 đối tượng ms thuộc lớp mặt hàng
            mh.TenMatHang = txtTenMatHang.Text;
            mh.DVT = int.Parse(cbbDVT.SelectedValue.ToString()); // vì gtri nhận đc từ combobox là string
            // tring khi id trong csdl là int => convert string sang int
            mh.DonGiaBan = int.Parse(txtDonGiaBan.Text);

            mh.IdCha = idCha;
            mh.Tile = tile;

            mh.NgayTao = DateTime.Now;
            mh.NguoiTao = nhanvien;

            db.MatHangs.InsertOnSubmit(mh); // thêm mặt hàng mới vào csdl
            db.SubmitChanges(); // lưu

            ShowData(); // sau khi thêm ms xog cập nhật lại danh sách hiển thị mặt hàng 
            MessageBox.Show("Thêm mới mặt hàng thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset lại giá trị cho các component 
            txtTenMatHang.Text = null;
            txtDonGiaBan.Text = "0";
            cbbDVT.SelectedIndex = -1; // k chọn đơn vị tính nào hết


        }

        private void txtDonGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // chỉ cho phép nhập số tự nhiên vào textbox 
            {
                e.Handled = true;
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // tìm ra mặt hàng trong csdl dựa vào khóa chính id 
            var mh = db.MatHangs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
            if (string.IsNullOrEmpty(txtTenMatHang.Text)) // kiểm tra tính hợp lệ của tên mặt hàng k đc để trống
            {
                MessageBox.Show("Vui lòng nhập tên mặt hàng", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMatHang.Select(); // set focus con trỏ chuột tại vtri nay
                return; // dừng ngay đây, k thực hiện các câu lệnh phía sau
            }
            if (cbbDVT.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đơn vị tính", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // dừng ngay đây, k thực hiện các câu lệnh phía sau
            }
            if (string.IsNullOrEmpty(txtDonGiaBan.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn giá", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGiaBan.Select(); //set focus tại textbox này
                return; // dừng ngay đây, k thực hiện các câu lệnh phía sau
            }
            int idCha = -1;
            int tile = 0;
            if (cbbMatHangGoc.SelectedIndex >= 0)
            {
                idCha = int.Parse(cbbMatHangGoc.SelectedValue.ToString());
                try
                {
                    tile = int.Parse(txtTile.Text);
                    if (tile <= 0)
                    {
                        MessageBox.Show("Tỷ lệ qui đổi phải lớn hơn 0", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTile.Select();
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Tỷ lệ qui đổi không hợp lệ", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTile.Select();
                    return;
                }
            }
            // cập nhật lại 
            mh.TenMatHang = txtTenMatHang.Text;
            mh.DVT = int.Parse(cbbDVT.SelectedValue.ToString());
            mh.DonGiaBan = int.Parse(txtDonGiaBan.Text);
            mh.IdCha = idCha;
            mh.Tile = tile;

            mh.NgayCapNhat = DateTime.Now;
            mh.NguoiCapNhat = nhanvien;

            db.SubmitChanges();
            ShowData(); // sau khi thêm ms xog cập nhật lại danh sách hiển thị mặt hàng 
            MessageBox.Show("Cập nhật mặt hàng thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset lại giá trị cho các component 
            txtTenMatHang.Text = null;
            txtDonGiaBan.Text = "0";
            cbbDVT.SelectedIndex = -1; // k chọn đơn vị tính nào hết

        }

        private void dgvMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvMatHang.Rows[e.RowIndex]; // xdinh 1 hang đc click


                // set các gtri cho các component
                txtTenMatHang.Text = r.Cells["tenmathang"].Value.ToString();
                txtDonGiaBan.Text = r.Cells["dongiaban"].Value.ToString();
                cbbDVT.Text = r.Cells["tendvt"].Value.ToString();
                txtTile.Text = r.Cells["tile"].Value == null?"0": r.Cells["tile"].Value.ToString();
                if( r.Cells["idcha"].Value==null || r.Cells["idcha"].Value.ToString() == "-1")
                {
                    cbbMatHangGoc.SelectedIndex = -1;
                }
                else
                {
                    var item = db.MatHangs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["idcha"].Value.ToString()));
                    cbbMatHangGoc.Text = item.TenMatHang;
                }
               
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(r == null)
            {
                MessageBox.Show("Vui lòng chọn mặt hàng cần xóa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    

            if(
                MessageBox.Show("Bạn có muốn xóa mặt hàng: " +r.Cells["tenmathang"].Value.ToString()+" ?",
                "Xác nhận xóa mặt hàng",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) == DialogResult.Yes)
            {
                try
                {
                    var mh = db.MatHangs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
                    db.MatHangs.DeleteOnSubmit(mh);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa mặt hàng thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Xóa mặt hàng thất bại", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ShowData(); // sau khi thêm ms xog cập nhật lại danh sách hiển thị mặt hàng 
                

                //reset lại giá trị cho các component 
                txtTenMatHang.Text = null;
                txtDonGiaBan.Text = "0";
                cbbDVT.SelectedIndex = -1; // k chọn đơn vị tính nào hết
            }
        }

        private void txtTile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // chỉ cho phép nhập số tự nhiên vào textbox 
            {
                e.Handled = true;
            }
        }
    }
}
