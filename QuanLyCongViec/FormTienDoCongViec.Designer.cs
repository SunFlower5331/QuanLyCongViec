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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dscv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbotencv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbomacv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbotrangthai = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbotuychonchiase = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpthoihan = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dsmanv = new System.Windows.Forms.DataGridView();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthongtinkh = new System.Windows.Forms.Button();
            this.thongtinkh = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dscv)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsmanv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtinkh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dscv);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách công việc";
            // 
            // dscv
            // 
            this.dscv.AllowUserToAddRows = false;
            this.dscv.AllowUserToDeleteRows = false;
            this.dscv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dscv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dscv.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dscv.Location = new System.Drawing.Point(0, 21);
            this.dscv.Name = "dscv";
            this.dscv.ReadOnly = true;
            this.dscv.RowHeadersWidth = 51;
            this.dscv.RowTemplate.Height = 24;
            this.dscv.Size = new System.Drawing.Size(585, 310);
            this.dscv.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnthongtinkh);
            this.groupBox2.Controls.Add(this.btnluu);
            this.groupBox2.Controls.Add(this.btncapnhat);
            this.groupBox2.Controls.Add(this.cbotrangthai);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbotuychonchiase);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtpthoihan);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbotencv);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbomacv);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(633, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 310);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // tbotencv
            // 
            this.tbotencv.Location = new System.Drawing.Point(158, 69);
            this.tbotencv.Name = "tbotencv";
            this.tbotencv.ReadOnly = true;
            this.tbotencv.Size = new System.Drawing.Size(238, 22);
            this.tbotencv.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tên công việc";
            // 
            // tbomacv
            // 
            this.tbomacv.Location = new System.Drawing.Point(158, 38);
            this.tbomacv.Name = "tbomacv";
            this.tbomacv.ReadOnly = true;
            this.tbomacv.Size = new System.Drawing.Size(238, 22);
            this.tbomacv.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã công việc";
            // 
            // cbotrangthai
            // 
            this.cbotrangthai.AutoCompleteCustomSource.AddRange(new string[] {
            "Chưa hoàn thành",
            "Đã hoàn thành"});
            this.cbotrangthai.Enabled = false;
            this.cbotrangthai.FormattingEnabled = true;
            this.cbotrangthai.Items.AddRange(new object[] {
            "Chưa hoàn thành",
            "Đã hoàn thành"});
            this.cbotrangthai.Location = new System.Drawing.Point(158, 146);
            this.cbotrangthai.Name = "cbotrangthai";
            this.cbotrangthai.Size = new System.Drawing.Size(238, 24);
            this.cbotrangthai.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 30;
            this.label8.Text = "Trạng thái";
            // 
            // cbotuychonchiase
            // 
            this.cbotuychonchiase.Enabled = false;
            this.cbotuychonchiase.FormattingEnabled = true;
            this.cbotuychonchiase.Items.AddRange(new object[] {
            "Công việc chung",
            "Bộ phận",
            "Mã nhân viên cụ thể"});
            this.cbotuychonchiase.Location = new System.Drawing.Point(158, 193);
            this.cbotuychonchiase.Name = "cbotuychonchiase";
            this.cbotuychonchiase.Size = new System.Drawing.Size(238, 24);
            this.cbotuychonchiase.TabIndex = 29;
            this.cbotuychonchiase.SelectedIndexChanged += new System.EventHandler(this.cbotuychonchiase_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tùy chọn chia sẻ";
            // 
            // dtpthoihan
            // 
            this.dtpthoihan.Enabled = false;
            this.dtpthoihan.Location = new System.Drawing.Point(158, 105);
            this.dtpthoihan.Name = "dtpthoihan";
            this.dtpthoihan.Size = new System.Drawing.Size(238, 22);
            this.dtpthoihan.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Thời hạn";
            // 
            // dsmanv
            // 
            this.dsmanv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dsmanv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsmanv.Location = new System.Drawing.Point(1057, 33);
            this.dsmanv.Name = "dsmanv";
            this.dsmanv.RowHeadersWidth = 51;
            this.dsmanv.RowTemplate.Height = 24;
            this.dsmanv.Size = new System.Drawing.Size(256, 310);
            this.dsmanv.TabIndex = 2;
            this.dsmanv.Visible = false;
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(191, 254);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(88, 32);
            this.btncapnhat.TabIndex = 32;
            this.btncapnhat.Text = "Cập nhật ";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(308, 254);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(88, 32);
            this.btnluu.TabIndex = 33;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthongtinkh
            // 
            this.btnthongtinkh.Location = new System.Drawing.Point(9, 254);
            this.btnthongtinkh.Name = "btnthongtinkh";
            this.btnthongtinkh.Size = new System.Drawing.Size(142, 32);
            this.btnthongtinkh.TabIndex = 34;
            this.btnthongtinkh.Text = "Thông tin khách hàng";
            this.btnthongtinkh.UseVisualStyleBackColor = true;
            this.btnthongtinkh.Click += new System.EventHandler(this.btnthongtinkh_Click);
            // 
            // thongtinkh
            // 
            this.thongtinkh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.thongtinkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thongtinkh.Location = new System.Drawing.Point(633, 349);
            this.thongtinkh.Name = "thongtinkh";
            this.thongtinkh.RowHeadersWidth = 51;
            this.thongtinkh.RowTemplate.Height = 24;
            this.thongtinkh.Size = new System.Drawing.Size(680, 310);
            this.thongtinkh.TabIndex = 3;
            this.thongtinkh.Visible = false;
            // 
            // FormTienDoCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 662);
            this.Controls.Add(this.thongtinkh);
            this.Controls.Add(this.dsmanv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTienDoCongViec";
            this.Text = "Tiến độ công việc cá nhân";
            this.Load += new System.EventHandler(this.FormTienDoCongViec_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dscv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsmanv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtinkh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dscv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbotencv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbomacv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbotrangthai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbotuychonchiase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpthoihan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dsmanv;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnthongtinkh;
        private System.Windows.Forms.DataGridView thongtinkh;
    }
}