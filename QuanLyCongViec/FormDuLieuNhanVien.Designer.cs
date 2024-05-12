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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDuLieuNhanVien));
            this.tabDulieu = new System.Windows.Forms.TabControl();
            this.Quyen = new System.Windows.Forms.TabPage();
            this.buttonXuatPDF = new System.Windows.Forms.Button();
            this.buttonExportExcel = new System.Windows.Forms.Button();
            this.dslshd = new System.Windows.Forms.DataGridView();
            this.TaiKhoan = new System.Windows.Forms.TabPage();
            this.buttonXuatPDF2 = new System.Windows.Forms.Button();
            this.buttonExportExcel2 = new System.Windows.Forms.Button();
            this.dstk = new System.Windows.Forms.DataGridView();
            this.NhanVien = new System.Windows.Forms.TabPage();
            this.buttonXuatPDF3 = new System.Windows.Forms.Button();
            this.buttonExportExcel3 = new System.Windows.Forms.Button();
            this.dsnv = new System.Windows.Forms.DataGridView();
            this.PhongBan = new System.Windows.Forms.TabPage();
            this.buttonXuatPDF4 = new System.Windows.Forms.Button();
            this.buttonExportExcel4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dspb = new System.Windows.Forms.DataGridView();
            this.DsUyQuyenCV = new System.Windows.Forms.TabPage();
            this.buttonXuatPDF5 = new System.Windows.Forms.Button();
            this.buttonExportExcel5 = new System.Windows.Forms.Button();
            this.dsuqcv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.timkiem = new System.Windows.Forms.Button();
            this.txbtimkiem = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabDulieu.SuspendLayout();
            this.Quyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dslshd)).BeginInit();
            this.TaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dstk)).BeginInit();
            this.NhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsnv)).BeginInit();
            this.PhongBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dspb)).BeginInit();
            this.DsUyQuyenCV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsuqcv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDulieu
            // 
            this.tabDulieu.Controls.Add(this.Quyen);
            this.tabDulieu.Controls.Add(this.TaiKhoan);
            this.tabDulieu.Controls.Add(this.NhanVien);
            this.tabDulieu.Controls.Add(this.PhongBan);
            this.tabDulieu.Controls.Add(this.DsUyQuyenCV);
            this.tabDulieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDulieu.ItemSize = new System.Drawing.Size(100, 30);
            this.tabDulieu.Location = new System.Drawing.Point(331, 2);
            this.tabDulieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDulieu.Name = "tabDulieu";
            this.tabDulieu.SelectedIndex = 0;
            this.tabDulieu.Size = new System.Drawing.Size(1139, 646);
            this.tabDulieu.TabIndex = 0;
            // 
            // Quyen
            // 
            this.Quyen.AllowDrop = true;
            this.Quyen.BackColor = System.Drawing.Color.White;
            this.Quyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Quyen.Controls.Add(this.buttonXuatPDF);
            this.Quyen.Controls.Add(this.buttonExportExcel);
            this.Quyen.Controls.Add(this.dslshd);
            this.Quyen.ForeColor = System.Drawing.Color.Black;
            this.Quyen.Location = new System.Drawing.Point(4, 34);
            this.Quyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Quyen.Name = "Quyen";
            this.Quyen.Size = new System.Drawing.Size(1131, 608);
            this.Quyen.TabIndex = 5;
            this.Quyen.Text = "Quyền hạn";
            // 
            // buttonXuatPDF
            // 
            this.buttonXuatPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.buttonXuatPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXuatPDF.ForeColor = System.Drawing.Color.White;
            this.buttonXuatPDF.Location = new System.Drawing.Point(977, 15);
            this.buttonXuatPDF.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXuatPDF.Name = "buttonXuatPDF";
            this.buttonXuatPDF.Size = new System.Drawing.Size(133, 37);
            this.buttonXuatPDF.TabIndex = 37;
            this.buttonXuatPDF.Text = "Xuất PDF";
            this.buttonXuatPDF.UseVisualStyleBackColor = false;
            this.buttonXuatPDF.Click += new System.EventHandler(this.buttonXuatPDF_Click);
            // 
            // buttonExportExcel
            // 
            this.buttonExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))));
            this.buttonExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportExcel.ForeColor = System.Drawing.Color.White;
            this.buttonExportExcel.Location = new System.Drawing.Point(820, 15);
            this.buttonExportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExportExcel.Name = "buttonExportExcel";
            this.buttonExportExcel.Size = new System.Drawing.Size(133, 37);
            this.buttonExportExcel.TabIndex = 36;
            this.buttonExportExcel.Text = "Xuất Excel";
            this.buttonExportExcel.UseVisualStyleBackColor = false;
            this.buttonExportExcel.Click += new System.EventHandler(this.buttonExportExcel_Click_1);
            // 
            // dslshd
            // 
            this.dslshd.AllowUserToAddRows = false;
            this.dslshd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dslshd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dslshd.BackgroundColor = System.Drawing.Color.White;
            this.dslshd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dslshd.DefaultCellStyle = dataGridViewCellStyle1;
            this.dslshd.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dslshd.Location = new System.Drawing.Point(19, 71);
            this.dslshd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dslshd.Name = "dslshd";
            this.dslshd.ReadOnly = true;
            this.dslshd.RowHeadersWidth = 51;
            this.dslshd.RowTemplate.Height = 24;
            this.dslshd.Size = new System.Drawing.Size(1095, 506);
            this.dslshd.TabIndex = 1;
            this.dslshd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dslshd_CellContentClick);
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.Controls.Add(this.buttonXuatPDF2);
            this.TaiKhoan.Controls.Add(this.buttonExportExcel2);
            this.TaiKhoan.Controls.Add(this.dstk);
            this.TaiKhoan.Location = new System.Drawing.Point(4, 34);
            this.TaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.Size = new System.Drawing.Size(1131, 608);
            this.TaiKhoan.TabIndex = 3;
            this.TaiKhoan.Text = "Tài khoản";
            this.TaiKhoan.UseVisualStyleBackColor = true;
            // 
            // buttonXuatPDF2
            // 
            this.buttonXuatPDF2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.buttonXuatPDF2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXuatPDF2.ForeColor = System.Drawing.Color.White;
            this.buttonXuatPDF2.Location = new System.Drawing.Point(980, 17);
            this.buttonXuatPDF2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXuatPDF2.Name = "buttonXuatPDF2";
            this.buttonXuatPDF2.Size = new System.Drawing.Size(133, 37);
            this.buttonXuatPDF2.TabIndex = 37;
            this.buttonXuatPDF2.Text = "Xuất PDF";
            this.buttonXuatPDF2.UseVisualStyleBackColor = false;
            this.buttonXuatPDF2.Click += new System.EventHandler(this.buttonXuatPDF2_Click);
            // 
            // buttonExportExcel2
            // 
            this.buttonExportExcel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))));
            this.buttonExportExcel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportExcel2.ForeColor = System.Drawing.Color.White;
            this.buttonExportExcel2.Location = new System.Drawing.Point(823, 17);
            this.buttonExportExcel2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExportExcel2.Name = "buttonExportExcel2";
            this.buttonExportExcel2.Size = new System.Drawing.Size(133, 37);
            this.buttonExportExcel2.TabIndex = 36;
            this.buttonExportExcel2.Text = "Xuất Excel";
            this.buttonExportExcel2.UseVisualStyleBackColor = false;
            this.buttonExportExcel2.Click += new System.EventHandler(this.buttonExportExcel2_Click);
            // 
            // dstk
            // 
            this.dstk.AllowUserToAddRows = false;
            this.dstk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dstk.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dstk.BackgroundColor = System.Drawing.Color.White;
            this.dstk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dstk.DefaultCellStyle = dataGridViewCellStyle2;
            this.dstk.Location = new System.Drawing.Point(19, 71);
            this.dstk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dstk.Name = "dstk";
            this.dstk.ReadOnly = true;
            this.dstk.RowHeadersWidth = 51;
            this.dstk.RowTemplate.Height = 24;
            this.dstk.Size = new System.Drawing.Size(1095, 506);
            this.dstk.TabIndex = 0;
            // 
            // NhanVien
            // 
            this.NhanVien.Controls.Add(this.buttonXuatPDF3);
            this.NhanVien.Controls.Add(this.buttonExportExcel3);
            this.NhanVien.Controls.Add(this.dsnv);
            this.NhanVien.Location = new System.Drawing.Point(4, 34);
            this.NhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NhanVien.Size = new System.Drawing.Size(1131, 608);
            this.NhanVien.TabIndex = 0;
            this.NhanVien.Text = "Nhân viên";
            this.NhanVien.UseVisualStyleBackColor = true;
            // 
            // buttonXuatPDF3
            // 
            this.buttonXuatPDF3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.buttonXuatPDF3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXuatPDF3.ForeColor = System.Drawing.Color.White;
            this.buttonXuatPDF3.Location = new System.Drawing.Point(979, 17);
            this.buttonXuatPDF3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXuatPDF3.Name = "buttonXuatPDF3";
            this.buttonXuatPDF3.Size = new System.Drawing.Size(133, 37);
            this.buttonXuatPDF3.TabIndex = 37;
            this.buttonXuatPDF3.Text = "Xuất PDF";
            this.buttonXuatPDF3.UseVisualStyleBackColor = false;
            this.buttonXuatPDF3.Click += new System.EventHandler(this.buttonXuatPDF3_Click);
            // 
            // buttonExportExcel3
            // 
            this.buttonExportExcel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))));
            this.buttonExportExcel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportExcel3.ForeColor = System.Drawing.Color.White;
            this.buttonExportExcel3.Location = new System.Drawing.Point(825, 17);
            this.buttonExportExcel3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExportExcel3.Name = "buttonExportExcel3";
            this.buttonExportExcel3.Size = new System.Drawing.Size(133, 37);
            this.buttonExportExcel3.TabIndex = 36;
            this.buttonExportExcel3.Text = "Xuất Excel";
            this.buttonExportExcel3.UseVisualStyleBackColor = false;
            this.buttonExportExcel3.Click += new System.EventHandler(this.buttonExportExcel3_Click);
            // 
            // dsnv
            // 
            this.dsnv.AllowDrop = true;
            this.dsnv.AllowUserToAddRows = false;
            this.dsnv.AllowUserToOrderColumns = true;
            this.dsnv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dsnv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dsnv.BackgroundColor = System.Drawing.Color.White;
            this.dsnv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dsnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dsnv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dsnv.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dsnv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dsnv.Location = new System.Drawing.Point(19, 71);
            this.dsnv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dsnv.Name = "dsnv";
            this.dsnv.ReadOnly = true;
            this.dsnv.RowHeadersWidth = 51;
            this.dsnv.RowTemplate.Height = 24;
            this.dsnv.Size = new System.Drawing.Size(1095, 506);
            this.dsnv.TabIndex = 0;
            this.dsnv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsnv_CellContentClick);
            // 
            // PhongBan
            // 
            this.PhongBan.BackColor = System.Drawing.Color.White;
            this.PhongBan.Controls.Add(this.buttonXuatPDF4);
            this.PhongBan.Controls.Add(this.buttonExportExcel4);
            this.PhongBan.Controls.Add(this.groupBox1);
            this.PhongBan.Controls.Add(this.dspb);
            this.PhongBan.Location = new System.Drawing.Point(4, 34);
            this.PhongBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhongBan.Name = "PhongBan";
            this.PhongBan.Size = new System.Drawing.Size(1131, 608);
            this.PhongBan.TabIndex = 2;
            this.PhongBan.Text = "Phòng ban";
            // 
            // buttonXuatPDF4
            // 
            this.buttonXuatPDF4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.buttonXuatPDF4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXuatPDF4.ForeColor = System.Drawing.Color.White;
            this.buttonXuatPDF4.Location = new System.Drawing.Point(977, 16);
            this.buttonXuatPDF4.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXuatPDF4.Name = "buttonXuatPDF4";
            this.buttonXuatPDF4.Size = new System.Drawing.Size(133, 37);
            this.buttonXuatPDF4.TabIndex = 37;
            this.buttonXuatPDF4.Text = "Xuất PDF";
            this.buttonXuatPDF4.UseVisualStyleBackColor = false;
            this.buttonXuatPDF4.Click += new System.EventHandler(this.buttonXuatPDF4_Click);
            // 
            // buttonExportExcel4
            // 
            this.buttonExportExcel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))));
            this.buttonExportExcel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportExcel4.ForeColor = System.Drawing.Color.White;
            this.buttonExportExcel4.Location = new System.Drawing.Point(819, 16);
            this.buttonExportExcel4.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExportExcel4.Name = "buttonExportExcel4";
            this.buttonExportExcel4.Size = new System.Drawing.Size(133, 37);
            this.buttonExportExcel4.TabIndex = 36;
            this.buttonExportExcel4.Text = "Xuất Excel";
            this.buttonExportExcel4.UseVisualStyleBackColor = false;
            this.buttonExportExcel4.Click += new System.EventHandler(this.buttonExportExcel4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(-5, -33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1187, 27);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dspb
            // 
            this.dspb.AllowUserToAddRows = false;
            this.dspb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dspb.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dspb.BackgroundColor = System.Drawing.Color.White;
            this.dspb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dspb.DefaultCellStyle = dataGridViewCellStyle4;
            this.dspb.Location = new System.Drawing.Point(19, 71);
            this.dspb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dspb.Name = "dspb";
            this.dspb.ReadOnly = true;
            this.dspb.RowHeadersWidth = 51;
            this.dspb.RowTemplate.Height = 24;
            this.dspb.Size = new System.Drawing.Size(1095, 506);
            this.dspb.TabIndex = 1;
            // 
            // DsUyQuyenCV
            // 
            this.DsUyQuyenCV.Controls.Add(this.buttonXuatPDF5);
            this.DsUyQuyenCV.Controls.Add(this.buttonExportExcel5);
            this.DsUyQuyenCV.Controls.Add(this.dsuqcv);
            this.DsUyQuyenCV.Location = new System.Drawing.Point(4, 34);
            this.DsUyQuyenCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DsUyQuyenCV.Name = "DsUyQuyenCV";
            this.DsUyQuyenCV.Size = new System.Drawing.Size(1131, 608);
            this.DsUyQuyenCV.TabIndex = 6;
            this.DsUyQuyenCV.Text = " Ủy quyền công việc";
            this.DsUyQuyenCV.UseVisualStyleBackColor = true;
            // 
            // buttonXuatPDF5
            // 
            this.buttonXuatPDF5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.buttonXuatPDF5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXuatPDF5.ForeColor = System.Drawing.Color.White;
            this.buttonXuatPDF5.Location = new System.Drawing.Point(980, 17);
            this.buttonXuatPDF5.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXuatPDF5.Name = "buttonXuatPDF5";
            this.buttonXuatPDF5.Size = new System.Drawing.Size(133, 37);
            this.buttonXuatPDF5.TabIndex = 37;
            this.buttonXuatPDF5.Text = "Xuất PDF";
            this.buttonXuatPDF5.UseVisualStyleBackColor = false;
            this.buttonXuatPDF5.Click += new System.EventHandler(this.buttonXuatPDF5_Click);
            // 
            // buttonExportExcel5
            // 
            this.buttonExportExcel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))));
            this.buttonExportExcel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportExcel5.ForeColor = System.Drawing.Color.White;
            this.buttonExportExcel5.Location = new System.Drawing.Point(831, 17);
            this.buttonExportExcel5.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExportExcel5.Name = "buttonExportExcel5";
            this.buttonExportExcel5.Size = new System.Drawing.Size(133, 37);
            this.buttonExportExcel5.TabIndex = 36;
            this.buttonExportExcel5.Text = "Xuất Excel";
            this.buttonExportExcel5.UseVisualStyleBackColor = false;
            this.buttonExportExcel5.Click += new System.EventHandler(this.buttonExportExcel5_Click);
            // 
            // dsuqcv
            // 
            this.dsuqcv.AllowUserToAddRows = false;
            this.dsuqcv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsuqcv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dsuqcv.BackgroundColor = System.Drawing.Color.White;
            this.dsuqcv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dsuqcv.DefaultCellStyle = dataGridViewCellStyle5;
            this.dsuqcv.Location = new System.Drawing.Point(19, 71);
            this.dsuqcv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dsuqcv.Name = "dsuqcv";
            this.dsuqcv.ReadOnly = true;
            this.dsuqcv.RowHeadersWidth = 51;
            this.dsuqcv.RowTemplate.Height = 24;
            this.dsuqcv.Size = new System.Drawing.Size(1095, 506);
            this.dsuqcv.TabIndex = 2;
            this.dsuqcv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsuqcv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(166)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(77, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 39);
            this.label1.TabIndex = 21;
            this.label1.Text = "TasMana";
            // 
            // timkiem
            // 
            this.timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(166)))));
            this.timkiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(166)))));
            this.timkiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(166)))));
            this.timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(166)))));
            this.timkiem.Image = ((System.Drawing.Image)(resources.GetObject("timkiem.Image")));
            this.timkiem.Location = new System.Drawing.Point(283, 118);
            this.timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(39, 34);
            this.timkiem.TabIndex = 6;
            this.timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.timkiem.UseVisualStyleBackColor = false;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // txbtimkiem
            // 
            this.txbtimkiem.BackColor = System.Drawing.Color.White;
            this.txbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbtimkiem.Location = new System.Drawing.Point(52, 122);
            this.txbtimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbtimkiem.Name = "txbtimkiem";
            this.txbtimkiem.Size = new System.Drawing.Size(219, 27);
            this.txbtimkiem.TabIndex = 2;
            this.txbtimkiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.Control;
            this.btnCapNhat.Enabled = false;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCapNhat.Location = new System.Drawing.Point(84, 233);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(175, 38);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click_1);
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.SystemColors.Control;
            this.btnluu.Enabled = false;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.ForeColor = System.Drawing.Color.Firebrick;
            this.btnluu.Location = new System.Drawing.Point(84, 508);
            this.btnluu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(175, 41);
            this.btnluu.TabIndex = 4;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.Control;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.Firebrick;
            this.btnsua.Location = new System.Drawing.Point(84, 300);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(175, 41);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.Firebrick;
            this.btnxoa.Location = new System.Drawing.Point(84, 370);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(175, 43);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.Control;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.Firebrick;
            this.btnthem.Location = new System.Drawing.Point(84, 441);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(175, 38);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(1387, 4);
            this.minimize.Margin = new System.Windows.Forms.Padding(4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(33, 31);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 27;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(1433, 4);
            this.logout.Margin = new System.Windows.Forms.Padding(4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(33, 31);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logout.TabIndex = 26;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.timkiem);
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.txbtimkiem);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.btnluu);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 646);
            this.panel1.TabIndex = 28;
            // 
            // FormDuLieuNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1471, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.tabDulieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDuLieuNhanVien";
            this.Text = "Dữ liệu nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDuLieu_FormClosing);
            this.Load += new System.EventHandler(this.FormDuLieu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDuLieuNhanVien_MouseDown);
            this.tabDulieu.ResumeLayout(false);
            this.Quyen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dslshd)).EndInit();
            this.TaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dstk)).EndInit();
            this.NhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsnv)).EndInit();
            this.PhongBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dspb)).EndInit();
            this.DsUyQuyenCV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsuqcv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dsnv;
        private System.Windows.Forms.DataGridView dstk;
        private System.Windows.Forms.DataGridView dslshd;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.TextBox txbtimkiem;
        public System.Windows.Forms.TabPage NhanVien;
        public System.Windows.Forms.TabPage PhongBan;
        public System.Windows.Forms.TabPage TaiKhoan;
        public System.Windows.Forms.TabPage Quyen;


        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dspb;
        public System.Windows.Forms.TabControl tabDulieu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage DsUyQuyenCV;
        private System.Windows.Forms.DataGridView dsuqcv;
        private System.Windows.Forms.Button buttonXuatPDF;
        private System.Windows.Forms.Button buttonExportExcel;
        private System.Windows.Forms.Button buttonXuatPDF2;
        private System.Windows.Forms.Button buttonExportExcel2;
        private System.Windows.Forms.Button buttonXuatPDF3;
        private System.Windows.Forms.Button buttonExportExcel3;
        private System.Windows.Forms.Button buttonXuatPDF4;
        private System.Windows.Forms.Button buttonExportExcel4;
        private System.Windows.Forms.Button buttonXuatPDF5;
        private System.Windows.Forms.Button buttonExportExcel5;
    }
}