﻿namespace QuanLyCongViec
{
    partial class FormGuiThongBao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuiThongBao));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedLisdsnv = new System.Windows.Forms.CheckedListBox();
            this.content = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.RichTextBox();
            this.tieude = new System.Windows.Forms.RichTextBox();
            this.gui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiêu đề";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(17, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nội dung";
            // 
            // checkedLisdsnv
            // 
            this.checkedLisdsnv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedLisdsnv.FormattingEnabled = true;
            this.checkedLisdsnv.Location = new System.Drawing.Point(402, 30);
            this.checkedLisdsnv.Margin = new System.Windows.Forms.Padding(2);
            this.checkedLisdsnv.Name = "checkedLisdsnv";
            this.checkedLisdsnv.Size = new System.Drawing.Size(306, 334);
            this.checkedLisdsnv.TabIndex = 4;
            this.checkedLisdsnv.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedLisdsnv_ItemCheck);
            // 
            // content
            // 
            this.content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.content.Location = new System.Drawing.Point(20, 163);
            this.content.Margin = new System.Windows.Forms.Padding(2);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(349, 265);
            this.content.TabIndex = 5;
            this.content.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(166)))));
            this.label3.Location = new System.Drawing.Point(17, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // email
            // 
            this.email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.email.Location = new System.Drawing.Point(20, 92);
            this.email.Margin = new System.Windows.Forms.Padding(2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(349, 35);
            this.email.TabIndex = 8;
            this.email.Text = "";
            // 
            // tieude
            // 
            this.tieude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tieude.Location = new System.Drawing.Point(20, 33);
            this.tieude.Margin = new System.Windows.Forms.Padding(2);
            this.tieude.Name = "tieude";
            this.tieude.Size = new System.Drawing.Size(349, 36);
            this.tieude.TabIndex = 9;
            this.tieude.Text = "";
            // 
            // gui
            // 
            this.gui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(166)))));
            this.gui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gui.ForeColor = System.Drawing.Color.White;
            this.gui.Location = new System.Drawing.Point(587, 406);
            this.gui.Margin = new System.Windows.Forms.Padding(2);
            this.gui.Name = "gui";
            this.gui.Size = new System.Drawing.Size(121, 35);
            this.gui.TabIndex = 10;
            this.gui.Text = "GỬI";
            this.gui.UseVisualStyleBackColor = false;
            this.gui.Click += new System.EventHandler(this.gui_Click);
            // 
            // FormGuiThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.gui);
            this.Controls.Add(this.tieude);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.content);
            this.Controls.Add(this.checkedLisdsnv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(639, 482);
            this.Name = "FormGuiThongBao";
            this.Text = "FormGuiThongBao";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGuiThongBao_FormClosing);
            this.Load += new System.EventHandler(this.FormGuiThongBao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedLisdsnv;
        private System.Windows.Forms.RichTextBox content;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox email;
        private System.Windows.Forms.RichTextBox tieude;
        private System.Windows.Forms.Button gui;
    }
}