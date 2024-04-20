using System;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using DTO;
using System.Runtime.InteropServices;
using DAL;


namespace QuanLyCongViec
{
    public partial class FormLogin : Form
    {
        TaiKhoan tk = new TaiKhoan();
        TaiKhoanBLL tkBLL= new TaiKhoanBLL();
        public FormLogin()
        {
            InitializeComponent();
            //minimize.Parent = logout.Parent = panel1;
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
                FormMain fm = new FormMain();
                fm.Show();
                this.Hide();
               
            }
                
           
            
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
            string trangthai = DatabaseAccess.getloaihinh(tk.id);
            if (string.Equals(trangthai, "Đã nghĩ việc", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Bạn không có quyền truy cập vào ứng dụng!");
                return false;
            }

            return true;
        }






        private void FormLogin_Load(object sender, EventArgs e)
        {
            ngonngu.SelectedIndex = 0;

        }
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (e.CloseReason == CloseReason.UserClosing)
            {
              
                DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

              
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                   
                    e.Cancel = true;
                }
            }
        }

       
        private void user_Enter(object sender, EventArgs e)
        {
            if (user.Text == "ID tài khoản")
            {
                user.Text = "";
                user.ForeColor = Color.Black;
            }
        }
        private void pass_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "Mật khẩu")
            {
                pass.Text = "";
                pass.ForeColor = Color.Black;
            }
        }

      
        private void user_Leave(object sender, EventArgs e)
        {
            if (user.Text == "")
            {
                user.Text = "ID tài khoản";
                user.ForeColor = Color.DimGray;
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                pass.Text = "Mật khẩu";
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

      
        private void buttonOut_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void quenPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormQuenMatKhau form = new FormQuenMatKhau();
            form.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginForm_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
