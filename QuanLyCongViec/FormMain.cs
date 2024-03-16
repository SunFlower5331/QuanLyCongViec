using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
namespace QuanLyCongViec
{

    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            InitializeComponent();
            this.Resize += new EventHandler(FormMain_Resize);
        }
        private void FormMain_Resize(object sender, EventArgs e)
        {
            CenterLabel();
            groupBox1.Size = new Size(this.ClientSize.Width - groupBox1.Location.X - 10, this.ClientSize.Height - groupBox1.Location.Y - 10);
            menuStrip2.Size = new Size(this.ClientSize.Width - menuStrip2.Location.X - 10, this.ClientSize.Height - menuStrip2.Location.Y - 10);
            //toolStrip1.Size = new Size(this.ClientSize.Width - toolStrip1.Location.X - 10, this.ClientSize.Height - toolStrip1.Location.Y - 10);
            dscv.Size = new Size(this.ClientSize.Width - dscv.Location.X - 10, this.ClientSize.Height - dscv.Location.Y - 10);
        }
        private void CenterLabel()
        {
            int centerX = (this.ClientSize.Width - label1.Size.Width) / 2;
            int centerY = label1.Location.Y; // Giữ nguyên vị trí theo chiều dọc

            label1.Location = new Point(centerX, centerY);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin f=new FormLogin();
            f.Show();
            this.Hide();


        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            //loadDsNv();
        }
        private void loadDsCV()
        {

            dscv.DataSource = DatabaseAccess.GetAllTK().Tables[0];
            dscv.AutoGenerateColumns = false;
            dscv.Columns["id"].HeaderText = "Tên đăng nhập";
            dscv.Columns["mk"].HeaderText = "Mật khẩu";
            dscv.Columns["loaiTK"].HeaderText = "Loại tài khoản";

        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTinCaNhan f = new FormThongTinCaNhan();
            f.Show();
            this.Hide();
            

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
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

        private void côngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDuLieu f=new FormDuLieu();
            f.Show();
            this.Hide();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
