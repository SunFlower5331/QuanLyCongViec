using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace QuanLyCongViec
{
    public partial class FormGuiThongBao : Form
    {
        public FormGuiThongBao()
        {
            InitializeComponent();
            
        }

        private void FormGuiThongBao_Load(object sender, EventArgs e)
        {
            getDsNV();
            UpdateLanguage();
        }
        private void guiEmail(string to, string content)
        {
            string selectedLanguage = GlobalSettings.Language;
            string from, pass;
            from = "zantlytm@gmail.com";
            pass = "rxaypqcmtmtxerbq";
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(to);
                mail.From = new MailAddress(from);
                mail.Subject = tieude.Text;
                mail.Body = content;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(mail);
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Đã gửi mail thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("Mail sent successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                catch (Exception)
                {
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Lỗi Cacth, không gửi đc");
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("Cacth error, unable to send");
                    }
                    
                }
            }
            catch
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Lỗi hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("System error!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }



            }


        }
        private void getDsNV()
        {
            DataTable table = DatabaseAccess.getNV();


            DataRow selectAllRow = table.NewRow();
            selectAllRow["PhongBan"] = "Chọn tất cả";
            selectAllRow["maNV"] = "";
            selectAllRow["hoten"] = "";
            table.Rows.InsertAt(selectAllRow, 0);


            DataColumn displayNameColumn = new DataColumn("DisplayName", typeof(string));
            table.Columns.Add(displayNameColumn);
            foreach (DataRow row in table.Rows)
            {

                string displayName = $"{row["PhongBan"]} - {row["maNV"]} - {row["hoten"]} - {row["email"]}";
                row["DisplayName"] = displayName;
            }


            checkedLisdsnv.DataSource = table;
            checkedLisdsnv.DisplayMember = "DisplayName";
        }
        List<string> selectedEmails = new List<string>();

        private void checkedLisdsnv_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0 )
            {
                if(e.NewValue == CheckState.Checked)
                {
                    CheckAllItems(true);
                }
                else
                {
                    CheckAllItems(false);

                }
            }
         
                DataRowView selectedRow = (DataRowView)checkedLisdsnv.Items[e.Index];
                string selectedEmail = selectedRow.Row["email"].ToString();

                if (e.NewValue == CheckState.Checked)
                {
                    selectedEmails.Add(selectedEmail);
                }
                else
                {
                    selectedEmails.Remove(selectedEmail);
                }

                email.Text = string.Join(" ", selectedEmails);
        }

        private void CheckAllItems(bool isChecked)
        {
            
            for (int i = 1; i < checkedLisdsnv.Items.Count; i++)
            {
                checkedLisdsnv.SetItemChecked(i, isChecked);
            }
        }

        private void gui_Click(object sender, EventArgs e)
        {
            guiEmail(email.Text, content.Text);
        }

        private void FormGuiThongBao_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FormMain f=new FormMain();
            f.Show();
        }
        private void UpdateLanguage()
        {
            // Lấy ngôn ngữ đã chọn từ biến global hoặc một cơ chế khác
            string selectedLanguage = GlobalSettings.Language;

            // Cập nhật ngôn ngữ cho các thành phần giao diện dựa trên ngôn ngữ đã chọn
            if (selectedLanguage == "Vietnamese")
            {
                label1.Text = "Tiêu đề:";
                label2.Text = "Nội dung:";
                label3.Text = "Email:";
                gui.Text = " Gửi";
            }
            else if (selectedLanguage == "English")
            {
                label1.Text = "Title:";
                label2.Text = "Content:";
                label3.Text = "Email:";
                gui.Text = " Send";
            }
        }
    }
}

