using QuanLyKaraoke.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKaraoke
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }
        private Karaoke_DatabaseDataContext db;
        private ListView lv;
        private ImageList imgl;
        private string nhanvien = "admin";
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            db = new Karaoke_DatabaseDataContext();
            var dsLoaiPhong = db.LoaiPhongs;
            foreach(var l in dsLoaiPhong)
            {
                TabPage tp = new TabPage(l.TenLoaiPhong);
                tp.Name = l.ID.ToString();
                tbcContent.Controls.Add(tp);
            }
            idLoaiPhong = db.LoaiPhongs.Min(x => x.ID);
            LoadPhong(idLoaiPhong, tabIndex);
            ShowMatHang();
            dgvDanhSachMatHang.Columns["mahang"].Visible = false;
            dgvDanhSachMatHang.Columns["tenhang"].HeaderText = "Mặt hàng";
            dgvDanhSachMatHang.Columns["dvt"].HeaderText = "ĐVT";
            dgvDanhSachMatHang.Columns["dg"].HeaderText = "Giá";
            dgvDanhSachMatHang.Columns["tonkho"].HeaderText = "Tồn";

            dgvDanhSachMatHang.Columns["dvt"].Width = 50;
            dgvDanhSachMatHang.Columns["dg"].Width = 70;
            dgvDanhSachMatHang.Columns["tonkho"].Width = 70;
            dgvDanhSachMatHang.Columns["tenhang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvDanhSachMatHang.Columns["dvt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDanhSachMatHang.Columns["dg"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDanhSachMatHang.Columns["tonkho"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvDanhSachMatHang.Columns["dg"].DefaultCellStyle.Format = "N0";
            dgvDanhSachMatHang.Columns["tonkho"].DefaultCellStyle.Format = "N0";

            
        }
        private void LoadPhong(int loaiphong, int tabIndex)
        {
            tbcContent.TabPages[tabIndex].Controls.Clear();
            lv = new ListView();
            lv.Dock = DockStyle.Fill;
            lv.SelectedIndexChanged += lv_SelectedIndexChanged;
            ImageList imgl = new ImageList();
            imgl.ImageSize = new Size(256, 128);
            imgl.Images.Add(Properties.Resources.free);
            imgl.Images.Add(Properties.Resources.singer);
            lv.LargeImageList = imgl;
               
            var dsPhong = db.Phongs.Where(x => x.IDLoaiPhong == loaiphong);
            foreach (var p in dsPhong)
            {
                if (p.TrangThai == 1)
                {
                    lv.Items.Add(new ListViewItem { ImageIndex = 1, Text = p.TenPhong,Name = p.ID.ToString() , Tag = true});
                    //tag = true để đánh dấu phòng đag có khách
                }
                else
                {
                    lv.Items.Add(new ListViewItem { ImageIndex = 0, Text = p.TenPhong, Name = p.ID.ToString() , Tag = false});
                    // tag = false để đánh dấu phòng đang trống
                }
            }
            tbcContent.TabPages[tabIndex].Controls.Add(lv);
            
        }
        int idLoaiPhong = 0;
        private string tenphong;
        private long idHoaDon = 0;
        private int idPhong = 0;
        private int tabIndex = 0;
        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idx = lv.SelectedIndices;
            if(idx.Count >0)
            {
                idPhong = int.Parse(lv.SelectedItems[0].Name);
                tenphong = lv.SelectedItems[0].Text.ToUpper();
                lblPhongDaChon.Text = tenphong;
                if((bool)lv.SelectedItems[0].Tag)// neu phong đang có khách 
                {
                    btnBatDau.Enabled = false;
                    btnKetThuc.Enabled = true;
                    // khi lấy thông tin trên listview <-> click vào phòng
                    // lấy thông tin hóa đơn bán hàng dựa vào id phòng
                    // lấy hóa đơn có id lớn nhất có mã bàn đag đc chọn
                    var hd = db.HoaDonBanHangs.FirstOrDefault(x => x.IDHoaDon == db.HoaDonBanHangs.Where(y =>y.IDPhong == idPhong).Max(z=>z.IDHoaDon));
                    idHoaDon = hd.IDHoaDon;
                    // khi phòng đag có khách -> thời gian bd được tính trong hóa đơn
                    
                    mtbKetThuc.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm"); // giờ kết thúc bằng giờ hiện tại
                    mtbBatDau.Text = ((DateTime)hd.ThoiGianBDau).ToString("dd/MM/yyyy HH:mm");

                    ShowChiTietHoaDon();

                }
                else
                {
                    // nếu phòng ch có khách 
                    
                    dgvChiTietBanHang.DataSource = null;
                    mtbBatDau.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm"); // giờ bắt đầu bằng giờ hiện tại
                    btnBatDau.Enabled = true;
                    btnKetThuc.Enabled = false;
                    
                } 
                    
                
            }    
            
           
        }

        private void ShowMatHang()
        {
            var nhap = from p in db.ChiTietHoaDonNhaps.GroupBy(x => x.IDMatHang)
                       select new
                       {
                           mahang = p.First().IDMatHang,
                           tongnhap = p.Sum(x => x.SoLuong)
                       };
            var xuat = from p in db.ChiTietHoaDonBans.GroupBy(x => x.IDMatHang)
                       select new
                       {
                           mahang = p.First().IDMatHang,
                           tongxuat = p.Sum(x => x.IDMatHang)
                       };
            var khadung = from p in nhap
                          join q in xuat on p.mahang equals q.mahang into t
                          join h in db.MatHangs on p.mahang equals h.ID
                          join d in db.DonViTinhs on h.DVT equals d.ID
                          from s in t.DefaultIfEmpty()
                          select new
                          {
                              mahang = p.mahang,
                              tenhang = h.TenMatHang,
                              dvt = d.TenDVT,
                              dg = h.DonGiaBan,
                              tonkho = s.mahang == null ? p.tongnhap : p.tongnhap - s.tongxuat
                          };
            dgvDanhSachMatHang.DataSource = khadung.OrderBy(x=>x.tenhang);
                          
                       
                       
        }
       

        private void tbcContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            idLoaiPhong = int.Parse(tbcContent.SelectedTab.Name);
            tabIndex = tbcContent.SelectedIndex;
            LoadPhong(idLoaiPhong, tabIndex);
        }

        private void dgvDanhSachMatHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (idPhong == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng để tiếp tục", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            if(e.RowIndex < 0)
            {
                return;
            }

            var phong = db.Phongs.SingleOrDefault(x => x.ID == idPhong);
            if(phong.TrangThai == 1)
            {
                var r = dgvDanhSachMatHang.Rows[e.RowIndex];
                new frmOrder(idHoaDon, tenphong, r).ShowDialog();
                ShowMatHang();
                ShowChiTietHoaDon();
            }    
           
        }
        private void ShowChiTietHoaDon()
        {
            var rs = from ct in db.ChiTietHoaDonBans.Where(x => x.IDHoaDon == idHoaDon)
                     join h in db.MatHangs on ct.IDMatHang equals h.ID
                     join d in db.DonViTinhs on h.DVT equals d.ID
                     select new
                     {
                         mahang = h.ID,
                         tenhang = h.TenMatHang,
                         dvt = d.TenDVT,
                         sl = ct.SL,
                         dg = ct.DonGia,
                         thanhtien = ct.SL * ct.DonGia
                     };
            dgvChiTietBanHang.DataSource = rs;
            dgvChiTietBanHang.Columns["mahang"].Visible = false;
            dgvChiTietBanHang.Columns["tenhang"].HeaderText = "Mặt hàng";
            dgvChiTietBanHang.Columns["dvt"].HeaderText = "ĐVT";
            dgvChiTietBanHang.Columns["sl"].HeaderText = "SL";
            dgvChiTietBanHang.Columns["dg"].HeaderText = "Đơn giá";
            dgvChiTietBanHang.Columns["thanhtien"].HeaderText = "Thành tiền";

            dgvChiTietBanHang.Columns["sl"].Width = 30;
            dgvChiTietBanHang.Columns["dvt"].Width = 70;
            dgvChiTietBanHang.Columns["dg"].Width = 70;
            dgvChiTietBanHang.Columns["thanhtien"].Width = 100;
            dgvChiTietBanHang.Columns["tenhang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvChiTietBanHang.Columns["dvt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvChiTietBanHang.Columns["sl"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvChiTietBanHang.Columns["dg"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvChiTietBanHang.Columns["thanhtien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvChiTietBanHang.Columns["dg"].DefaultCellStyle.Format = "N0";
            dgvChiTietBanHang.Columns["thanhtien"].DefaultCellStyle.Format = "N0";
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            try
            {
                var od = new HoaDonBanHang();
                od.IDPhong = idPhong;
                od.NguoiBan = nhanvien;
                od.ThoiGianBDau = DateTime.ParseExact(mtbBatDau.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                od.NgayTao = DateTime.Now;
                od.NguoiTao = nhanvien;

                db.HoaDonBanHangs.InsertOnSubmit(od);
                db.SubmitChanges();
                // tạo đơn hàng xog cần cập nhật lại trạng thái hoạt động
                var p = db.Phongs.SingleOrDefault(x => x.ID == idPhong);
                p.TrangThai = 1;
                db.SubmitChanges();
                LoadPhong(idLoaiPhong, tabIndex);
                btnBatDau.Enabled = false;
                btnKetThuc.Enabled = true;
                MessageBox.Show("Gọi phòng thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Gọi phòng thất bại", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            try
            {
                var hd = db.HoaDonBanHangs.SingleOrDefault(x => x.IDHoaDon == idHoaDon);
                hd.ThoiGianKThuc = DateTime.ParseExact(mtbKetThuc.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                db.SubmitChanges();

                var p = db.Phongs.SingleOrDefault(x => x.ID == idPhong);
                p.TrangThai = 0;
                db.SubmitChanges();

                LoadPhong(idLoaiPhong, tabIndex);
                mtbBatDau.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                btnBatDau.Enabled = true;
                btnKetThuc.Enabled = false;
                MessageBox.Show("Thanh toán phòng thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message,"Thanh toán phòng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
