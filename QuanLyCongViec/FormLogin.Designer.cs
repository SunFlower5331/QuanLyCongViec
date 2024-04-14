using System;
using System.Windows.Forms;

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
            this.ngonngu = new System.Windows.Forms.ComboBox();
            this.underlineUser = new System.Windows.Forms.Label();
            this.underlinePass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quenPass = new System.Windows.Forms.LinkLabel();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.PictureBox();
            this.loginForm = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginForm)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.White;
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.DimGray;
            this.user.Location = new System.Drawing.Point(39, 160);
            this.user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(375, 23);
            this.user.TabIndex = 1;
            this.user.Text = "User ID";
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            this.user.Enter += new System.EventHandler(this.user_Enter);
            this.user.Leave += new System.EventHandler(this.user_Leave);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.White;
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.DimGray;
            this.pass.Location = new System.Drawing.Point(39, 236);
            this.pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(375, 27);
            this.pass.TabIndex = 2;
            this.pass.Text = "Password";
            this.pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.pass.Enter += new System.EventHandler(this.pass_Enter);
            this.pass.Leave += new System.EventHandler(this.pass_Leave);
            // 
            // checkBoxHTMK
            // 
            this.checkBoxHTMK.AutoSize = true;
            this.checkBoxHTMK.BackColor = System.Drawing.Color.White;
            this.checkBoxHTMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHTMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.checkBoxHTMK.Location = new System.Drawing.Point(39, 279);
            this.checkBoxHTMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxHTMK.Name = "checkBoxHTMK";
            this.checkBoxHTMK.Size = new System.Drawing.Size(124, 20);
            this.checkBoxHTMK.TabIndex = 3;
            this.checkBoxHTMK.Text = "Show password";
            this.checkBoxHTMK.UseVisualStyleBackColor = false;
            this.checkBoxHTMK.CheckedChanged += new System.EventHandler(this.checkBoxHTMK_CheckedChanged);
            // 
            // dangnhap
            // 
            this.dangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap.ForeColor = System.Drawing.Color.White;
            this.dangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dangnhap.Location = new System.Drawing.Point(36, 321);
            this.dangnhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(377, 49);
            this.dangnhap.TabIndex = 4;
            this.dangnhap.Text = "Login";
            this.dangnhap.UseVisualStyleBackColor = false;
            this.dangnhap.Click += new System.EventHandler(this.dangnhap_Click_1);
            // 
            // ngonngu
            // 
            this.ngonngu.AllowDrop = true;
            this.ngonngu.FormattingEnabled = true;
            this.ngonngu.Items.AddRange(new object[] {
            "Vietnamese",
            "English"});
            this.ngonngu.Location = new System.Drawing.Point(307, 384);
            this.ngonngu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngonngu.Name = "ngonngu";
            this.ngonngu.Size = new System.Drawing.Size(105, 24);
            this.ngonngu.TabIndex = 5;
            // 
            // underlineUser
            // 
            this.underlineUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.underlineUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.underlineUser.Location = new System.Drawing.Point(36, 188);
            this.underlineUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.underlineUser.Name = "underlineUser";
            this.underlineUser.Size = new System.Drawing.Size(377, 2);
            this.underlineUser.TabIndex = 12;
            // 
            // underlinePass
            // 
            this.underlinePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.underlinePass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.underlinePass.Location = new System.Drawing.Point(39, 263);
            this.underlinePass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.underlinePass.Name = "underlinePass";
            this.underlinePass.Size = new System.Drawing.Size(375, 2);
            this.underlinePass.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(201)))), ((int)(((byte)(5)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(264, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 54);
            this.label1.TabIndex = 14;
            this.label1.Text = "TasMana!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // quenPass
            // 
            this.quenPass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.quenPass.AutoSize = true;
            this.quenPass.BackColor = System.Drawing.Color.White;
            this.quenPass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.quenPass.Location = new System.Drawing.Point(303, 281);
            this.quenPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quenPass.Name = "quenPass";
            this.quenPass.Size = new System.Drawing.Size(108, 16);
            this.quenPass.TabIndex = 0;
            this.quenPass.TabStop = true;
            this.quenPass.Text = "Forget password";
            this.quenPass.VisitedLinkColor = System.Drawing.Color.DarkMagenta;
            this.quenPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.quenPass_LinkClicked);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(201)))), ((int)(((byte)(5)))));
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(913, 6);
            this.minimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(33, 31);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 18;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(201)))), ((int)(((byte)(5)))));
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(960, 6);
            this.logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(33, 31);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logout.TabIndex = 17;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // loginForm
            // 
            this.loginForm.BackColor = System.Drawing.Color.White;
            this.loginForm.Location = new System.Drawing.Point(-47, -57);
            this.loginForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginForm.Name = "loginForm";
            this.loginForm.Size = new System.Drawing.Size(1155, 655);
            this.loginForm.TabIndex = 10;
            this.loginForm.TabStop = false;
            this.loginForm.Click += new System.EventHandler(this.loginForm_Click);
            this.loginForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonOut_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(27, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 48);
            this.label3.TabIndex = 20;
            this.label3.Text = "Sign In";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(201)))), ((int)(((byte)(5)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(453, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 465);
            this.panel1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(192, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 54);
            this.label5.TabIndex = 41;
            this.label5.Text = "To";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(271, 320);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 2);
            this.label2.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 54);
            this.label4.TabIndex = 40;
            this.label4.Text = "Welcome Back";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(264, 329);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "BCMP - BEST CM PARTNER";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(64, 246);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(309, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "\"Changing the Face can change nothing,";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(64, 274);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(367, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = " But Facing the Change can change everything.\"";
            // 
            // FormLogin
            // 
            this.AcceptButton = this.dangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 463);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.quenPass);
            this.Controls.Add(this.underlinePass);
            this.Controls.Add(this.underlineUser);
            this.Controls.Add(this.ngonngu);
            this.Controls.Add(this.dangnhap);
            this.Controls.Add(this.checkBoxHTMK);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.loginForm);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginForm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.PictureBox loginForm;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.LinkLabel quenPass;
        private Label label3;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label4;
        private Label label2;
        private Label label5;
    }
}

