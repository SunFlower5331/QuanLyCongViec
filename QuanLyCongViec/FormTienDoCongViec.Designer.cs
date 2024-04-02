namespace QuanLyCongViec
{
    partial class FormTienDoCongViec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTienDoCongViec));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dscv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnxemcvpb = new System.Windows.Forms.Button();
            this.btnchinhsuaphancong = new System.Windows.Forms.Button();
            this.cbotrangthai = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbotuychonchiase = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbomanv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbotennv = new System.Windows.Forms.TextBox();
            this.tbobophan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbotencv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbomacv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpthoihan = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnluu = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnthongtinkh = new System.Windows.Forms.Button();
            this.dsmanv = new System.Windows.Forms.DataGridView();
            this.thongtinkh = new System.Windows.Forms.DataGridView();
            this.dsnv = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dscv)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsmanv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtinkh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsnv)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dscv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.groupBox1.Location = new System.Drawing.Point(9, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(630, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách công việc";
            // 
            // dscv
            // 
            this.dscv.AllowUserToAddRows = false;
            this.dscv.AllowUserToDeleteRows = false;
            this.dscv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dscv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dscv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dscv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dscv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dscv.GridColor = System.Drawing.Color.Black;
            this.dscv.Location = new System.Drawing.Point(2, 17);
            this.dscv.Margin = new System.Windows.Forms.Padding(2);
            this.dscv.Name = "dscv";
            this.dscv.ReadOnly = true;
            this.dscv.RowHeadersWidth = 51;
            this.dscv.RowTemplate.Height = 24;
            this.dscv.Size = new System.Drawing.Size(624, 236);
            this.dscv.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnxemcvpb);
            this.groupBox2.Controls.Add(this.btnchinhsuaphancong);
            this.groupBox2.Controls.Add(this.cbotrangthai);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbotuychonchiase);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbomanv);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbotennv);
            this.groupBox2.Controls.Add(this.tbobophan);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbotencv);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbomacv);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpthoihan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnluu);
            this.groupBox2.Controls.Add(this.btncapnhat);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(9, 288);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(366, 347);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnxemcvpb
            // 
            this.btnxemcvpb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxemcvpb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnxemcvpb.ForeColor = System.Drawing.Color.Firebrick;
            this.btnxemcvpb.Location = new System.Drawing.Point(172, 308);
            this.btnxemcvpb.Margin = new System.Windows.Forms.Padding(2);
            this.btnxemcvpb.Name = "btnxemcvpb";
            this.btnxemcvpb.Size = new System.Drawing.Size(180, 29);
            this.btnxemcvpb.TabIndex = 52;
            this.btnxemcvpb.Text = "Xem công việc phòng ban";
            this.btnxemcvpb.UseVisualStyleBackColor = true;
            this.btnxemcvpb.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnchinhsuaphancong
            // 
            this.btnchinhsuaphancong.Enabled = false;
            this.btnchinhsuaphancong.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchinhsuaphancong.ForeColor = System.Drawing.Color.Firebrick;
            this.btnchinhsuaphancong.Location = new System.Drawing.Point(19, 271);
            this.btnchinhsuaphancong.Margin = new System.Windows.Forms.Padding(2);
            this.btnchinhsuaphancong.Name = "btnchinhsuaphancong";
            this.btnchinhsuaphancong.Size = new System.Drawing.Size(80, 25);
            this.btnchinhsuaphancong.TabIndex = 51;
            this.btnchinhsuaphancong.Text = "Chỉnh sửa";
            this.btnchinhsuaphancong.UseVisualStyleBackColor = true;
            // 
            // cbotrangthai
            // 
            this.cbotrangthai.AutoCompleteCustomSource.AddRange(new string[] {
            "Chưa hoàn thành",
            "Đã hoàn thành"});
            this.cbotrangthai.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbotrangthai.FormattingEnabled = true;
            this.cbotrangthai.Items.AddRange(new object[] {
            "Chưa hoàn thành",
            "Đã hoàn thành"});
            this.cbotrangthai.Location = new System.Drawing.Point(172, 236);
            this.cbotrangthai.Margin = new System.Windows.Forms.Padding(2);
            this.cbotrangthai.Name = "cbotrangthai";
            this.cbotrangthai.Size = new System.Drawing.Size(180, 21);
            this.cbotrangthai.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 237);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Trạng thái";
            // 
            // cbotuychonchiase
            // 
            this.cbotuychonchiase.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbotuychonchiase.FormattingEnabled = true;
            this.cbotuychonchiase.Items.AddRange(new object[] {
            "Công việc chung",
            "Bộ phận"});
            this.cbotuychonchiase.Location = new System.Drawing.Point(172, 205);
            this.cbotuychonchiase.Margin = new System.Windows.Forms.Padding(2);
            this.cbotuychonchiase.Name = "cbotuychonchiase";
            this.cbotuychonchiase.Size = new System.Drawing.Size(180, 21);
            this.cbotuychonchiase.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 205);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Tùy chọn chia sẻ";
            // 
            // tbomanv
            // 
            this.tbomanv.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbomanv.Location = new System.Drawing.Point(172, 106);
            this.tbomanv.Margin = new System.Windows.Forms.Padding(2);
            this.tbomanv.Name = "tbomanv";
            this.tbomanv.ReadOnly = true;
            this.tbomanv.Size = new System.Drawing.Size(180, 20);
            this.tbomanv.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Mã nhân viên\r\n";
            // 
            // tbotennv
            // 
            this.tbotennv.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbotennv.Location = new System.Drawing.Point(172, 137);
            this.tbotennv.Margin = new System.Windows.Forms.Padding(2);
            this.tbotennv.Name = "tbotennv";
            this.tbotennv.ReadOnly = true;
            this.tbotennv.Size = new System.Drawing.Size(180, 20);
            this.tbotennv.TabIndex = 44;
            // 
            // tbobophan
            // 
            this.tbobophan.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbobophan.Location = new System.Drawing.Point(172, 72);
            this.tbobophan.Margin = new System.Windows.Forms.Padding(2);
            this.tbobophan.Name = "tbobophan";
            this.tbobophan.ReadOnly = true;
            this.tbobophan.Size = new System.Drawing.Size(180, 20);
            this.tbobophan.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Tên Nhân viên";
            // 
            // tbotencv
            // 
            this.tbotencv.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbotencv.Location = new System.Drawing.Point(172, 39);
            this.tbotencv.Margin = new System.Windows.Forms.Padding(2);
            this.tbotencv.Name = "tbotencv";
            this.tbotencv.ReadOnly = true;
            this.tbotencv.Size = new System.Drawing.Size(180, 20);
            this.tbotencv.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Tên công việc";
            // 
            // tbomacv
            // 
            this.tbomacv.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbomacv.ForeColor = System.Drawing.Color.DimGray;
            this.tbomacv.Location = new System.Drawing.Point(172, 12);
            this.tbomacv.Margin = new System.Windows.Forms.Padding(2);
            this.tbomacv.Name = "tbomacv";
            this.tbomacv.ReadOnly = true;
            this.tbomacv.Size = new System.Drawing.Size(180, 20);
            this.tbomacv.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Mã công việc";
            // 
            // dtpthoihan
            // 
            this.dtpthoihan.CalendarMonthBackground = System.Drawing.Color.DarkGray;
            this.dtpthoihan.Location = new System.Drawing.Point(172, 172);
            this.dtpthoihan.Margin = new System.Windows.Forms.Padding(2);
            this.dtpthoihan.Name = "dtpthoihan";
            this.dtpthoihan.Size = new System.Drawing.Size(180, 20);
            this.dtpthoihan.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Bộ phận";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Thời hạn";
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnluu.ForeColor = System.Drawing.Color.Firebrick;
            this.btnluu.Location = new System.Drawing.Point(270, 271);
            this.btnluu.Margin = new System.Windows.Forms.Padding(2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(80, 25);
            this.btnluu.TabIndex = 33;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btncapnhat.ForeColor = System.Drawing.Color.Firebrick;
            this.btncapnhat.Location = new System.Drawing.Point(144, 271);
            this.btncapnhat.Margin = new System.Windows.Forms.Padding(2);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(80, 25);
            this.btncapnhat.TabIndex = 32;
            this.btncapnhat.Text = "Cập nhật ";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnthongtinkh
            // 
            this.btnthongtinkh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthongtinkh.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnthongtinkh.ForeColor = System.Drawing.Color.Firebrick;
            this.btnthongtinkh.Location = new System.Drawing.Point(414, 294);
            this.btnthongtinkh.Margin = new System.Windows.Forms.Padding(2);
            this.btnthongtinkh.Name = "btnthongtinkh";
            this.btnthongtinkh.Size = new System.Drawing.Size(116, 26);
            this.btnthongtinkh.TabIndex = 34;
            this.btnthongtinkh.Text = "Thông tin khách hàng";
            this.btnthongtinkh.UseVisualStyleBackColor = true;
            this.btnthongtinkh.Click += new System.EventHandler(this.btnthongtinkh_Click);
            // 
            // dsmanv
            // 
            this.dsmanv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsmanv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dsmanv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dsmanv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsmanv.Location = new System.Drawing.Point(414, 408);
            this.dsmanv.Margin = new System.Windows.Forms.Padding(2);
            this.dsmanv.Name = "dsmanv";
            this.dsmanv.RowHeadersWidth = 51;
            this.dsmanv.RowTemplate.Height = 24;
            this.dsmanv.Size = new System.Drawing.Size(573, 219);
            this.dsmanv.TabIndex = 2;
            this.dsmanv.Visible = false;
            // 
            // thongtinkh
            // 
            this.thongtinkh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.thongtinkh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.thongtinkh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.thongtinkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thongtinkh.Location = new System.Drawing.Point(414, 325);
            this.thongtinkh.Margin = new System.Windows.Forms.Padding(2);
            this.thongtinkh.Name = "thongtinkh";
            this.thongtinkh.RowHeadersWidth = 51;
            this.thongtinkh.RowTemplate.Height = 24;
            this.thongtinkh.Size = new System.Drawing.Size(573, 79);
            this.thongtinkh.TabIndex = 3;
            this.thongtinkh.Visible = false;
            // 
            // dsnv
            // 
            this.dsnv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsnv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dsnv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dsnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsnv.Location = new System.Drawing.Point(4, 17);
            this.dsnv.Margin = new System.Windows.Forms.Padding(2);
            this.dsnv.Name = "dsnv";
            this.dsnv.ReadOnly = true;
            this.dsnv.RowHeadersWidth = 51;
            this.dsnv.RowTemplate.Height = 24;
            this.dsnv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsnv.Size = new System.Drawing.Size(339, 236);
            this.dsnv.TabIndex = 35;
            this.dsnv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsnv_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dsnv);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.groupBox3.Location = new System.Drawing.Point(644, 27);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(348, 257);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách nhân viên";
            this.groupBox3.Visible = false;
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(936, 2);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 38;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(971, 2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(25, 25);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logout.TabIndex = 37;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // FormTienDoCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1000, 638);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.thongtinkh);
            this.Controls.Add(this.dsmanv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnthongtinkh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTienDoCongViec";
            this.Text = "Tiến độ công việc cá nhân";
            this.Load += new System.EventHandler(this.FormTienDoCongViec_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormTienDoCongViec_MouseDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dscv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsmanv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtinkh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsnv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dsmanv;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnthongtinkh;
        private System.Windows.Forms.DataGridView thongtinkh;
        private System.Windows.Forms.Button btnchinhsuaphancong;
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
        private System.Windows.Forms.DataGridView dsnv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnxemcvpb;
        private System.Windows.Forms.DataGridView dscv;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox logout;
    }
}