
namespace QuanLyKaraoke
{
    partial class frmBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcContent = new System.Windows.Forms.TabControl();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.lblPhongDaChon = new System.Windows.Forms.Label();
            this.dgvDanhSachMatHang = new System.Windows.Forms.DataGridView();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.pnlThoiGian = new System.Windows.Forms.Panel();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.mtbKetThuc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbBatDau = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblChiTietPhong = new System.Windows.Forms.Label();
            this.dgvChiTietBanHang = new System.Windows.Forms.DataGridView();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMatHang)).BeginInit();
            this.panelOrder.SuspendLayout();
            this.pnlThoiGian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcContent
            // 
            this.tbcContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcContent.Location = new System.Drawing.Point(0, 0);
            this.tbcContent.Name = "tbcContent";
            this.tbcContent.SelectedIndex = 0;
            this.tbcContent.Size = new System.Drawing.Size(1419, 609);
            this.tbcContent.TabIndex = 0;
            this.tbcContent.SelectedIndexChanged += new System.EventHandler(this.tbcContent_SelectedIndexChanged);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.lblPhongDaChon);
            this.pnlControl.Controls.Add(this.dgvDanhSachMatHang);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControl.Location = new System.Drawing.Point(956, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(463, 609);
            this.pnlControl.TabIndex = 0;
            // 
            // lblPhongDaChon
            // 
            this.lblPhongDaChon.AutoSize = true;
            this.lblPhongDaChon.Location = new System.Drawing.Point(338, 25);
            this.lblPhongDaChon.Name = "lblPhongDaChon";
            this.lblPhongDaChon.Size = new System.Drawing.Size(12, 17);
            this.lblPhongDaChon.TabIndex = 2;
            this.lblPhongDaChon.Text = ".";
            this.lblPhongDaChon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvDanhSachMatHang
            // 
            this.dgvDanhSachMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMatHang.Location = new System.Drawing.Point(6, 67);
            this.dgvDanhSachMatHang.Name = "dgvDanhSachMatHang";
            this.dgvDanhSachMatHang.RowHeadersWidth = 51;
            this.dgvDanhSachMatHang.RowTemplate.Height = 24;
            this.dgvDanhSachMatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachMatHang.Size = new System.Drawing.Size(450, 580);
            this.dgvDanhSachMatHang.TabIndex = 1;
            this.dgvDanhSachMatHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachMatHang_CellDoubleClick);
            // 
            // panelOrder
            // 
            this.panelOrder.Controls.Add(this.dgvChiTietBanHang);
            this.panelOrder.Controls.Add(this.pnlThoiGian);
            this.panelOrder.Controls.Add(this.lblChiTietPhong);
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOrder.Location = new System.Drawing.Point(0, 413);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(956, 196);
            this.panelOrder.TabIndex = 1;
            // 
            // pnlThoiGian
            // 
            this.pnlThoiGian.Controls.Add(this.btnBatDau);
            this.pnlThoiGian.Controls.Add(this.btnKetThuc);
            this.pnlThoiGian.Controls.Add(this.mtbKetThuc);
            this.pnlThoiGian.Controls.Add(this.label4);
            this.pnlThoiGian.Controls.Add(this.mtbBatDau);
            this.pnlThoiGian.Controls.Add(this.label3);
            this.pnlThoiGian.Location = new System.Drawing.Point(24, 47);
            this.pnlThoiGian.Name = "pnlThoiGian";
            this.pnlThoiGian.Size = new System.Drawing.Size(249, 132);
            this.pnlThoiGian.TabIndex = 3;
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKetThuc.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnKetThuc.Enabled = false;
            this.btnKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetThuc.ForeColor = System.Drawing.Color.Black;
            this.btnKetThuc.Location = new System.Drawing.Point(125, 88);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(98, 35);
            this.btnKetThuc.TabIndex = 6;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // mtbKetThuc
            // 
            this.mtbKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbKetThuc.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mtbKetThuc.Location = new System.Drawing.Point(93, 60);
            this.mtbKetThuc.Mask = "00/00/0000 90:00";
            this.mtbKetThuc.Name = "mtbKetThuc";
            this.mtbKetThuc.Size = new System.Drawing.Size(130, 22);
            this.mtbKetThuc.TabIndex = 5;
            this.mtbKetThuc.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kết thúc:";
            // 
            // mtbBatDau
            // 
            this.mtbBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbBatDau.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mtbBatDau.Location = new System.Drawing.Point(93, 16);
            this.mtbBatDau.Mask = "00/00/0000 90:00";
            this.mtbBatDau.Name = "mtbBatDau";
            this.mtbBatDau.Size = new System.Drawing.Size(130, 22);
            this.mtbBatDau.TabIndex = 3;
            this.mtbBatDau.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bắt đầu:";
            // 
            // lblChiTietPhong
            // 
            this.lblChiTietPhong.AutoSize = true;
            this.lblChiTietPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietPhong.Location = new System.Drawing.Point(21, 11);
            this.lblChiTietPhong.Name = "lblChiTietPhong";
            this.lblChiTietPhong.Size = new System.Drawing.Size(370, 18);
            this.lblChiTietPhong.TabIndex = 1;
            this.lblChiTietPhong.Text = "DANH SÁCH MẶT HÀNG PHÒNG ĐÃ SỬ DỤNG";
            // 
            // dgvChiTietBanHang
            // 
            this.dgvChiTietBanHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietBanHang.Location = new System.Drawing.Point(312, 35);
            this.dgvChiTietBanHang.Name = "dgvChiTietBanHang";
            this.dgvChiTietBanHang.RowHeadersWidth = 51;
            this.dgvChiTietBanHang.RowTemplate.Height = 24;
            this.dgvChiTietBanHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietBanHang.Size = new System.Drawing.Size(627, 149);
            this.dgvChiTietBanHang.TabIndex = 4;
            // 
            // btnBatDau
            // 
            this.btnBatDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatDau.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.ForeColor = System.Drawing.Color.Black;
            this.btnBatDau.Location = new System.Drawing.Point(15, 88);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(98, 35);
            this.btnBatDau.TabIndex = 7;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = false;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1419, 609);
            this.Controls.Add(this.panelOrder);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.tbcContent);
            this.Name = "frmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBanHang";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMatHang)).EndInit();
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            this.pnlThoiGian.ResumeLayout(false);
            this.pnlThoiGian.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBanHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbcContent;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Panel pnlThoiGian;
        private System.Windows.Forms.MaskedTextBox mtbBatDau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblChiTietPhong;
        private System.Windows.Forms.MaskedTextBox mtbKetThuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.DataGridView dgvDanhSachMatHang;
        private System.Windows.Forms.Label lblPhongDaChon;
        private System.Windows.Forms.DataGridView dgvChiTietBanHang;
        private System.Windows.Forms.Button btnBatDau;
    }
}