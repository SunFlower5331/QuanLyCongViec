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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKeHieuQuaCongViec));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonXuatPDF = new System.Windows.Forms.Button();
            this.buttonExportExcel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoThongKe1 = new System.Windows.Forms.ComboBox();
            this.labelThongKe = new System.Windows.Forms.Label();
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
            this.labelThongKe2 = new System.Windows.Forms.Label();
            this.labelMaPB = new System.Windows.Forms.Label();
            this.dateTimePickerEnd2 = new System.Windows.Forms.DateTimePicker();
            this.labelNgayBatDau2 = new System.Windows.Forms.Label();
            this.labelNgayKetThuc2 = new System.Windows.Forms.Label();
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
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1103, 483);
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
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1095, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhân viên";
            // 
            // buttonXuatPDF
            // 
            this.buttonXuatPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.buttonXuatPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXuatPDF.ForeColor = System.Drawing.Color.White;
            this.buttonXuatPDF.Location = new System.Drawing.Point(616, 6);
            this.buttonXuatPDF.Name = "buttonXuatPDF";
            this.buttonXuatPDF.Size = new System.Drawing.Size(76, 31);
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
            this.buttonExportExcel.Location = new System.Drawing.Point(513, 6);
            this.buttonExportExcel.Name = "buttonExportExcel";
            this.buttonExportExcel.Size = new System.Drawing.Size(76, 31);
            this.buttonExportExcel.TabIndex = 22;
            this.buttonExportExcel.Text = "Xuất Excel";
            this.buttonExportExcel.UseVisualStyleBackColor = false;
            this.buttonExportExcel.Click += new System.EventHandler(this.buttonExportExcel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.comboBoThongKe1);
            this.groupBox1.Controls.Add(this.labelThongKe);
            this.groupBox1.Controls.Add(this.labelMaNV);
            this.groupBox1.Controls.Add(this.dateTimePickerEnd);
            this.groupBox1.Controls.Add(this.labelNgayBatDau);
            this.groupBox1.Controls.Add(this.labelNgayKetThuc);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textboxMaNV);
            this.groupBox1.Controls.Add(this.dateTimePickerStart);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(166)))));
            this.groupBox1.Location = new System.Drawing.Point(713, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 153);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê theo ";
            // 
            // comboBoThongKe1
            // 
            this.comboBoThongKe1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoThongKe1.FormattingEnabled = true;
            this.comboBoThongKe1.Location = new System.Drawing.Point(120, 121);
            this.comboBoThongKe1.Name = "comboBoThongKe1";
            this.comboBoThongKe1.Size = new System.Drawing.Size(239, 21);
            this.comboBoThongKe1.TabIndex = 14;
            // 
            // labelThongKe
            // 
            this.labelThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.labelThongKe.Location = new System.Drawing.Point(29, 124);
            this.labelThongKe.Name = "labelThongKe";
            this.labelThongKe.Size = new System.Drawing.Size(80, 13);
            this.labelThongKe.TabIndex = 13;
            this.labelThongKe.Text = "Thống kê theo:";
            this.labelThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMaNV
            // 
            this.labelMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.labelMaNV.Location = new System.Drawing.Point(31, 24);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(78, 13);
            this.labelMaNV.TabIndex = 0;
            this.labelMaNV.Text = "Mã nhân viên: ";
            this.labelMaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(120, 86);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(239, 20);
            this.dateTimePickerEnd.TabIndex = 12;
            // 
            // labelNgayBatDau
            // 
            this.labelNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayBatDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.labelNgayBatDau.Location = new System.Drawing.Point(8, 56);
            this.labelNgayBatDau.Name = "labelNgayBatDau";
            this.labelNgayBatDau.Size = new System.Drawing.Size(101, 13);
            this.labelNgayBatDau.TabIndex = 1;
            this.labelNgayBatDau.Text = "Chọn ngày bắt đầu:";
            this.labelNgayBatDau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNgayKetThuc
            // 
            this.labelNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayKetThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.labelNgayKetThuc.Location = new System.Drawing.Point(6, 92);
            this.labelNgayKetThuc.Name = "labelNgayKetThuc";
            this.labelNgayKetThuc.Size = new System.Drawing.Size(103, 13);
            this.labelNgayKetThuc.TabIndex = 11;
            this.labelNgayKetThuc.Text = "Chọn ngày kết thúc:";
            this.labelNgayKetThuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(166)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(259, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textboxMaNV
            // 
            this.textboxMaNV.Location = new System.Drawing.Point(120, 21);
            this.textboxMaNV.Name = "textboxMaNV";
            this.textboxMaNV.Size = new System.Drawing.Size(109, 20);
            this.textboxMaNV.TabIndex = 3;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(120, 53);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(239, 20);
            this.dateTimePickerStart.TabIndex = 10;
            // 
            // labelDeMucBieuDo
            // 
            this.labelDeMucBieuDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeMucBieuDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.labelDeMucBieuDo.Location = new System.Drawing.Point(723, 402);
            this.labelDeMucBieuDo.Name = "labelDeMucBieuDo";
            this.labelDeMucBieuDo.Size = new System.Drawing.Size(352, 20);
            this.labelDeMucBieuDo.TabIndex = 9;
            this.labelDeMucBieuDo.Text = "Tỉ lệ hoàn thành công việc của nhân viên";
            this.labelDeMucBieuDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(791, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 225);
            this.panel1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(688, 390);
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
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1095, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bộ phận";
            // 
            // buttonXuatPDF2
            // 
            this.buttonXuatPDF2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.buttonXuatPDF2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXuatPDF2.ForeColor = System.Drawing.Color.White;
            this.buttonXuatPDF2.Location = new System.Drawing.Point(618, 6);
            this.buttonXuatPDF2.Name = "buttonXuatPDF2";
            this.buttonXuatPDF2.Size = new System.Drawing.Size(76, 31);
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
            this.buttonExportExcel2.Location = new System.Drawing.Point(515, 6);
            this.buttonExportExcel2.Name = "buttonExportExcel2";
            this.buttonExportExcel2.Size = new System.Drawing.Size(76, 31);
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
            this.groupBox2.Controls.Add(this.labelThongKe2);
            this.groupBox2.Controls.Add(this.labelMaPB);
            this.groupBox2.Controls.Add(this.dateTimePickerEnd2);
            this.groupBox2.Controls.Add(this.labelNgayBatDau2);
            this.groupBox2.Controls.Add(this.labelNgayKetThuc2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.dateTimePickerStart2);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(166)))));
            this.groupBox2.Location = new System.Drawing.Point(713, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 153);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê theo ";
            // 
            // comboBoxPB
            // 
            this.comboBoxPB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPB.FormattingEnabled = true;
            this.comboBoxPB.Location = new System.Drawing.Point(120, 21);
            this.comboBoxPB.Name = "comboBoxPB";
            this.comboBoxPB.Size = new System.Drawing.Size(112, 21);
            this.comboBoxPB.TabIndex = 17;
            // 
            // comboBoThongKe2
            // 
            this.comboBoThongKe2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoThongKe2.FormattingEnabled = true;
            this.comboBoThongKe2.Location = new System.Drawing.Point(120, 120);
            this.comboBoThongKe2.Name = "comboBoThongKe2";
            this.comboBoThongKe2.Size = new System.Drawing.Size(239, 21);
            this.comboBoThongKe2.TabIndex = 16;
            // 
            // labelThongKe2
            // 
            this.labelThongKe2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.labelThongKe2.Location = new System.Drawing.Point(29, 123);
            this.labelThongKe2.Name = "labelThongKe2";
            this.labelThongKe2.Size = new System.Drawing.Size(80, 13);
            this.labelThongKe2.TabIndex = 15;
            this.labelThongKe2.Text = "Thống kê theo:";
            this.labelThongKe2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMaPB
            // 
            this.labelMaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaPB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.labelMaPB.Location = new System.Drawing.Point(29, 24);
            this.labelMaPB.Name = "labelMaPB";
            this.labelMaPB.Size = new System.Drawing.Size(79, 13);
            this.labelMaPB.TabIndex = 0;
            this.labelMaPB.Text = "Mã phòng ban:";
            this.labelMaPB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePickerEnd2
            // 
            this.dateTimePickerEnd2.Location = new System.Drawing.Point(120, 86);
            this.dateTimePickerEnd2.Name = "dateTimePickerEnd2";
            this.dateTimePickerEnd2.Size = new System.Drawing.Size(239, 20);
            this.dateTimePickerEnd2.TabIndex = 12;
            // 
            // labelNgayBatDau2
            // 
            this.labelNgayBatDau2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayBatDau2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.labelNgayBatDau2.Location = new System.Drawing.Point(8, 56);
            this.labelNgayBatDau2.Name = "labelNgayBatDau2";
            this.labelNgayBatDau2.Size = new System.Drawing.Size(101, 13);
            this.labelNgayBatDau2.TabIndex = 1;
            this.labelNgayBatDau2.Text = "Chọn ngày bắt đầu:";
            this.labelNgayBatDau2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNgayKetThuc2
            // 
            this.labelNgayKetThuc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayKetThuc2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.labelNgayKetThuc2.Location = new System.Drawing.Point(6, 92);
            this.labelNgayKetThuc2.Name = "labelNgayKetThuc2";
            this.labelNgayKetThuc2.Size = new System.Drawing.Size(103, 13);
            this.labelNgayKetThuc2.TabIndex = 11;
            this.labelNgayKetThuc2.Text = "Chọn ngày kết thúc:";
            this.labelNgayKetThuc2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(166)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(259, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Thống kê";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePickerStart2
            // 
            this.dateTimePickerStart2.Location = new System.Drawing.Point(120, 53);
            this.dateTimePickerStart2.Name = "dateTimePickerStart2";
            this.dateTimePickerStart2.Size = new System.Drawing.Size(239, 20);
            this.dateTimePickerStart2.TabIndex = 10;
            // 
            // labelDeMucBieuDo2
            // 
            this.labelDeMucBieuDo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeMucBieuDo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.labelDeMucBieuDo2.Location = new System.Drawing.Point(728, 405);
            this.labelDeMucBieuDo2.Name = "labelDeMucBieuDo2";
            this.labelDeMucBieuDo2.Size = new System.Drawing.Size(352, 20);
            this.labelDeMucBieuDo2.TabIndex = 17;
            this.labelDeMucBieuDo2.Text = "Tỉ lệ hoàn thành công việc của nhân viên";
            this.labelDeMucBieuDo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(791, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 225);
            this.panel2.TabIndex = 16;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(6, 43);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(688, 390);
            this.dataGridView2.TabIndex = 15;
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(1035, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 28;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(1070, 3);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(25, 25);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logout.TabIndex = 27;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // FormThongKeHieuQuaCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1106, 482);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormThongKeHieuQuaCongViec";
            this.Text = "FormThongKeHieuQuaCongViec";
            this.Load += new System.EventHandler(this.FormThongKeHieuQuaCongViec_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormThongKeHieuQuaCongViec_MouseDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Label labelMaPB;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd2;
        private System.Windows.Forms.Label labelNgayBatDau2;
        private System.Windows.Forms.Label labelNgayKetThuc2;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart2;
        private System.Windows.Forms.Label labelDeMucBieuDo2;
        private System.Windows.Forms.ComboBox comboBoThongKe1;
        private System.Windows.Forms.Label labelThongKe;
        private System.Windows.Forms.ComboBox comboBoThongKe2;
        private System.Windows.Forms.Label labelThongKe2;
        private System.Windows.Forms.ComboBox comboBoxPB;
        private System.Windows.Forms.Button buttonXuatPDF;
        private System.Windows.Forms.Button buttonExportExcel;
        private System.Windows.Forms.Button buttonXuatPDF2;
        private System.Windows.Forms.Button buttonExportExcel2;
    }
}