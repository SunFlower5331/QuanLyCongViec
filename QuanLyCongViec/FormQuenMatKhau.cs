using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongViec
{
    public partial class FormQuenMatKhau : Form
    {
        public FormQuenMatKhau()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Show();
            this.Hide();
        }

        private void FormQuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        // Dùng để kéo thả cửa sổ
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FormQuenMatKhau_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //
        private void user_Enter(object sender, EventArgs e)
        {
            if (email.Text == "Example@email.com")
            {
                email.Text = "";
                email.ForeColor = Color.LightGray;
            }
        }

        private void user_Leave(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                email.Text = "Example@email.com";
                email.ForeColor = Color.DimGray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (email != null)
            {
                string mk = DatabaseAccess.getMK(email.Text);
                if (mk != null)
                {
                    guiEmail(email.Text, "Mật khẩu của bạn là - My password is : " + mk);
                }
              
            }
        }
        private void guiEmail(string to,string content)
        {
            string from, pass;
            from = "zantlytm@gmail.com";
            pass = "rxaypqcmtmtxerbq";
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(to);
                mail.From = new MailAddress(from);
                mail.Subject = "GỬI LẠI MẬT KHẨU -RESEND PASSWORD ";
                mail.Body = content;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(mail);

                    MessageBox.Show("Mật khẩu đã được gửi vào mail của bạn. Vui lòng kiểm tra lại email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormLogin f = new FormLogin();
                    f.Show();
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi Cacth, không gửi đc");
                }
            }
            catch
            {
                MessageBox.Show("Sai email hoặc không được bỏ trống!              ","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            FormLogin f=new FormLogin();
            f.Show();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}

