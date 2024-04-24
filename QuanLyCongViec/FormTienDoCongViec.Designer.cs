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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTienDoCongViec));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dscv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnxemcvpb = new System.Windows.Forms.Button();
            this.cbotrangthai = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbotuychonchiase = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbomanv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbotennv = new System.Windows.Forms.TextBox();
            this.tbochucvu = new System.Windows.Forms.TextBox();
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
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(840, 316);
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
            this.dscv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dscv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dscv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dscv.GridColor = System.Drawing.Color.Black;
            this.dscv.Location = new System.Drawing.Point(3, 21);
            this.dscv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dscv.Name = "dscv";
            this.dscv.ReadOnly = true;
            this.dscv.RowHeadersWidth = 51;
            this.dscv.RowTemplate.Height = 24;
            this.dscv.Size = new System.Drawing.Size(832, 290);
            this.dscv.TabIndex = 0;
            this.dscv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dscv_CellContentClick);
            this.dscv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dscv_CellFormatting);
            this.dscv.Click += new System.EventHandler(this.dscv_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnxemcvpb);
            this.groupBox2.Controls.Add(this.cbotrangthai);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbotuychonchiase);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbomanv);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbotennv);
            this.groupBox2.Controls.Add(this.tbochucvu);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 354);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(505, 427);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnxemcvpb
            // 
            this.btnxemcvpb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.btnxemcvpb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxemcvpb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnxemcvpb.ForeColor = System.Drawing.Color.White;
            this.btnxemcvpb.Location = new System.Drawing.Point(3, 334);
            this.btnxemcvpb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxemcvpb.Name = "btnxemcvpb";
            this.btnxemcvpb.Size = new System.Drawing.Size(256, 36);
            this.btnxemcvpb.TabIndex = 52;
            this.btnxemcvpb.Text = "Xem công việc phòng ban";
            this.btnxemcvpb.UseVisualStyleBackColor = false;
            this.btnxemcvpb.Click += new System.EventHandler(this.btnxemcvpb_Click);
            // 
            // cbotrangthai
            // 
            this.cbotrangthai.AutoCompleteCustomSource.AddRange(new string[] {
            "Chưa hoàn thành",
            "Đã hoàn thành"});
            this.cbotrangthai.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbotrangthai.Enabled = false;
            this.cbotrangthai.FormattingEnabled = true;
            this.cbotrangthai.Items.AddRange(new object[] {
            "Chưa hoàn thành",
            "Đã hoàn thành"});
            this.cbotrangthai.Location = new System.Drawing.Point(229, 290);
            this.cbotrangthai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbotrangthai.Name = "cbotrangthai";
            this.cbotrangthai.Size = new System.Drawing.Size(255, 24);
            this.cbotrangthai.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(21, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 50;
            this.label8.Text = "Trạng thái:";
            // 
            // cbotuychonchiase
            // 
            this.cbotuychonchiase.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbotuychonchiase.Enabled = false;
            this.cbotuychonchiase.FormattingEnabled = true;
            this.cbotuychonchiase.Items.AddRange(new object[] {
            "Công việc chung",
            "Bộ phận"});
            this.cbotuychonchiase.Location = new System.Drawing.Point(229, 252);
            this.cbotuychonchiase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbotuychonchiase.Name = "cbotuychonchiase";
            this.cbotuychonchiase.Size = new System.Drawing.Size(255, 24);
            this.cbotuychonchiase.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(21, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Tùy chọn chia sẻ:";
            // 
            // tbomanv
            // 
            this.tbomanv.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbomanv.Location = new System.Drawing.Point(229, 130);
            this.tbomanv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbomanv.Name = "tbomanv";
            this.tbomanv.ReadOnly = true;
            this.tbomanv.Size = new System.Drawing.Size(255, 22);
            this.tbomanv.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(19, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Mã nhân viên:\r\n";
            // 
            // tbotennv
            // 
            this.tbotennv.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbotennv.Location = new System.Drawing.Point(229, 169);
            this.tbotennv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbotennv.Name = "tbotennv";
            this.tbotennv.ReadOnly = true;
            this.tbotennv.Size = new System.Drawing.Size(255, 22);
            this.tbotennv.TabIndex = 44;
            // 
            // tbochucvu
            // 
            this.tbochucvu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbochucvu.Location = new System.Drawing.Point(229, 89);
            this.tbochucvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbochucvu.Name = "tbochucvu";
            this.tbochucvu.ReadOnly = true;
            this.tbochucvu.Size = new System.Drawing.Size(255, 22);
            this.tbochucvu.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(21, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Tên Nhân viên:";
            // 
            // tbotencv
            // 
            this.tbotencv.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbotencv.Location = new System.Drawing.Point(229, 48);
            this.tbotencv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbotencv.Name = "tbotencv";
            this.tbotencv.ReadOnly = true;
            this.tbotencv.Size = new System.Drawing.Size(255, 22);
            this.tbotencv.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(19, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Tên công việc:";
            // 
            // tbomacv
            // 
            this.tbomacv.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbomacv.ForeColor = System.Drawing.Color.DimGray;
            this.tbomacv.Location = new System.Drawing.Point(229, 15);
            this.tbomacv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbomacv.Name = "tbomacv";
            this.tbomacv.ReadOnly = true;
            this.tbomacv.Size = new System.Drawing.Size(255, 22);
            this.tbomacv.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(21, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Mã công việc:";
            // 
            // dtpthoihan
            // 
            this.dtpthoihan.CalendarMonthBackground = System.Drawing.Color.DarkGray;
            this.dtpthoihan.Location = new System.Drawing.Point(229, 212);
            this.dtpthoihan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpthoihan.Name = "dtpthoihan";
            this.dtpthoihan.Size = new System.Drawing.Size(255, 22);
            this.dtpthoihan.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(19, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(21, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Thời hạn:";
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(191)))), ((int)(((byte)(2)))));
            this.btnluu.Enabled = false;
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnluu.ForeColor = System.Drawing.Color.Black;
            this.btnluu.Location = new System.Drawing.Point(397, 334);
            this.btnluu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(107, 36);
            this.btnluu.TabIndex = 33;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(191)))), ((int)(((byte)(2)))));
            this.btncapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btncapnhat.ForeColor = System.Drawing.Color.Black;
            this.btncapnhat.Location = new System.Drawing.Point(275, 334);
            this.btncapnhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(107, 36);
            this.btncapnhat.TabIndex = 32;
            this.btncapnhat.Text = "Cập nhật ";
            this.btncapnhat.UseVisualStyleBackColor = false;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnthongtinkh
            // 
            this.btnthongtinkh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(2)))), ((int)(((byte)(0)))));
            this.btnthongtinkh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthongtinkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnthongtinkh.ForeColor = System.Drawing.Color.White;
            this.btnthongtinkh.Location = new System.Drawing.Point(552, 354);
            this.btnthongtinkh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthongtinkh.Name = "btnthongtinkh";
            this.btnthongtinkh.Size = new System.Drawing.Size(276, 42);
            this.btnthongtinkh.TabIndex = 34;
            this.btnthongtinkh.Text = "Thông tin khách hàng";
            this.btnthongtinkh.UseVisualStyleBackColor = false;
            this.btnthongtinkh.Click += new System.EventHandler(this.btnthongtinkh_Click);
            // 
            // dsmanv
            // 
            this.dsmanv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsmanv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dsmanv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dsmanv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dsmanv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dsmanv.Location = new System.Drawing.Point(523, 523);
            this.dsmanv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dsmanv.Name = "dsmanv";
            this.dsmanv.RowHeadersWidth = 51;
            this.dsmanv.RowTemplate.Height = 24;
            this.dsmanv.Size = new System.Drawing.Size(957, 249);
            this.dsmanv.TabIndex = 2;
            this.dsmanv.Visible = false;
            this.dsmanv.Click += new System.EventHandler(this.dsmanv_Click);
            // 
            // thongtinkh
            // 
            this.thongtinkh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.thongtinkh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.thongtinkh.BackgroundColor = System.Drawing.SystemColors.Control;
            this.thongtinkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.thongtinkh.DefaultCellStyle = dataGridViewCellStyle3;
            this.thongtinkh.Location = new System.Drawing.Point(523, 400);
            this.thongtinkh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thongtinkh.Name = "thongtinkh";
            this.thongtinkh.ReadOnly = true;
            this.thongtinkh.RowHeadersWidth = 51;
            this.thongtinkh.RowTemplate.Height = 24;
            this.thongtinkh.Size = new System.Drawing.Size(957, 119);
            this.thongtinkh.TabIndex = 3;
            this.thongtinkh.Visible = false;
            // 
            // dsnv
            // 
            this.dsnv.AllowUserToAddRows = false;
            this.dsnv.AllowUserToDeleteRows = false;
            this.dsnv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsnv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dsnv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dsnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dsnv.DefaultCellStyle = dataGridViewCellStyle4;
            this.dsnv.Location = new System.Drawing.Point(0, 21);
            this.dsnv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dsnv.Name = "dsnv";
            this.dsnv.ReadOnly = true;
            this.dsnv.RowHeadersWidth = 51;
            this.dsnv.RowTemplate.Height = 24;
            this.dsnv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsnv.Size = new System.Drawing.Size(616, 290);
            this.dsnv.TabIndex = 35;
            this.dsnv.Click += new System.EventHandler(this.dsnv_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dsnv);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(859, 33);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(621, 316);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách nhân viên";
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.White;
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(1403, 7);
            this.minimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(33, 31);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 38;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.White;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(1444, 7);
            this.logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(33, 31);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logout.TabIndex = 37;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // FormTienDoCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1484, 785);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ComboBox cbotrangthai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbotuychonchiase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbomanv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbotennv;
        private System.Windows.Forms.TextBox tbochucvu;
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