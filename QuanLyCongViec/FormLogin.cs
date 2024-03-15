using System;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using DTO;
using System.Runtime.InteropServices;


namespace QuanLyCongViec
{
    public partial class FormLogin : Form
    {
        TaiKhoan tk = new TaiKhoan();
        TaiKhoanBLL tkBLL= new TaiKhoanBLL();
        public FormLogin()
        {
            InitializeComponent();
        }
        // Dùng để kéo thả cửa sổ
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // check xem nếu checkbox đã được đánh hoặc để mặc định 
            if (checkBoxHTMK.Checked || pass.Text == "Password")
            {
                pass.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar = true;
            }
        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
           


        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxHTMK_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxHTMK.Checked || pass.Text == "Password")
            {
                pass.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar = true;

            }
        }

        private void dangnhap_Click_1(object sender, EventArgs e)
        {
            if (CheckLogin())
            {
                
                FormMain fm=new FormMain();
                fm.Show();
                this.Hide();
                fm.logout += Fm_logout;
                
            }
            
        }

        private void Fm_logout(object sender, EventArgs e)
        {
            (sender as FormMain).isExit = false;
            (sender as FormMain).Close();
            this.Show();
        }

        private bool CheckLogin()
        {
            tk.id = user.Text;
            tk.mk = pass.Text;
            string getUser = tkBLL.CheckLogic(tk);
            switch (getUser)
            {
                case "Require_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống");
                    return false;
                case "Require_matkhau":
                    MessageBox.Show("Tài khoản không được để trống");
                    return false;
                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                    return false;
            }
            Program.UserID = tk.id;
            return true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void matkhau_Click(object sender, EventArgs e)
        {

        }

        private void ngonngu_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ngonngu.SelectedIndex = 0;

        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void taikhoan_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // tạo event khi người dùng focus vào ô thì mấy placeholder sẽ biến mất
        private void user_Enter(object sender, EventArgs e)
        {
            if (user.Text == "User ID")
            {
                user.Text = "";
                user.ForeColor = Color.LightGray;
            }
        }
        private void pass_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "Password")
            {
                pass.Text = "";
                pass.ForeColor = Color.LightGray;
            }
        }

        // tạo event khi người dùng rời khỏi ô thì placeholder hiện lại
        private void user_Leave(object sender, EventArgs e)
        {
            if (user.Text == "")
            {
                user.Text = "User ID";
                user.ForeColor = Color.DimGray;
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                pass.Text = "Password";
                pass.ForeColor = Color.DimGray;
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void quenPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        // Dùng để kéo thả cửa sổ
        private void buttonOut_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
