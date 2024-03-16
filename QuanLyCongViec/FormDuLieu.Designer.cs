namespace QuanLyCongViec
{
    partial class FormDuLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDuLieu));
            this.tabDulieu = new System.Windows.Forms.TabControl();
            this.CuDan = new System.Windows.Forms.TabPage();
            this.dscudan = new System.Windows.Forms.DataGridView();
            this.CanHo = new System.Windows.Forms.TabPage();
            this.dsch = new System.Windows.Forms.DataGridView();
            this.Quyen = new System.Windows.Forms.TabPage();
            this.dsqh = new System.Windows.Forms.DataGridView();
            this.TaiKhoan = new System.Windows.Forms.TabPage();
            this.dstk = new System.Windows.Forms.DataGridView();
            this.NhanVien = new System.Windows.Forms.TabPage();
            this.dsnv = new System.Windows.Forms.DataGridView();
            this.PhongBan = new System.Windows.Forms.TabPage();
            this.dspb = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timkiem = new System.Windows.Forms.Button();
            this.txbtimkiem = new System.Windows.Forms.TextBox();
            this.tabDulieu.SuspendLayout();
            this.CuDan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dscudan)).BeginInit();
            this.CanHo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsch)).BeginInit();
            this.Quyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsqh)).BeginInit();
            this.TaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dstk)).BeginInit();
            this.NhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsnv)).BeginInit();
            this.PhongBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dspb)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDulieu
            // 
            this.tabDulieu.Controls.Add(this.CuDan);
            this.tabDulieu.Controls.Add(this.CanHo);
            this.tabDulieu.Controls.Add(this.Quyen);
            this.tabDulieu.Controls.Add(this.TaiKhoan);
            this.tabDulieu.Controls.Add(this.NhanVien);
            this.tabDulieu.Controls.Add(this.PhongBan);
            this.tabDulieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDulieu.Location = new System.Drawing.Point(0, -2);
            this.tabDulieu.Name = "tabDulieu";
            this.tabDulieu.SelectedIndex = 0;
            this.tabDulieu.Size = new System.Drawing.Size(1161, 538);
            this.tabDulieu.TabIndex = 0;
            // 
            // CuDan
            // 
            this.CuDan.Controls.Add(this.dscudan);
            this.CuDan.Location = new System.Drawing.Point(4, 29);
            this.CuDan.Name = "CuDan";
            this.CuDan.Padding = new System.Windows.Forms.Padding(3);
            this.CuDan.Size = new System.Drawing.Size(1153, 505);
            this.CuDan.TabIndex = 1;
            this.CuDan.Text = "Cư dân";
            this.CuDan.UseVisualStyleBackColor = true;
            this.CuDan.Click += new System.EventHandler(this.CuDan_Click);
            // 
            // dscudan
            // 
            this.dscudan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dscudan.Location = new System.Drawing.Point(-4, 6);
            this.dscudan.Name = "dscudan";
            this.dscudan.ReadOnly = true;
            this.dscudan.RowHeadersWidth = 51;
            this.dscudan.RowTemplate.Height = 24;
            this.dscudan.Size = new System.Drawing.Size(1151, 493);
            this.dscudan.TabIndex = 0;
            // 
            // CanHo
            // 
            this.CanHo.Controls.Add(this.dsch);
            this.CanHo.Location = new System.Drawing.Point(4, 29);
            this.CanHo.Name = "CanHo";
            this.CanHo.Size = new System.Drawing.Size(1153, 505);
            this.CanHo.TabIndex = 4;
            this.CanHo.Text = "Căn hộ";
            this.CanHo.UseVisualStyleBackColor = true;
            // 
            // dsch
            // 
            this.dsch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsch.Location = new System.Drawing.Point(3, 3);
            this.dsch.Name = "dsch";
            this.dsch.RowHeadersWidth = 51;
            this.dsch.RowTemplate.Height = 24;
            this.dsch.Size = new System.Drawing.Size(1147, 523);
            this.dsch.TabIndex = 0;
            // 
            // Quyen
            // 
            this.Quyen.Controls.Add(this.dsqh);
            this.Quyen.Location = new System.Drawing.Point(4, 29);
            this.Quyen.Name = "Quyen";
            this.Quyen.Size = new System.Drawing.Size(1153, 505);
            this.Quyen.TabIndex = 5;
            this.Quyen.Text = "Quyền hạn";
            this.Quyen.UseVisualStyleBackColor = true;
            // 
            // dsqh
            // 
            this.dsqh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsqh.Location = new System.Drawing.Point(3, 3);
            this.dsqh.Name = "dsqh";
            this.dsqh.RowHeadersWidth = 51;
            this.dsqh.RowTemplate.Height = 24;
            this.dsqh.Size = new System.Drawing.Size(1147, 523);
            this.dsqh.TabIndex = 1;
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.Controls.Add(this.dstk);
            this.TaiKhoan.Location = new System.Drawing.Point(4, 29);
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.Size = new System.Drawing.Size(1153, 505);
            this.TaiKhoan.TabIndex = 3;
            this.TaiKhoan.Text = "Tài khoản";
            this.TaiKhoan.UseVisualStyleBackColor = true;
            // 
            // dstk
            // 
            this.dstk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dstk.Location = new System.Drawing.Point(0, 3);
            this.dstk.Name = "dstk";
            this.dstk.RowHeadersWidth = 51;
            this.dstk.RowTemplate.Height = 24;
            this.dstk.Size = new System.Drawing.Size(1150, 526);
            this.dstk.TabIndex = 0;
            // 
            // NhanVien
            // 
            this.NhanVien.Controls.Add(this.dsnv);
            this.NhanVien.Location = new System.Drawing.Point(4, 29);
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.NhanVien.Size = new System.Drawing.Size(1153, 505);
            this.NhanVien.TabIndex = 0;
            this.NhanVien.Text = "Nhân viên";
            this.NhanVien.UseVisualStyleBackColor = true;
            // 
            // dsnv
            // 
            this.dsnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsnv.Location = new System.Drawing.Point(-4, 0);
            this.dsnv.Name = "dsnv";
            this.dsnv.ReadOnly = true;
            this.dsnv.RowHeadersWidth = 51;
            this.dsnv.RowTemplate.Height = 24;
            this.dsnv.Size = new System.Drawing.Size(1151, 526);
            this.dsnv.TabIndex = 0;
            // 
            // PhongBan
            // 
            this.PhongBan.Controls.Add(this.dspb);
            this.PhongBan.Location = new System.Drawing.Point(4, 29);
            this.PhongBan.Name = "PhongBan";
            this.PhongBan.Size = new System.Drawing.Size(1153, 505);
            this.PhongBan.TabIndex = 2;
            this.PhongBan.Text = "Phòng ban";
            this.PhongBan.UseVisualStyleBackColor = true;
            // 
            // dspb
            // 
            this.dspb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dspb.Location = new System.Drawing.Point(-4, 3);
            this.dspb.Name = "dspb";
            this.dspb.ReadOnly = true;
            this.dspb.RowHeadersWidth = 100;
            this.dspb.RowTemplate.Height = 24;
            this.dspb.Size = new System.Drawing.Size(1154, 523);
            this.dspb.TabIndex = 0;
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(856, 582);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(88, 37);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(752, 582);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(88, 37);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(658, 582);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(88, 37);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Enabled = false;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(959, 582);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(88, 37);
            this.btnluu.TabIndex = 4;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1066, 582);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 37);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Enabled = false;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(541, 582);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(111, 37);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.timkiem);
            this.groupBox1.Controls.Add(this.txbtimkiem);
            this.groupBox1.Location = new System.Drawing.Point(12, 555);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 73);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // timkiem
            // 
            this.timkiem.Image = ((System.Drawing.Image)(resources.GetObject("timkiem.Image")));
            this.timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timkiem.Location = new System.Drawing.Point(361, 17);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(117, 35);
            this.timkiem.TabIndex = 6;
            this.timkiem.Text = "Tìm kiếm";
            this.timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.timkiem.UseVisualStyleBackColor = true;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // txbtimkiem
            // 
            this.txbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbtimkiem.Location = new System.Drawing.Point(6, 24);
            this.txbtimkiem.Name = "txbtimkiem";
            this.txbtimkiem.Size = new System.Drawing.Size(330, 27);
            this.txbtimkiem.TabIndex = 2;
            this.txbtimkiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1173, 640);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.tabDulieu);
            this.Name = "FormDuLieu";
            this.Text = "Dữ liệu Công ty";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDuLieu_FormClosing);
            this.Load += new System.EventHandler(this.FormDuLieu_Load);
            this.tabDulieu.ResumeLayout(false);
            this.CuDan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dscudan)).EndInit();
            this.CanHo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsch)).EndInit();
            this.Quyen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsqh)).EndInit();
            this.TaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dstk)).EndInit();
            this.NhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsnv)).EndInit();
            this.PhongBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dspb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabDulieu;
        private System.Windows.Forms.TabPage NhanVien;
        private System.Windows.Forms.TabPage CuDan;
        private System.Windows.Forms.TabPage PhongBan;
        private System.Windows.Forms.DataGridView dscudan;
        private System.Windows.Forms.DataGridView dsnv;
        private System.Windows.Forms.DataGridView dspb;
        private System.Windows.Forms.TabPage TaiKhoan;
        private System.Windows.Forms.DataGridView dstk;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TabPage CanHo;
        private System.Windows.Forms.TabPage Quyen;
        private System.Windows.Forms.DataGridView dsch;
        private System.Windows.Forms.DataGridView dsqh;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbtimkiem;
    }
}