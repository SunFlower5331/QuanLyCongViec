using System;
using System.Windows.Forms;
using BLL;
using DTO;
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
     


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pass.UseSystemPasswordChar = true;
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
            if(checkBoxHTMK.Checked)
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
            return true;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ngonngu.SelectedIndex = 0;

        }
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra nếu người dùng chọn đóng cửa sổ bằng nút "X" (nút đóng cửa sổ)
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Nếu người dùng chọn "Có", đóng chương trình
                if (result == DialogResult.Yes)
                {
                    // Đóng chương trình
                    Application.Exit();
                }
                else
                {
                    // Hủy sự kiện đóng cửa sổ
                    e.Cancel = true;
                }
            }
        }
    }
}
