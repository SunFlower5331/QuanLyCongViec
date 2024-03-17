namespace QuanLyCongViec
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbotrangthai = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbotuychonchiase = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbomanv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dsnv = new System.Windows.Forms.DataGridView();
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dsdpc = new System.Windows.Forms.DataGridView();
            this.tongquat = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dscv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnphancong = new System.Windows.Forms.Button();
            this.btnchinhsuaphancong = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsnv)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsdpc)).BeginInit();
            this.tongquat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dscv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbotrangthai);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbotuychonchiase);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbomanv);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dsnv);
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
            this.groupBox2.Location = new System.Drawing.Point(435, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 603);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phân công công việc";
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
            this.cbotrangthai.Location = new System.Drawing.Point(173, 552);
            this.cbotrangthai.Name = "cbotrangthai";
            this.cbotrangthai.Size = new System.Drawing.Size(238, 24);
            this.cbotrangthai.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 558);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Trạng thái";
            // 
            // cbotuychonchiase
            // 
            this.cbotuychonchiase.FormattingEnabled = true;
            this.cbotuychonchiase.Items.AddRange(new object[] {
            "Công việc chung",
            "Bộ phận"});
            this.cbotuychonchiase.Location = new System.Drawing.Point(173, 516);
            this.cbotuychonchiase.Name = "cbotuychonchiase";
            this.cbotuychonchiase.Size = new System.Drawing.Size(238, 24);
            this.cbotuychonchiase.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 522);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tùy chọn chia sẻ";
            // 
            // tbomanv
            // 
            this.tbomanv.Location = new System.Drawing.Point(173, 392);
            this.tbomanv.Name = "tbomanv";
            this.tbomanv.ReadOnly = true;
            this.tbomanv.Size = new System.Drawing.Size(238, 22);
            this.tbomanv.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mã nhân viên\r\n";
            // 
            // dsnv
            // 
            this.dsnv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dsnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsnv.Location = new System.Drawing.Point(6, 21);
            this.dsnv.Name = "dsnv";
            this.dsnv.ReadOnly = true;
            this.dsnv.RowHeadersWidth = 51;
            this.dsnv.RowTemplate.Height = 24;
            this.dsnv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsnv.Size = new System.Drawing.Size(459, 246);
            this.dsnv.TabIndex = 19;
            this.dsnv.Click += new System.EventHandler(this.dsnv_Click);
            // 
            // tbotennv
            // 
            this.tbotennv.Location = new System.Drawing.Point(173, 434);
            this.tbotennv.Name = "tbotennv";
            this.tbotennv.ReadOnly = true;
            this.tbotennv.Size = new System.Drawing.Size(238, 22);
            this.tbotennv.TabIndex = 18;
            // 
            // tbobophan
            // 
            this.tbobophan.Location = new System.Drawing.Point(173, 356);
            this.tbobophan.Name = "tbobophan";
            this.tbobophan.ReadOnly = true;
            this.tbobophan.Size = new System.Drawing.Size(238, 22);
            this.tbobophan.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tên Nhân viên";
            // 
            // tbotencv
            // 
            this.tbotencv.Location = new System.Drawing.Point(173, 316);
            this.tbotencv.Name = "tbotencv";
            this.tbotencv.ReadOnly = true;
            this.tbotencv.Size = new System.Drawing.Size(238, 22);
            this.tbotencv.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên công việc";
            // 
            // tbomacv
            // 
            this.tbomacv.Location = new System.Drawing.Point(173, 285);
            this.tbomacv.Name = "tbomacv";
            this.tbomacv.ReadOnly = true;
            this.tbomacv.Size = new System.Drawing.Size(238, 22);
            this.tbomacv.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã công việc";
            // 
            // dtpthoihan
            // 
            this.dtpthoihan.Location = new System.Drawing.Point(173, 475);
            this.dtpthoihan.Name = "dtpthoihan";
            this.dtpthoihan.Size = new System.Drawing.Size(238, 22);
            this.dtpthoihan.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bộ phận";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thời hạn";
            // 
            // btnluu
            // 
            this.btnluu.Enabled = false;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(157, 552);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(88, 30);
            this.btnluu.TabIndex = 20;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(310, 552);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(88, 30);
            this.btnthoat.TabIndex = 19;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapnhat.Location = new System.Drawing.Point(157, 498);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(88, 30);
            this.btncapnhat.TabIndex = 18;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(310, 497);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(88, 30);
            this.btnxoa.TabIndex = 17;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(15, 499);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(88, 30);
            this.btnthem.TabIndex = 16;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dsdpc);
            this.groupBox3.Location = new System.Drawing.Point(933, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 438);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách công việc đã phân công";
            // 
            // dsdpc
            // 
            this.dsdpc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dsdpc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsdpc.Location = new System.Drawing.Point(6, 20);
            this.dsdpc.Name = "dsdpc";
            this.dsdpc.ReadOnly = true;
            this.dsdpc.RowHeadersWidth = 51;
            this.dsdpc.RowTemplate.Height = 24;
            this.dsdpc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsdpc.Size = new System.Drawing.Size(383, 412);
            this.dsdpc.TabIndex = 2;
            this.dsdpc.Click += new System.EventHandler(this.dsdpc_Click);
            // 
            // tongquat
            // 
            this.tongquat.Controls.Add(this.btnchinhsuaphancong);
            this.tongquat.Controls.Add(this.groupBox1);
            this.tongquat.Controls.Add(this.btnphancong);
            this.tongquat.Controls.Add(this.button1);
            this.tongquat.Controls.Add(this.btnluu);
            this.tongquat.Controls.Add(this.btnthem);
            this.tongquat.Controls.Add(this.btncapnhat);
            this.tongquat.Controls.Add(this.btnthoat);
            this.tongquat.Controls.Add(this.btnxoa);
            this.tongquat.Location = new System.Drawing.Point(3, -1);
            this.tongquat.Name = "tongquat";
            this.tongquat.Size = new System.Drawing.Size(1334, 683);
            this.tongquat.TabIndex = 22;
            this.tongquat.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dscv);
            this.groupBox1.Location = new System.Drawing.Point(9, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 438);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách công việc";
            // 
            // dscv
            // 
            this.dscv.AllowUserToAddRows = false;
            this.dscv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dscv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dscv.Location = new System.Drawing.Point(6, 20);
            this.dscv.Name = "dscv";
            this.dscv.RowHeadersWidth = 51;
            this.dscv.RowTemplate.Height = 24;
            this.dscv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dscv.Size = new System.Drawing.Size(383, 412);
            this.dscv.TabIndex = 2;
            this.dscv.Click += new System.EventHandler(this.dscv_Click);
            this.dscv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dscv_KeyDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(623, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnphancong
            // 
            this.btnphancong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnphancong.Location = new System.Drawing.Point(688, 633);
            this.btnphancong.Name = "btnphancong";
            this.btnphancong.Size = new System.Drawing.Size(183, 30);
            this.btnphancong.TabIndex = 23;
            this.btnphancong.Text = "Phân công";
            this.btnphancong.UseVisualStyleBackColor = true;
            this.btnphancong.Click += new System.EventHandler(this.btnphancong_Click);
            // 
            // btnchinhsuaphancong
            // 
            this.btnchinhsuaphancong.Enabled = false;
            this.btnchinhsuaphancong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchinhsuaphancong.Location = new System.Drawing.Point(467, 633);
            this.btnchinhsuaphancong.Name = "btnchinhsuaphancong";
            this.btnchinhsuaphancong.Size = new System.Drawing.Size(183, 30);
            this.btnchinhsuaphancong.TabIndex = 24;
            this.btnchinhsuaphancong.Text = "Chỉnh sửa phân công";
            this.btnchinhsuaphancong.UseVisualStyleBackColor = true;
            this.btnchinhsuaphancong.Click += new System.EventHandler(this.btnchinhsuaphancong_Click);
            // 
            // FormCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 694);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tongquat);
            this.Name = "FormCongViec";
            this.Text = "FormCongViec";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCongViec_FormClosing);
            this.Load += new System.EventHandler(this.FormCongViec_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsnv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsdpc)).EndInit();
            this.tongquat.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dscv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DateTimePicker dtpthoihan;
        private System.Windows.Forms.TextBox tbotencv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbomacv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbotennv;
        private System.Windows.Forms.TextBox tbobophan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dsnv;
        private System.Windows.Forms.DataGridView dsdpc;
        private System.Windows.Forms.GroupBox tongquat;
        private System.Windows.Forms.TextBox tbomanv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbotuychonchiase;
        private System.Windows.Forms.Button btnphancong;
        private System.Windows.Forms.Button btnchinhsuaphancong;
        private System.Windows.Forms.ComboBox cbotrangthai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dscv;
    }
}