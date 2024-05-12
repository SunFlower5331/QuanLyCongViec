using DAL;
using DTO;
using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QuanLyCongViec
{
    public partial class FormQuenMatKhau : Form
    {
        public FormQuenMatKhau()
        {
            InitializeComponent();
            
        }

 

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Show();
            this.Hide();
        }

        private void FormQuenMatKhau_Load(object sender, EventArgs e)
        {
            UpdateLanguage(); 
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


        private void button1_Click(object sender, EventArgs e)
        {
            if (email != null)
            {
                string mk = DatabaseAccess.getMK(email.Text);
                if (mk != null)
                {
                    guiEmail(email.Text, "Mật khẩu của bạn là: " + mk);
                }
              
            }
        }
        private void guiEmail(string to,string content)
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
                mail.Subject = "GỬI LẠI MẬT KHẨU ";
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
                        MessageBox.Show("Mật khẩu đã được gửi vào mail của bạn. Vui lòng kiểm tra lại email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("Password has been sent to your email. Please check your email again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    FormLogin f = new FormLogin();
                    f.Show();
                    this.Close();
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
                    MessageBox.Show("Lỗi Cacth, không gửi đc");
                }
            }
            catch
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Sai email hoặc không được bỏ trống!              ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("Wrong email or cannot be left blank! ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            FormLogin f=new FormLogin();
            f.Show();
        }

      
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void UpdateLanguage()
        {

            // Lấy ngôn ngữ đã chọn từ biến global hoặc một cơ chế khác
            string selectedLanguage = GlobalSettings.Language;

            // Cập nhật ngôn ngữ cho các thành phần giao diện dựa trên ngôn ngữ đã chọn
            if (selectedLanguage == "Vietnamese")
            {
                label1.Text = "Quên mật khẩu";
                button1.Text = "Lấy mật khẩu";

                linkLabel1.Text = "Quay lại đăng nhập";
                email.Text = "Nhập email";
            }
            else if (selectedLanguage == "English")
            {
                label1.Text = "Forgot Password";
                button1.Text = "Get password";

                linkLabel1.Text = "Back to Sign in";
                email.Text = "Enter Email";
            }
        }
    
        private void email_Leave(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                email.Text = "Nhập email";
                email.ForeColor = Color.DimGray;
            }
        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (email.Text == "Nhập email")
            {
                email.Text = "";
                email.ForeColor = Color.LightGray;
            }
        }
    }
            

}

