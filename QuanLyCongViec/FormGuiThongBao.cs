using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
        }
        private void guiEmail(string to, string content)
        {
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
                    MessageBox.Show("Đã gửi mail thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi Cacth, không gửi đc");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
    }
}
