using System.Runtime.CompilerServices;

namespace QuanLyCongViec
{
    partial class FormDuLieuNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDuLieuNhanVien));
            this.tabDulieu = new System.Windows.Forms.TabControl();
            this.Quyen = new System.Windows.Forms.TabPage();
            this.dslshd = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TaiKhoan = new System.Windows.Forms.TabPage();
            this.dstk = new System.Windows.Forms.DataGridView();
            this.NhanVien = new System.Windows.Forms.TabPage();
            this.dsnv = new System.Windows.Forms.DataGridView();
            this.PhongBan = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dspb = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gbtimkiem = new System.Windows.Forms.GroupBox();
            this.timkiem = new System.Windows.Forms.Button();
            this.txbtimkiem = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabDulieu.SuspendLayout();
            this.Quyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dslshd)).BeginInit();
            this.TaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dstk)).BeginInit();
            this.NhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsnv)).BeginInit();
            this.PhongBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dspb)).BeginInit();
            this.gbtimkiem.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDulieu
            // 
            this.tabDulieu.Controls.Add(this.Quyen);
            this.tabDulieu.Controls.Add(this.TaiKhoan);
            this.tabDulieu.Controls.Add(this.NhanVien);
            this.tabDulieu.Controls.Add(this.PhongBan);
            this.tabDulieu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDulieu.Location = new System.Drawing.Point(215, 0);
            this.tabDulieu.Margin = new System.Windows.Forms.Padding(2);
            this.tabDulieu.Name = "tabDulieu";
            this.tabDulieu.SelectedIndex = 0;
            this.tabDulieu.Size = new System.Drawing.Size(880, 445);
            this.tabDulieu.TabIndex = 0;
            // 
            // Quyen
            // 
            this.Quyen.AllowDrop = true;
            this.Quyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Quyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Quyen.Controls.Add(this.dslshd);
            this.Quyen.Controls.Add(this.menuStrip1);
            this.Quyen.ForeColor = System.Drawing.Color.Black;
            this.Quyen.Location = new System.Drawing.Point(4, 27);
            this.Quyen.Margin = new System.Windows.Forms.Padding(2);
            this.Quyen.Name = "Quyen";
            this.Quyen.Size = new System.Drawing.Size(872, 414);
            this.Quyen.TabIndex = 5;
            this.Quyen.Text = "Quyền hạn";
            // 
            // dslshd
            // 
            this.dslshd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dslshd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dslshd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dslshd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dslshd.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dslshd.Location = new System.Drawing.Point(2, -5);
            this.dslshd.Margin = new System.Windows.Forms.Padding(2);
            this.dslshd.Name = "dslshd";
            this.dslshd.RowHeadersWidth = 51;
            this.dslshd.RowTemplate.Height = 24;
            this.dslshd.Size = new System.Drawing.Size(881, 417);
            this.dslshd.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.Controls.Add(this.dstk);
            this.TaiKhoan.Location = new System.Drawing.Point(4, 27);
            this.TaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.Size = new System.Drawing.Size(872, 414);
            this.TaiKhoan.TabIndex = 3;
            this.TaiKhoan.Text = "Tài khoản";
            this.TaiKhoan.UseVisualStyleBackColor = true;
            // 
            // dstk
            // 
            this.dstk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dstk.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dstk.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dstk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dstk.Location = new System.Drawing.Point(0, 2);
            this.dstk.Margin = new System.Windows.Forms.Padding(2);
            this.dstk.Name = "dstk";
            this.dstk.RowHeadersWidth = 51;
            this.dstk.RowTemplate.Height = 24;
            this.dstk.Size = new System.Drawing.Size(876, 416);
            this.dstk.TabIndex = 0;
            // 
            // NhanVien
            // 
            this.NhanVien.Controls.Add(this.dsnv);
            this.NhanVien.Location = new System.Drawing.Point(4, 27);
            this.NhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.Padding = new System.Windows.Forms.Padding(2);
            this.NhanVien.Size = new System.Drawing.Size(872, 414);
            this.NhanVien.TabIndex = 0;
            this.NhanVien.Text = "Nhân viên";
            this.NhanVien.UseVisualStyleBackColor = true;
            // 
            // dsnv
            // 
            this.dsnv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dsnv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dsnv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dsnv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dsnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsnv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsnv.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dsnv.Location = new System.Drawing.Point(2, 2);
            this.dsnv.Margin = new System.Windows.Forms.Padding(2);
            this.dsnv.Name = "dsnv";
            this.dsnv.ReadOnly = true;
            this.dsnv.RowHeadersWidth = 51;
            this.dsnv.RowTemplate.Height = 24;
            this.dsnv.Size = new System.Drawing.Size(868, 410);
            this.dsnv.TabIndex = 0;
            // 
            // PhongBan
            // 
            this.PhongBan.BackColor = System.Drawing.Color.DimGray;
            this.PhongBan.Controls.Add(this.groupBox1);
            this.PhongBan.Controls.Add(this.dspb);
            this.PhongBan.Location = new System.Drawing.Point(4, 27);
            this.PhongBan.Margin = new System.Windows.Forms.Padding(2);
            this.PhongBan.Name = "PhongBan";
            this.PhongBan.Size = new System.Drawing.Size(872, 414);
            this.PhongBan.TabIndex = 2;
            this.PhongBan.Text = "Phòng ban";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(-4, -27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 22);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dspb
            // 
            this.dspb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dspb.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dspb.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dspb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dspb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dspb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dspb.Location = new System.Drawing.Point(0, 0);
            this.dspb.Margin = new System.Windows.Forms.Padding(2);
            this.dspb.Name = "dspb";
            this.dspb.ReadOnly = true;
            this.dspb.RowHeadersWidth = 51;
            this.dspb.RowTemplate.Height = 24;
            this.dspb.Size = new System.Drawing.Size(872, 414);
            this.dspb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(75, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "TasMana";
            // 
            // gbtimkiem
            // 
            this.gbtimkiem.AutoSize = true;
            this.gbtimkiem.Controls.Add(this.timkiem);
            this.gbtimkiem.Controls.Add(this.txbtimkiem);
            this.gbtimkiem.ForeColor = System.Drawing.Color.White;
            this.gbtimkiem.Location = new System.Drawing.Point(218, 450);
            this.gbtimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.gbtimkiem.Name = "gbtimkiem";
            this.gbtimkiem.Padding = new System.Windows.Forms.Padding(2);
            this.gbtimkiem.Size = new System.Drawing.Size(388, 67);
            this.gbtimkiem.TabIndex = 4;
            this.gbtimkiem.TabStop = false;
            this.gbtimkiem.Text = "Tìm kiếm";
            // 
            // timkiem
            // 
            this.timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timkiem.Image = ((System.Drawing.Image)(resources.GetObject("timkiem.Image")));
            this.timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timkiem.Location = new System.Drawing.Point(271, 21);
            this.timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(88, 28);
            this.timkiem.TabIndex = 6;
            this.timkiem.Text = "Tìm kiếm";
            this.timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.timkiem.UseVisualStyleBackColor = true;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // txbtimkiem
            // 
            this.txbtimkiem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbtimkiem.Location = new System.Drawing.Point(4, 24);
            this.txbtimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.txbtimkiem.Name = "txbtimkiem";
            this.txbtimkiem.Size = new System.Drawing.Size(248, 23);
            this.txbtimkiem.TabIndex = 2;
            this.txbtimkiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.White;
            this.btnCapNhat.Enabled = false;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCapNhat.Location = new System.Drawing.Point(46, 137);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(131, 31);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.Firebrick;
            this.btnThoat.Location = new System.Drawing.Point(46, 412);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(131, 33);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.Color.White;
            this.btnluu.Enabled = false;
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnluu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnluu.ForeColor = System.Drawing.Color.Firebrick;
            this.btnluu.Location = new System.Drawing.Point(46, 361);
            this.btnluu.Margin = new System.Windows.Forms.Padding(2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(131, 33);
            this.btnluu.TabIndex = 4;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.White;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsua.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnsua.ForeColor = System.Drawing.Color.Firebrick;
            this.btnsua.Location = new System.Drawing.Point(46, 192);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(131, 33);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.White;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnxoa.ForeColor = System.Drawing.Color.Firebrick;
            this.btnxoa.Location = new System.Drawing.Point(46, 249);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(131, 35);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.White;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnthem.ForeColor = System.Drawing.Color.Firebrick;
            this.btnthem.Location = new System.Drawing.Point(46, 306);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(131, 31);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.btnluu);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(-2, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 527);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.pictureBox2.Image = global::QuanLyCongViec.Properties.Resources.LoGoPhanMemTachNen;
            this.pictureBox2.Location = new System.Drawing.Point(6, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyCongViec.Properties.Resources.placeholder1;
            this.pictureBox1.Location = new System.Drawing.Point(-73, -20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 586);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormDuLieuNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1106, 528);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbtimkiem);
            this.Controls.Add(this.tabDulieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDuLieuNhanVien";
            this.Text = "Dữ liệu nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDuLieu_FormClosing);
            this.Load += new System.EventHandler(this.FormDuLieu_Load);
            this.tabDulieu.ResumeLayout(false);
            this.Quyen.ResumeLayout(false);
            this.Quyen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dslshd)).EndInit();
            this.TaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dstk)).EndInit();
            this.NhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsnv)).EndInit();
            this.PhongBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dspb)).EndInit();
            this.gbtimkiem.ResumeLayout(false);
            this.gbtimkiem.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dsnv;
        private System.Windows.Forms.DataGridView dstk;
        private System.Windows.Forms.DataGridView dslshd;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.GroupBox gbtimkiem;
        private System.Windows.Forms.TextBox txbtimkiem;
        public System.Windows.Forms.TabPage NhanVien;
        public System.Windows.Forms.TabPage PhongBan;
        public System.Windows.Forms.TabPage TaiKhoan;
        public System.Windows.Forms.TabPage Quyen;


        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dspb;
        public System.Windows.Forms.TabControl tabDulieu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}