namespace QuanLyCongViec
{
    partial class FormBaoCao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaoCao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dsch = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dsyc = new System.Windows.Forms.DataGridView();
            this.MaCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CongNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPDienNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPQuanLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPKhac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XemThongTin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCH_YC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiYC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DichVuDinhKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayYC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDYC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang_YC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NVPhuTrach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsyc)).BeginInit();
            this.SuspendLayout();
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(829, 7);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 20;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(864, 7);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(25, 25);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logout.TabIndex = 19;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dsch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 258);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách căn hộ";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã căn hộ",
            "Tên chủ hộ",
            "Công nợ"});
            this.comboBox1.Location = new System.Drawing.Point(421, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(258, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 27);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.dsyc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 280);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách yêu cầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sắp xếp theo: ";
            // 
            // dsch
            // 
            this.dsch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCH,
            this.TenCH,
            this.TinhTrang,
            this.CongNo,
            this.CPDienNuoc,
            this.CPQuanLy,
            this.CPKhac,
            this.XemThongTin});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dsch.DefaultCellStyle = dataGridViewCellStyle5;
            this.dsch.Location = new System.Drawing.Point(11, 74);
            this.dsch.Name = "dsch";
            this.dsch.Size = new System.Drawing.Size(847, 178);
            this.dsch.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sắp xếp theo: ";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Quý",
            "Năm"});
            this.comboBox2.Location = new System.Drawing.Point(421, 30);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(258, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 27);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dsyc
            // 
            this.dsyc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsyc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCH_YC,
            this.NguoiYC,
            this.DichVuDinhKy,
            this.NgayYC,
            this.NDYC,
            this.TinhTrang_YC,
            this.NVPhuTrach,
            this.GhiChu});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dsyc.DefaultCellStyle = dataGridViewCellStyle6;
            this.dsyc.Location = new System.Drawing.Point(11, 73);
            this.dsyc.Name = "dsyc";
            this.dsyc.Size = new System.Drawing.Size(847, 196);
            this.dsyc.TabIndex = 6;
            // 
            // MaCH
            // 
            this.MaCH.HeaderText = "Mã căn hộ";
            this.MaCH.Name = "MaCH";
            // 
            // TenCH
            // 
            this.TenCH.HeaderText = "Tên chủ hộ";
            this.TenCH.Name = "TenCH";
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.Name = "TinhTrang";
            // 
            // CongNo
            // 
            this.CongNo.HeaderText = "Công nợ";
            this.CongNo.Name = "CongNo";
            // 
            // CPDienNuoc
            // 
            this.CPDienNuoc.HeaderText = "Chi phí điện nước";
            this.CPDienNuoc.Name = "CPDienNuoc";
            // 
            // CPQuanLy
            // 
            this.CPQuanLy.HeaderText = "Chi phí quản lý";
            this.CPQuanLy.Name = "CPQuanLy";
            // 
            // CPKhac
            // 
            this.CPKhac.HeaderText = "Chi phí khác";
            this.CPKhac.Name = "CPKhac";
            // 
            // XemThongTin
            // 
            this.XemThongTin.HeaderText = "Xem thông rin";
            this.XemThongTin.Name = "XemThongTin";
            // 
            // MaCH_YC
            // 
            this.MaCH_YC.HeaderText = "Mã căn hộ";
            this.MaCH_YC.Name = "MaCH_YC";
            // 
            // NguoiYC
            // 
            this.NguoiYC.HeaderText = "Người yêu cầu";
            this.NguoiYC.Name = "NguoiYC";
            // 
            // DichVuDinhKy
            // 
            this.DichVuDinhKy.HeaderText = "Dịch vụ định kỳ";
            this.DichVuDinhKy.Name = "DichVuDinhKy";
            // 
            // NgayYC
            // 
            this.NgayYC.HeaderText = "Ngày yêu cầu";
            this.NgayYC.Name = "NgayYC";
            // 
            // NDYC
            // 
            this.NDYC.HeaderText = "Nội dung yêu cầu";
            this.NDYC.Name = "NDYC";
            // 
            // TinhTrang_YC
            // 
            this.TinhTrang_YC.HeaderText = "Tình trạng";
            this.TinhTrang_YC.Name = "TinhTrang_YC";
            // 
            // NVPhuTrach
            // 
            this.NVPhuTrach.HeaderText = "Nhân viên phụ trách";
            this.NVPhuTrach.Name = "NVPhuTrach";
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(42, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 20);
            this.textBox2.TabIndex = 10;
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(896, 606);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.logout);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBaoCao";
            this.Text = "FormBaoCao";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormBaoCao_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsyc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dsch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dsyc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn CongNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPDienNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPQuanLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPKhac;
        private System.Windows.Forms.DataGridViewTextBoxColumn XemThongTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCH_YC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiYC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DichVuDinhKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayYC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDYC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang_YC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NVPhuTrach;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}