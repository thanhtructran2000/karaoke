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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public NhanVien nv;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTaiKhoan.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Select();
                return;
            }

            Karaoke_DatabaseDataContext db = new Karaoke_DatabaseDataContext();
            var tk = db.NhanViens.SingleOrDefault(x => x.Username == txtTaiKhoan.Text && x.Password == txtMatKhau.Text);
            if (tk !=null)
            {
                // mở bảng nhân viên ra xem
                nv = tk;
                this.Dispose();
            }   
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại tài khoản và mật khẩu", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Select();
                return;
            }    
        }
    }
}
