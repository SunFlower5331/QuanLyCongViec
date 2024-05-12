namespace QuanLyCongViec
{
    partial class FormThongKeHieuQuaCongViec
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKeHieuQuaCongViec));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonXuatPDF = new System.Windows.Forms.Button();
            this.buttonExportExcel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoThongKe1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMaNV = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelNgayBatDau = new System.Windows.Forms.Label();
            this.labelNgayKetThuc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textboxMaNV = new System.Windows.Forms.TextBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.labelDeMucBieuDo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonXuatPDF2 = new System.Windows.Forms.Button();
            this.buttonExportExcel2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxPB = new System.Windows.Forms.ComboBox();
            this.comboBoThongKe2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerEnd2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePickerStart2 = new System.Windows.Forms.DateTimePicker();
            this.labelDeMucBieuDo2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl1.Location = new System.Drawing.Point(1, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1467, 594);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.buttonXuatPDF);
            this.tabPage2.Controls.Add(this.buttonExportExcel);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.labelDeMucBieuDo);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1459, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhân viên";
            // 
            // buttonXuatPDF
            // 
            this.buttonXuatPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.buttonXuatPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXuatPDF.ForeColor = System.Drawing.Color.White;
            this.buttonXuatPDF.Location = new System.Drawing.Point(821, 7);
            this.buttonXuatPDF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonXuatPDF.Name = "buttonXuatPDF";
            this.buttonXuatPDF.Size = new System.Drawing.Size(101, 38);
            this.buttonXuatPDF.TabIndex = 23;
            this.buttonXuatPDF.Text = "Xuất PDF";
            this.buttonXuatPDF.UseVisualStyleBackColor = false;
            this.buttonXuatPDF.Click += new System.EventHandler(this.buttonXuatPDF_Click);
            // 
            // buttonExportExcel
            // 
            this.buttonExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))));
            this.buttonExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportExcel.ForeColor = System.Drawing.Color.White;
            this.buttonExportExcel.Location = new System.Drawing.Point(684, 7);
            this.buttonExportExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExportExcel.Name = "buttonExportExcel";
            this.buttonExportExcel.Size = new System.Drawing.Size(101, 38);
            this.buttonExportExcel.TabIndex = 22;
            this.buttonExportExcel.Text = "Xuất Excel";
            this.buttonExportExcel.UseVisualStyleBackColor = false;
            this.buttonExportExcel.Click += new System.EventHandler(this.buttonExportExcel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.comboBoThongKe1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelMaNV);
            this.groupBox1.Controls.Add(this.dateTimePickerEnd);
            this.groupBox1.Controls.Add(this.labelNgayBatDau);
            this.groupBox1.Controls.Add(this.labelNgayKetThuc);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textboxMaNV);
            this.groupBox1.Controls.Add(this.dateTimePickerStart);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(166)))));
            this.groupBox1.Location = new System.Drawing.Point(951, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(493, 188);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê theo ";
            // 
            // comboBoThongKe1
            // 
            this.comboBoThongKe1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoThongKe1.FormattingEnabled = true;
            this.comboBoThongKe1.Items.AddRange(new object[] {
            "Tổng quan",
            "Chi tiết"});
            this.comboBoThongKe1.Location = new System.Drawing.Point(160, 149);
            this.comboBoThongKe1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoThongKe1.Name = "comboBoThongKe1";
            this.comboBoThongKe1.Size = new System.Drawing.Size(317, 24);
            this.comboBoThongKe1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(39, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Thống kê theo:";
            // 
            // labelMaNV
            // 
            this.labelMaNV.AutoSize = true;
            this.labelMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.labelMaNV.Location = new System.Drawing.Point(41, 30);
            this.labelMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(101, 17);
            this.labelMaNV.TabIndex = 0;
            this.labelMaNV.Text = "Mã nhân viên: ";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(160, 106);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(317, 22);
            this.dateTimePickerEnd.TabIndex = 12;
            // 
            // labelNgayBatDau
            // 
            this.labelNgayBatDau.AutoSize = true;
            this.labelNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayBatDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.labelNgayBatDau.Location = new System.Drawing.Point(11, 69);
            this.labelNgayBatDau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNgayBatDau.Name = "labelNgayBatDau";
            this.labelNgayBatDau.Size = new System.Drawing.Size(132, 17);
            this.labelNgayBatDau.TabIndex = 1;
            this.labelNgayBatDau.Text = "Chọn ngày bắt đầu:";
            // 
            // labelNgayKetThuc
            // 
            this.labelNgayKetThuc.AutoSize = true;
            this.labelNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayKetThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.labelNgayKetThuc.Location = new System.Drawing.Point(8, 113);
            this.labelNgayKetThuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNgayKetThuc.Name = "labelNgayKetThuc";
            this.labelNgayKetThuc.Size = new System.Drawing.Size(134, 17);
            this.labelNgayKetThuc.TabIndex = 11;
            this.labelNgayKetThuc.Text = "Chọn ngày kết thúc:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(166)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(345, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textboxMaNV
            // 
            this.textboxMaNV.Location = new System.Drawing.Point(160, 26);
            this.textboxMaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textboxMaNV.Name = "textboxMaNV";
            this.textboxMaNV.Size = new System.Drawing.Size(144, 22);
            this.textboxMaNV.TabIndex = 3;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(160, 65);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(317, 22);
            this.dateTimePickerStart.TabIndex = 10;
            // 
            // labelDeMucBieuDo
            // 
            this.labelDeMucBieuDo.AutoSize = true;
            this.labelDeMucBieuDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeMucBieuDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.labelDeMucBieuDo.Location = new System.Drawing.Point(964, 495);
            this.labelDeMucBieuDo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeMucBieuDo.Name = "labelDeMucBieuDo";
            this.labelDeMucBieuDo.Size = new System.Drawing.Size(445, 26);
            this.labelDeMucBieuDo.TabIndex = 9;
            this.labelDeMucBieuDo.Text = "Tỉ lệ hoàn thành công việc của nhân viên";
            // 
            // panel1
            // 
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1055, 203);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 277);
            this.panel1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Location = new System.Drawing.Point(8, 53);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(917, 480);
            this.dataGridView1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.buttonXuatPDF2);
            this.tabPage1.Controls.Add(this.buttonExportExcel2);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.labelDeMucBieuDo2);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1381, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bộ phận";
            // 
            // buttonXuatPDF2
            // 
            this.buttonXuatPDF2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.buttonXuatPDF2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXuatPDF2.ForeColor = System.Drawing.Color.White;
            this.buttonXuatPDF2.Location = new System.Drawing.Point(824, 7);
            this.buttonXuatPDF2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonXuatPDF2.Name = "buttonXuatPDF2";
            this.buttonXuatPDF2.Size = new System.Drawing.Size(101, 38);
            this.buttonXuatPDF2.TabIndex = 26;
            this.buttonXuatPDF2.Text = "Xuất PDF";
            this.buttonXuatPDF2.UseVisualStyleBackColor = false;
            this.buttonXuatPDF2.Click += new System.EventHandler(this.buttonXuatPDF2_Click);
            // 
            // buttonExportExcel2
            // 
            this.buttonExportExcel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))));
            this.buttonExportExcel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportExcel2.ForeColor = System.Drawing.Color.White;
            this.buttonExportExcel2.Location = new System.Drawing.Point(687, 7);
            this.buttonExportExcel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExportExcel2.Name = "buttonExportExcel2";
            this.buttonExportExcel2.Size = new System.Drawing.Size(101, 38);
            this.buttonExportExcel2.TabIndex = 25;
            this.buttonExportExcel2.Text = "Xuất Excel";
            this.buttonExportExcel2.UseVisualStyleBackColor = false;
            this.buttonExportExcel2.Click += new System.EventHandler(this.buttonExportExcel2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.comboBoxPB);
            this.groupBox2.Controls.Add(this.comboBoThongKe2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePickerEnd2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.dateTimePickerStart2);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(166)))));
            this.groupBox2.Location = new System.Drawing.Point(951, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(493, 188);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê theo ";
            // 
            // comboBoxPB
            // 
            this.comboBoxPB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPB.FormattingEnabled = true;
            this.comboBoxPB.Location = new System.Drawing.Point(160, 26);
            this.comboBoxPB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxPB.Name = "comboBoxPB";
            this.comboBoxPB.Size = new System.Drawing.Size(148, 24);
            this.comboBoxPB.TabIndex = 17;
            this.comboBoxPB.SelectedIndexChanged += new System.EventHandler(this.comboBoxPB_SelectedIndexChanged);
            // 
            // comboBoThongKe2
            // 
            this.comboBoThongKe2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoThongKe2.FormattingEnabled = true;
            this.comboBoThongKe2.Items.AddRange(new object[] {
            "Tổng quan",
            "Chi tiết"});
            this.comboBoThongKe2.Location = new System.Drawing.Point(160, 148);
            this.comboBoThongKe2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoThongKe2.Name = "comboBoThongKe2";
            this.comboBoThongKe2.Size = new System.Drawing.Size(317, 24);
            this.comboBoThongKe2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(39, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Thống kê theo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng ban:";
            // 
            // dateTimePickerEnd2
            // 
            this.dateTimePickerEnd2.Location = new System.Drawing.Point(160, 106);
            this.dateTimePickerEnd2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerEnd2.Name = "dateTimePickerEnd2";
            this.dateTimePickerEnd2.Size = new System.Drawing.Size(317, 22);
            this.dateTimePickerEnd2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(11, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn ngày bắt đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(8, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Chọn ngày kết thúc:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(166)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(345, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 30);
            this.button2.TabIndex = 14;
            this.button2.Text = "Thống kê";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePickerStart2
            // 
            this.dateTimePickerStart2.Location = new System.Drawing.Point(160, 65);
            this.dateTimePickerStart2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerStart2.Name = "dateTimePickerStart2";
            this.dateTimePickerStart2.Size = new System.Drawing.Size(317, 22);
            this.dateTimePickerStart2.TabIndex = 10;
            // 
            // labelDeMucBieuDo2
            // 
            this.labelDeMucBieuDo2.AutoSize = true;
            this.labelDeMucBieuDo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeMucBieuDo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.labelDeMucBieuDo2.Location = new System.Drawing.Point(971, 498);
            this.labelDeMucBieuDo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeMucBieuDo2.Name = "labelDeMucBieuDo2";
            this.labelDeMucBieuDo2.Size = new System.Drawing.Size(445, 26);
            this.labelDeMucBieuDo2.TabIndex = 17;
            this.labelDeMucBieuDo2.Text = "Tỉ lệ hoàn thành công việc của nhân viên";
            // 
            // panel2
            // 
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(1055, 203);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 277);
            this.panel2.TabIndex = 16;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.Location = new System.Drawing.Point(8, 53);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(917, 480);
            this.dataGridView2.TabIndex = 15;
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(1380, 4);
            this.minimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(33, 31);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 28;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(1427, 4);
            this.logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(33, 31);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logout.TabIndex = 27;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // FormThongKeHieuQuaCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1463, 593);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormThongKeHieuQuaCongViec";
            this.Text = "FormThongKeHieuQuaCongViec";
            this.Load += new System.EventHandler(this.FormThongKeHieuQuaCongViec_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormThongKeHieuQuaCongViec_MouseDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelNgayBatDau;
        private System.Windows.Forms.Label labelMaNV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textboxMaNV;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDeMucBieuDo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label labelNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart2;
        private System.Windows.Forms.Label labelDeMucBieuDo2;
        private System.Windows.Forms.ComboBox comboBoThongKe1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoThongKe2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxPB;
        private System.Windows.Forms.Button buttonXuatPDF;
        private System.Windows.Forms.Button buttonExportExcel;
        private System.Windows.Forms.Button buttonXuatPDF2;
        private System.Windows.Forms.Button buttonExportExcel2;
    }
}