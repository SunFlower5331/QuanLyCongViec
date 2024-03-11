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
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.checkBoxHTMK = new System.Windows.Forms.CheckBox();
            this.dangnhap = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.buttonOut = new System.Windows.Forms.PictureBox();
            this.ngonngu = new System.Windows.Forms.ComboBox();
            this.underlineUser = new System.Windows.Forms.Label();
            this.underlinePass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.quenPass = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.buttonOut)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.DimGray;
            this.user.Location = new System.Drawing.Point(324, 113);
            this.user.Margin = new System.Windows.Forms.Padding(2);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(398, 20);
            this.user.TabIndex = 1;
            this.user.Text = "User ID";
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            this.user.Enter += new System.EventHandler(this.user_Enter);
            this.user.Leave += new System.EventHandler(this.user_Leave);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.DimGray;
            this.pass.Location = new System.Drawing.Point(322, 177);
            this.pass.Margin = new System.Windows.Forms.Padding(2);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(400, 22);
            this.pass.TabIndex = 2;
            this.pass.Text = "Password";
            this.pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.pass.Enter += new System.EventHandler(this.pass_Enter);
            this.pass.Leave += new System.EventHandler(this.pass_Leave);
            // 
            // checkBoxHTMK
            // 
            this.checkBoxHTMK.AutoSize = true;
            this.checkBoxHTMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.checkBoxHTMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHTMK.ForeColor = System.Drawing.Color.Silver;
            this.checkBoxHTMK.Location = new System.Drawing.Point(322, 213);
            this.checkBoxHTMK.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxHTMK.Name = "checkBoxHTMK";
            this.checkBoxHTMK.Size = new System.Drawing.Size(109, 17);
            this.checkBoxHTMK.TabIndex = 3;
            this.checkBoxHTMK.Text = "Hiển thị mật khẩu";
            this.checkBoxHTMK.UseVisualStyleBackColor = false;
            this.checkBoxHTMK.CheckedChanged += new System.EventHandler(this.checkBoxHTMK_CheckedChanged);
            // 
            // dangnhap
            // 
            this.dangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dangnhap.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap.ForeColor = System.Drawing.Color.Firebrick;
            this.dangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dangnhap.Location = new System.Drawing.Point(324, 254);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(400, 32);
            this.dangnhap.TabIndex = 4;
            this.dangnhap.Text = "   Đăng nhập";
            this.dangnhap.UseVisualStyleBackColor = false;
            this.dangnhap.Click += new System.EventHandler(this.dangnhap_Click_1);
            // 
            // buttonOut
            // 
            this.buttonOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonOut.Location = new System.Drawing.Point(-35, -46);
            this.buttonOut.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(866, 532);
            this.buttonOut.TabIndex = 10;
            this.buttonOut.TabStop = false;
            this.buttonOut.Click += new System.EventHandler(this.pictureBox1_Click);
            this.buttonOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonOut_MouseDown);
            // 
            // ngonngu
            // 
            this.ngonngu.AllowDrop = true;
            this.ngonngu.FormattingEnabled = true;
            this.ngonngu.Items.AddRange(new object[] {
            "Vietnamese",
            "English"});
            this.ngonngu.Location = new System.Drawing.Point(642, 320);
            this.ngonngu.Margin = new System.Windows.Forms.Padding(2);
            this.ngonngu.Name = "ngonngu";
            this.ngonngu.Size = new System.Drawing.Size(80, 21);
            this.ngonngu.TabIndex = 5;
            this.ngonngu.SelectedIndexChanged += new System.EventHandler(this.ngonngu_SelectedIndexChanged);
            // 
            // underlineUser
            // 
            this.underlineUser.BackColor = System.Drawing.Color.Black;
            this.underlineUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.underlineUser.Location = new System.Drawing.Point(322, 136);
            this.underlineUser.Name = "underlineUser";
            this.underlineUser.Size = new System.Drawing.Size(400, 2);
            this.underlineUser.TabIndex = 12;
            // 
            // underlinePass
            // 
            this.underlinePass.BackColor = System.Drawing.Color.IndianRed;
            this.underlinePass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.underlinePass.Location = new System.Drawing.Point(322, 199);
            this.underlinePass.Name = "underlinePass";
            this.underlinePass.Size = new System.Drawing.Size(400, 2);
            this.underlinePass.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(416, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "TasMana";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.label2.Location = new System.Drawing.Point(545, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ver.0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 377);
            this.panel1.TabIndex = 16;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(90, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(720, 5);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(25, 25);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logout.TabIndex = 17;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(685, 5);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 18;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // quenPass
            // 
            this.quenPass.ActiveLinkColor = System.Drawing.Color.Firebrick;
            this.quenPass.AutoSize = true;
            this.quenPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.quenPass.LinkColor = System.Drawing.Color.DimGray;
            this.quenPass.Location = new System.Drawing.Point(475, 301);
            this.quenPass.Name = "quenPass";
            this.quenPass.Size = new System.Drawing.Size(106, 13);
            this.quenPass.TabIndex = 0;
            this.quenPass.TabStop = true;
            this.quenPass.Text = "Bạn quên mật khẩu?";
            this.quenPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.quenPass_LinkClicked);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 376);
            this.Controls.Add(this.quenPass);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.underlinePass);
            this.Controls.Add(this.underlineUser);
            this.Controls.Add(this.ngonngu);
            this.Controls.Add(this.dangnhap);
            this.Controls.Add(this.checkBoxHTMK);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.buttonOut);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonOut)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.CheckBox checkBoxHTMK;
        private System.Windows.Forms.Button dangnhap;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ComboBox ngonngu;
        private System.Windows.Forms.Label underlineUser;
        private System.Windows.Forms.Label underlinePass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.PictureBox buttonOut;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.LinkLabel quenPass;
    }
}

