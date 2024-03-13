namespace QuanLyCongViec
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.taikhoan = new System.Windows.Forms.Label();
            this.matkhau = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.checkBoxHTMK = new System.Windows.Forms.CheckBox();
            this.dangnhap = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ngonngu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // taikhoan
            // 
            this.taikhoan.AutoSize = true;
            this.taikhoan.BackColor = System.Drawing.Color.Transparent;
            this.taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taikhoan.ForeColor = System.Drawing.Color.Black;
            this.taikhoan.Location = new System.Drawing.Point(667, 201);
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Size = new System.Drawing.Size(108, 25);
            this.taikhoan.TabIndex = 0;
            this.taikhoan.Text = "Tài khoản";
            // 
            // matkhau
            // 
            this.matkhau.AutoSize = true;
            this.matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhau.Location = new System.Drawing.Point(667, 278);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(101, 25);
            this.matkhau.TabIndex = 1;
            this.matkhau.Text = "Mật khẩu";
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(790, 192);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(302, 34);
            this.user.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(790, 269);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(302, 34);
            this.pass.TabIndex = 3;
            this.pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // checkBoxHTMK
            // 
            this.checkBoxHTMK.AutoSize = true;
            this.checkBoxHTMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHTMK.Location = new System.Drawing.Point(790, 333);
            this.checkBoxHTMK.Name = "checkBoxHTMK";
            this.checkBoxHTMK.Size = new System.Drawing.Size(130, 20);
            this.checkBoxHTMK.TabIndex = 4;
            this.checkBoxHTMK.Text = "Hiển thị mật khẩu";
            this.checkBoxHTMK.UseVisualStyleBackColor = true;
            this.checkBoxHTMK.CheckedChanged += new System.EventHandler(this.checkBoxHTMK_CheckedChanged);
            // 
            // dangnhap
            // 
            this.dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap.Image = ((System.Drawing.Image)(resources.GetObject("dangnhap.Image")));
            this.dangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dangnhap.Location = new System.Drawing.Point(783, 382);
            this.dangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(154, 40);
            this.dangnhap.TabIndex = 8;
            this.dangnhap.Text = "   Đăng nhập";
            this.dangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dangnhap.UseVisualStyleBackColor = true;
            this.dangnhap.Click += new System.EventHandler(this.dangnhap_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1106, 591);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ngonngu
            // 
            this.ngonngu.AllowDrop = true;
            this.ngonngu.FormattingEnabled = true;
            this.ngonngu.Items.AddRange(new object[] {
            "Vietnamese",
            "English"});
            this.ngonngu.Location = new System.Drawing.Point(987, 514);
            this.ngonngu.Name = "ngonngu";
            this.ngonngu.Size = new System.Drawing.Size(105, 24);
            this.ngonngu.TabIndex = 11;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 591);
            this.Controls.Add(this.ngonngu);
            this.Controls.Add(this.dangnhap);
            this.Controls.Add(this.checkBoxHTMK);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.taikhoan);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taikhoan;
        private System.Windows.Forms.Label matkhau;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.CheckBox checkBoxHTMK;
        private System.Windows.Forms.Button dangnhap;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ngonngu;
    }
}

