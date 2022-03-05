using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKaraoke
{
    public partial class frmMain : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]

        public static extern bool ReleaseCapture();
        public frmMain()
        {
            InitializeComponent();
        }
        private Boolean isMaximize = false;
        private void ptbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbMaximize_Click(object sender, EventArgs e)
        {
            if (!isMaximize)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
                ptbMaximize.Image = Properties.Resources.res;
            }    
            else
            {
                this.WindowState = FormWindowState.Normal;
                ptbMaximize.Image = Properties.Resources.maximize;
            }
            isMaximize = !isMaximize;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }    
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var f = new frmDangNhap();
            f.ShowDialog();
            var nv = f.nv;
            lblNhanVien.Text = String.Format("Nhân viên: {0}", nv.HoVaTen);
           
        }

        private void loaiPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmLoaiPhong(); // khai báo form 
            addForm(f);
            
        }
        private void addForm(Form f)
        {
            f.FormBorderStyle = FormBorderStyle.None; // bỏ viền form
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            f.TopMost = true;
            grbContent.Controls.Clear(); // xóa các item đang có trên groupbox
            grbContent.Controls.Add(f);
            f.Show();
        }

        private void phongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmPhong();
            addForm(f);
        }

        private void matHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmMatHang();
            addForm(f);
        }

        private void dvtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDonViTinh();
            addForm(f);
        }

        private void nccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmNhaCungCap();
            addForm(f);
        }

        private void nvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmNhanVien();
            addForm(f);
        }

        private void nhapHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmNhapHang();
            addForm(f);
        }

        private void banHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmBanHang();
            addForm(f);
        }
    }
}
