﻿namespace QuanLyCongViec
{
    partial class FormCongViec
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCongViec));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbotuychonhienthi = new System.Windows.Forms.ComboBox();
            this.dsnv = new System.Windows.Forms.DataGridView();
            this.btnluu = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonXuatPDF = new System.Windows.Forms.Button();
            this.buttonExportExcel = new System.Windows.Forms.Button();
            this.dsdpc = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dscv = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xoacv = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbotrangthai = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbotuychonchiase = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpthoihan = new System.Windows.Forms.DateTimePicker();
            this.tbomanv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbotennv = new System.Windows.Forms.TextBox();
            this.tbobophan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbotencv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbomacv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnphancong = new System.Windows.Forms.Button();
            this.btnchinhsuaphancong = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsnv)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsdpc)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dscv)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.cbotuychonhienthi);
            this.groupBox2.Controls.Add(this.dsnv);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(304, 384);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // cbotuychonhienthi
            // 
            this.cbotuychonhienthi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbotuychonhienthi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotuychonhienthi.FormattingEnabled = true;
            this.cbotuychonhienthi.Items.AddRange(new object[] {
            "Tất cả nhân viên"});
            this.cbotuychonhienthi.Location = new System.Drawing.Point(160, 25);
            this.cbotuychonhienthi.Margin = new System.Windows.Forms.Padding(2);
            this.cbotuychonhienthi.Name = "cbotuychonhienthi";
            this.cbotuychonhienthi.Size = new System.Drawing.Size(135, 21);
            this.cbotuychonhienthi.TabIndex = 49;
            this.cbotuychonhienthi.SelectedIndexChanged += new System.EventHandler(this.cbotuychonhienthi_SelectedIndexChanged);
            // 
            // dsnv
            // 
            this.dsnv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dsnv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dsnv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dsnv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dsnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dsnv.DefaultCellStyle = dataGridViewCellStyle4;
            this.dsnv.Location = new System.Drawing.Point(7, 58);
            this.dsnv.Margin = new System.Windows.Forms.Padding(2);
            this.dsnv.Name = "dsnv";
            this.dsnv.ReadOnly = true;
            this.dsnv.RowHeadersWidth = 51;
            this.dsnv.RowTemplate.Height = 24;
            this.dsnv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsnv.Size = new System.Drawing.Size(288, 306);
            this.dsnv.TabIndex = 19;
            this.dsnv.Click += new System.EventHandler(this.dsnv_Click);
            // 
            // btnluu
            // 
            this.btnluu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnluu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))));
            this.btnluu.Enabled = false;
            this.btnluu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnluu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.ForeColor = System.Drawing.Color.White;
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.Location = new System.Drawing.Point(391, 22);
            this.btnluu.Margin = new System.Windows.Forms.Padding(2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(35, 35);
            this.btnluu.TabIndex = 20;
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncapnhat.BackColor = System.Drawing.Color.Goldenrod;
            this.btncapnhat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btncapnhat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btncapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapnhat.ForeColor = System.Drawing.Color.White;
            this.btncapnhat.Image = ((System.Drawing.Image)(resources.GetObject("btncapnhat.Image")));
            this.btncapnhat.Location = new System.Drawing.Point(344, 22);
            this.btncapnhat.Margin = new System.Windows.Forms.Padding(2);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(35, 35);
            this.btncapnhat.TabIndex = 18;
            this.btncapnhat.UseVisualStyleBackColor = false;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnxoa.BackColor = System.Drawing.Color.Firebrick;
            this.btnxoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnxoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.White;
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(434, 22);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(35, 35);
            this.btnxoa.TabIndex = 17;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(166)))));
            this.btnthem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnthem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.White;
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.Location = new System.Drawing.Point(300, 22);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(35, 35);
            this.btnthem.TabIndex = 16;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.buttonXuatPDF);
            this.groupBox3.Controls.Add(this.buttonExportExcel);
            this.groupBox3.Controls.Add(this.dsdpc);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(310, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(716, 384);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách công việc đã phân công";
            // 
            // buttonXuatPDF
            // 
            this.buttonXuatPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXuatPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.buttonXuatPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXuatPDF.ForeColor = System.Drawing.Color.White;
            this.buttonXuatPDF.Location = new System.Drawing.Point(613, 19);
            this.buttonXuatPDF.Margin = new System.Windows.Forms.Padding(2);
            this.buttonXuatPDF.Name = "buttonXuatPDF";
            this.buttonXuatPDF.Size = new System.Drawing.Size(80, 30);
            this.buttonXuatPDF.TabIndex = 35;
            this.buttonXuatPDF.Text = "Xuất PDF";
            this.buttonXuatPDF.UseVisualStyleBackColor = false;
            this.buttonXuatPDF.Click += new System.EventHandler(this.buttonXuatPDF_Click);
            // 
            // buttonExportExcel
            // 
            this.buttonExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))));
            this.buttonExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportExcel.ForeColor = System.Drawing.Color.White;
            this.buttonExportExcel.Location = new System.Drawing.Point(517, 19);
            this.buttonExportExcel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExportExcel.Name = "buttonExportExcel";
            this.buttonExportExcel.Size = new System.Drawing.Size(80, 30);
            this.buttonExportExcel.TabIndex = 34;
            this.buttonExportExcel.Text = "Xuất Excel";
            this.buttonExportExcel.UseVisualStyleBackColor = false;
            this.buttonExportExcel.Click += new System.EventHandler(this.buttonExportExcel_Click);
            // 
            // dsdpc
            // 
            this.dsdpc.AllowUserToAddRows = false;
            this.dsdpc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dsdpc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dsdpc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dsdpc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dsdpc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dsdpc.DefaultCellStyle = dataGridViewCellStyle5;
            this.dsdpc.Location = new System.Drawing.Point(7, 58);
            this.dsdpc.Margin = new System.Windows.Forms.Padding(2);
            this.dsdpc.Name = "dsdpc";
            this.dsdpc.ReadOnly = true;
            this.dsdpc.RowHeadersWidth = 51;
            this.dsdpc.RowTemplate.Height = 24;
            this.dsdpc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsdpc.Size = new System.Drawing.Size(706, 306);
            this.dsdpc.TabIndex = 2;
            this.dsdpc.Click += new System.EventHandler(this.dsdpc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.dscv);
            this.groupBox1.Controls.Add(this.btncapnhat);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.btnluu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(474, 250);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách công việc";
            // 
            // dscv
            // 
            this.dscv.AllowUserToAddRows = false;
            this.dscv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dscv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dscv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dscv.BackgroundColor = System.Drawing.Color.White;
            this.dscv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dscv.DefaultCellStyle = dataGridViewCellStyle6;
            this.dscv.GridColor = System.Drawing.Color.Black;
            this.dscv.Location = new System.Drawing.Point(3, 62);
            this.dscv.Margin = new System.Windows.Forms.Padding(2);
            this.dscv.Name = "dscv";
            this.dscv.RowHeadersWidth = 51;
            this.dscv.RowTemplate.Height = 24;
            this.dscv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dscv.Size = new System.Drawing.Size(468, 157);
            this.dscv.TabIndex = 2;
            this.dscv.Click += new System.EventHandler(this.dscv_Click);
            this.dscv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dscv_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 254);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 388);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 550F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1028, 254);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.xoacv);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.btnphancong);
            this.panel1.Controls.Add(this.btnchinhsuaphancong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(480, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 250);
            this.panel1.TabIndex = 0;
            // 
            // xoacv
            // 
            this.xoacv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xoacv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoacv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.xoacv.Location = new System.Drawing.Point(287, 187);
            this.xoacv.Margin = new System.Windows.Forms.Padding(2);
            this.xoacv.Name = "xoacv";
            this.xoacv.Size = new System.Drawing.Size(116, 32);
            this.xoacv.TabIndex = 52;
            this.xoacv.Text = "Xóa công việc";
            this.xoacv.UseVisualStyleBackColor = true;
            this.xoacv.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbotrangthai);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cbotuychonchiase);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.dtpthoihan);
            this.groupBox4.Controls.Add(this.tbomanv);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.tbotennv);
            this.groupBox4.Controls.Add(this.tbobophan);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.tbotencv);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.tbomacv);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.groupBox4.Location = new System.Drawing.Point(8, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(529, 176);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết công việc";
            // 
            // cbotrangthai
            // 
            this.cbotrangthai.AutoCompleteCustomSource.AddRange(new string[] {
            "Chưa hoàn thành",
            "Đã hoàn thành"});
            this.cbotrangthai.FormattingEnabled = true;
            this.cbotrangthai.Items.AddRange(new object[] {
            "Chưa hoàn thành",
            "Đã hoàn thành"});
            this.cbotrangthai.Location = new System.Drawing.Point(379, 76);
            this.cbotrangthai.Margin = new System.Windows.Forms.Padding(2);
            this.cbotrangthai.Name = "cbotrangthai";
            this.cbotrangthai.Size = new System.Drawing.Size(136, 21);
            this.cbotrangthai.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(281, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Trạng thái:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbotuychonchiase
            // 
            this.cbotuychonchiase.FormattingEnabled = true;
            this.cbotuychonchiase.Items.AddRange(new object[] {
            "Công việc chung",
            "Bộ phận"});
            this.cbotuychonchiase.Location = new System.Drawing.Point(379, 50);
            this.cbotuychonchiase.Margin = new System.Windows.Forms.Padding(2);
            this.cbotuychonchiase.Name = "cbotuychonchiase";
            this.cbotuychonchiase.Size = new System.Drawing.Size(136, 21);
            this.cbotuychonchiase.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(259, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Tùy chọn chia sẻ:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpthoihan
            // 
            this.dtpthoihan.Location = new System.Drawing.Point(379, 26);
            this.dtpthoihan.Margin = new System.Windows.Forms.Padding(2);
            this.dtpthoihan.Name = "dtpthoihan";
            this.dtpthoihan.Size = new System.Drawing.Size(136, 20);
            this.dtpthoihan.TabIndex = 32;
            // 
            // tbomanv
            // 
            this.tbomanv.Enabled = false;
            this.tbomanv.Location = new System.Drawing.Point(103, 94);
            this.tbomanv.Margin = new System.Windows.Forms.Padding(2);
            this.tbomanv.Name = "tbomanv";
            this.tbomanv.ReadOnly = true;
            this.tbomanv.Size = new System.Drawing.Size(136, 20);
            this.tbomanv.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(4, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Mã nhân viên:\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbotennv
            // 
            this.tbotennv.Enabled = false;
            this.tbotennv.Location = new System.Drawing.Point(102, 119);
            this.tbotennv.Margin = new System.Windows.Forms.Padding(2);
            this.tbotennv.Name = "tbotennv";
            this.tbotennv.ReadOnly = true;
            this.tbotennv.Size = new System.Drawing.Size(136, 20);
            this.tbotennv.TabIndex = 39;
            // 
            // tbobophan
            // 
            this.tbobophan.Enabled = false;
            this.tbobophan.Location = new System.Drawing.Point(103, 70);
            this.tbobophan.Margin = new System.Windows.Forms.Padding(2);
            this.tbobophan.Name = "tbobophan";
            this.tbobophan.ReadOnly = true;
            this.tbobophan.Size = new System.Drawing.Size(136, 20);
            this.tbobophan.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(4, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Tên Nhân viên:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbotencv
            // 
            this.tbotencv.Enabled = false;
            this.tbotencv.Location = new System.Drawing.Point(103, 44);
            this.tbotencv.Margin = new System.Windows.Forms.Padding(2);
            this.tbotencv.Name = "tbotencv";
            this.tbotencv.ReadOnly = true;
            this.tbotencv.Size = new System.Drawing.Size(136, 20);
            this.tbotencv.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(4, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Tên công việc:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbomacv
            // 
            this.tbomacv.Enabled = false;
            this.tbomacv.Location = new System.Drawing.Point(102, 21);
            this.tbomacv.Margin = new System.Windows.Forms.Padding(2);
            this.tbomacv.Name = "tbomacv";
            this.tbomacv.ReadOnly = true;
            this.tbomacv.Size = new System.Drawing.Size(137, 20);
            this.tbomacv.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(4, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Mã công việc:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(4, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Bộ phận:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(281, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Thời hạn:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnphancong
            // 
            this.btnphancong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnphancong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnphancong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.btnphancong.Location = new System.Drawing.Point(429, 187);
            this.btnphancong.Margin = new System.Windows.Forms.Padding(2);
            this.btnphancong.Name = "btnphancong";
            this.btnphancong.Size = new System.Drawing.Size(94, 32);
            this.btnphancong.TabIndex = 44;
            this.btnphancong.Text = "Phân công";
            this.btnphancong.UseVisualStyleBackColor = true;
            this.btnphancong.Click += new System.EventHandler(this.btnphancong_Click_1);
            // 
            // btnchinhsuaphancong
            // 
            this.btnchinhsuaphancong.Enabled = false;
            this.btnchinhsuaphancong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchinhsuaphancong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchinhsuaphancong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.btnchinhsuaphancong.Location = new System.Drawing.Point(65, 187);
            this.btnchinhsuaphancong.Margin = new System.Windows.Forms.Padding(2);
            this.btnchinhsuaphancong.Name = "btnchinhsuaphancong";
            this.btnchinhsuaphancong.Size = new System.Drawing.Size(189, 32);
            this.btnchinhsuaphancong.TabIndex = 46;
            this.btnchinhsuaphancong.Text = "Chỉnh sửa phân công";
            this.btnchinhsuaphancong.UseVisualStyleBackColor = true;
            this.btnchinhsuaphancong.Click += new System.EventHandler(this.btnchinhsuaphancong_Click_1);
            // 
            // FormCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 642);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(723, 591);
            this.Name = "FormCongViec";
            this.Text = "PHÂN CÔNG CÔNG VIỆC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCongViec_FormClosing);
            this.Load += new System.EventHandler(this.FormCongViec_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsnv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsdpc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dscv)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dsdpc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dscv;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dsnv;
        private System.Windows.Forms.Button buttonXuatPDF;
        private System.Windows.Forms.Button buttonExportExcel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnphancong;
        private System.Windows.Forms.Button btnchinhsuaphancong;
        private System.Windows.Forms.ComboBox cbotuychonhienthi;
        private System.Windows.Forms.ComboBox cbotrangthai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbotuychonchiase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbomanv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbotennv;
        private System.Windows.Forms.TextBox tbobophan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbotencv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbomacv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpthoihan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button xoacv;
    }
}