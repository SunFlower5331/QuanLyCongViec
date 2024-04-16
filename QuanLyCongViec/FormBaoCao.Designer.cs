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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaoCao));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dsch = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dsyc = new System.Windows.Forms.DataGridView();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonXacNhan = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxThoiGian = new System.Windows.Forms.CheckBox();
            this.checkBoxTinhTrangCanHo = new System.Windows.Forms.CheckBox();
            this.checkBoxQuocTich = new System.Windows.Forms.CheckBox();
            this.checkBoxCongNo = new System.Windows.Forms.CheckBox();
            this.checkBoxTongChiPhi = new System.Windows.Forms.CheckBox();
            this.checkBoxNVPT = new System.Windows.Forms.CheckBox();
            this.checkBoxTinhTrangXuLy = new System.Windows.Forms.CheckBox();
            this.checkBoxNguoiYC = new System.Windows.Forms.CheckBox();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.timkiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsch)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsyc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.dsch);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 204);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách căn hộ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dsch
            // 
            this.dsch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dsch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dsch.DefaultCellStyle = dataGridViewCellStyle1;
            this.dsch.Location = new System.Drawing.Point(11, 19);
            this.dsch.Name = "dsch";
            this.dsch.Size = new System.Drawing.Size(847, 178);
            this.dsch.TabIndex = 5;
            this.dsch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsch_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dsyc);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 224);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách yêu cầu";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dsyc
            // 
            this.dsyc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dsyc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dsyc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dsyc.Location = new System.Drawing.Point(11, 19);
            this.dsyc.Name = "dsyc";
            this.dsyc.Size = new System.Drawing.Size(847, 196);
            this.dsyc.TabIndex = 6;
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.White;
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
            this.logout.BackColor = System.Drawing.Color.White;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(864, 7);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(25, 25);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logout.TabIndex = 19;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.buttonXacNhan);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.dateTimePickerEnd);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dateTimePickerStart);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(12, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(872, 100);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tùy chọn";
            // 
            // buttonXacNhan
            // 
            this.buttonXacNhan.Location = new System.Drawing.Point(794, 36);
            this.buttonXacNhan.Name = "buttonXacNhan";
            this.buttonXacNhan.Size = new System.Drawing.Size(68, 37);
            this.buttonXacNhan.TabIndex = 18;
            this.buttonXacNhan.Text = "Xác nhận";
            this.buttonXacNhan.UseVisualStyleBackColor = true;
            this.buttonXacNhan.Click += new System.EventHandler(this.buttonXacNhan_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxThoiGian);
            this.groupBox4.Controls.Add(this.checkBoxTinhTrangCanHo);
            this.groupBox4.Controls.Add(this.checkBoxQuocTich);
            this.groupBox4.Controls.Add(this.checkBoxCongNo);
            this.groupBox4.Controls.Add(this.checkBoxTongChiPhi);
            this.groupBox4.Controls.Add(this.checkBoxNVPT);
            this.groupBox4.Controls.Add(this.checkBoxTinhTrangXuLy);
            this.groupBox4.Controls.Add(this.checkBoxNguoiYC);
            this.groupBox4.Location = new System.Drawing.Point(11, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(471, 70);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            // 
            // checkBoxThoiGian
            // 
            this.checkBoxThoiGian.AutoSize = true;
            this.checkBoxThoiGian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.checkBoxThoiGian.Location = new System.Drawing.Point(377, 43);
            this.checkBoxThoiGian.Name = "checkBoxThoiGian";
            this.checkBoxThoiGian.Size = new System.Drawing.Size(92, 17);
            this.checkBoxThoiGian.TabIndex = 7;
            this.checkBoxThoiGian.Text = "Ngày yêu cầu";
            this.checkBoxThoiGian.UseVisualStyleBackColor = true;
            // 
            // checkBoxTinhTrangCanHo
            // 
            this.checkBoxTinhTrangCanHo.AutoSize = true;
            this.checkBoxTinhTrangCanHo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.checkBoxTinhTrangCanHo.Location = new System.Drawing.Point(246, 43);
            this.checkBoxTinhTrangCanHo.Name = "checkBoxTinhTrangCanHo";
            this.checkBoxTinhTrangCanHo.Size = new System.Drawing.Size(110, 17);
            this.checkBoxTinhTrangCanHo.TabIndex = 6;
            this.checkBoxTinhTrangCanHo.Text = "Tình trạng căn hộ";
            this.checkBoxTinhTrangCanHo.UseVisualStyleBackColor = true;
            // 
            // checkBoxQuocTich
            // 
            this.checkBoxQuocTich.AutoSize = true;
            this.checkBoxQuocTich.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.checkBoxQuocTich.Location = new System.Drawing.Point(377, 12);
            this.checkBoxQuocTich.Name = "checkBoxQuocTich";
            this.checkBoxQuocTich.Size = new System.Drawing.Size(72, 17);
            this.checkBoxQuocTich.TabIndex = 5;
            this.checkBoxQuocTich.Text = "Quốc tịch";
            this.checkBoxQuocTich.UseVisualStyleBackColor = true;
            // 
            // checkBoxCongNo
            // 
            this.checkBoxCongNo.AutoSize = true;
            this.checkBoxCongNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.checkBoxCongNo.Location = new System.Drawing.Point(7, 12);
            this.checkBoxCongNo.Name = "checkBoxCongNo";
            this.checkBoxCongNo.Size = new System.Drawing.Size(66, 17);
            this.checkBoxCongNo.TabIndex = 3;
            this.checkBoxCongNo.Text = "Công nợ";
            this.checkBoxCongNo.UseVisualStyleBackColor = true;
            // 
            // checkBoxTongChiPhi
            // 
            this.checkBoxTongChiPhi.AutoSize = true;
            this.checkBoxTongChiPhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.checkBoxTongChiPhi.Location = new System.Drawing.Point(7, 43);
            this.checkBoxTongChiPhi.Name = "checkBoxTongChiPhi";
            this.checkBoxTongChiPhi.Size = new System.Drawing.Size(87, 17);
            this.checkBoxTongChiPhi.TabIndex = 4;
            this.checkBoxTongChiPhi.Text = "Tổng chi phí";
            this.checkBoxTongChiPhi.UseVisualStyleBackColor = true;
            // 
            // checkBoxNVPT
            // 
            this.checkBoxNVPT.AutoSize = true;
            this.checkBoxNVPT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.checkBoxNVPT.Location = new System.Drawing.Point(101, 45);
            this.checkBoxNVPT.Name = "checkBoxNVPT";
            this.checkBoxNVPT.Size = new System.Drawing.Size(123, 17);
            this.checkBoxNVPT.TabIndex = 2;
            this.checkBoxNVPT.Text = "Nhân viên phụ trách";
            this.checkBoxNVPT.UseVisualStyleBackColor = true;
            // 
            // checkBoxTinhTrangXuLy
            // 
            this.checkBoxTinhTrangXuLy.AutoSize = true;
            this.checkBoxTinhTrangXuLy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.checkBoxTinhTrangXuLy.Location = new System.Drawing.Point(246, 12);
            this.checkBoxTinhTrangXuLy.Name = "checkBoxTinhTrangXuLy";
            this.checkBoxTinhTrangXuLy.Size = new System.Drawing.Size(98, 17);
            this.checkBoxTinhTrangXuLy.TabIndex = 1;
            this.checkBoxTinhTrangXuLy.Text = "Tình trạng xử lý";
            this.checkBoxTinhTrangXuLy.UseVisualStyleBackColor = true;
            this.checkBoxTinhTrangXuLy.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxNguoiYC
            // 
            this.checkBoxNguoiYC.AutoSize = true;
            this.checkBoxNguoiYC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.checkBoxNguoiYC.Location = new System.Drawing.Point(101, 12);
            this.checkBoxNguoiYC.Name = "checkBoxNguoiYC";
            this.checkBoxNguoiYC.Size = new System.Drawing.Size(95, 17);
            this.checkBoxNguoiYC.TabIndex = 0;
            this.checkBoxNguoiYC.Text = "Người yêu cầu";
            this.checkBoxNguoiYC.UseVisualStyleBackColor = true;
            this.checkBoxNguoiYC.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(600, 59);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(181, 20);
            this.dateTimePickerEnd.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(488, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Chọn ngày bắt đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(486, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Chọn ngày kết thúc:";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(600, 26);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(181, 20);
            this.dateTimePickerStart.TabIndex = 14;
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxTimKiem.Location = new System.Drawing.Point(328, 21);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(238, 20);
            this.textBoxTimKiem.TabIndex = 7;
            this.textBoxTimKiem.Text = "Tìm kiếm theo mã căn hộ";
            this.textBoxTimKiem.Enter += new System.EventHandler(this.textBoxTimKiem_Enter);
            this.textBoxTimKiem.Leave += new System.EventHandler(this.textBoxTimKiem_Leave);
            // 
            // timkiem
            // 
            this.timkiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.timkiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timkiem.ForeColor = System.Drawing.Color.White;
            this.timkiem.Image = ((System.Drawing.Image)(resources.GetObject("timkiem.Image")));
            this.timkiem.Location = new System.Drawing.Point(579, 14);
            this.timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(31, 33);
            this.timkiem.TabIndex = 8;
            this.timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.timkiem.UseVisualStyleBackColor = true;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 606);
            this.Controls.Add(this.textBoxTimKiem);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.logout);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBaoCao";
            this.Text = "FormBaoCao";
            this.Load += new System.EventHandler(this.FormBaoCao_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormBaoCao_MouseDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsch)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsyc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dsch;
        private System.Windows.Forms.DataGridView dsyc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxTongChiPhi;
        private System.Windows.Forms.CheckBox checkBoxCongNo;
        private System.Windows.Forms.CheckBox checkBoxNVPT;
        private System.Windows.Forms.CheckBox checkBoxTinhTrangXuLy;
        private System.Windows.Forms.CheckBox checkBoxNguoiYC;
        private System.Windows.Forms.CheckBox checkBoxQuocTich;
        private System.Windows.Forms.CheckBox checkBoxThoiGian;
        private System.Windows.Forms.CheckBox checkBoxTinhTrangCanHo;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonXacNhan;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Button timkiem;
    }
}