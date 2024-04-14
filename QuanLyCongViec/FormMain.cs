using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            menuStrip2.Renderer = new MyRenderer();
            //dscv.CellFormatting += dscv_CellFormatting;
        }

        //private void dscv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    dscv.EnableHeadersVisualStyles = false;
        //    dscv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //    foreach (DataGridViewRow row in dscv.Rows)
        //    {
        //        for (int i = 0; i < row.Cells.Count; i++)
        //        {
        //            dscv.Columns[i].HeaderCell.Style.SelectionBackColor = dscv.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(160, 0, 0);

        //            row.Cells[i].Style.BackColor = Color.White;
        //            row.Cells[i].Style.ForeColor = Color.Black;

        //        }
        //    }
        //}

        // Chỉnh sửa màu menustrip
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }
        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.FromArgb(246, 191, 2); }
            }
            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.FromArgb(175, 0, 0); }
            }        
            public override Color MenuBorder 
             {
                get { return Color.Silver; }
            }
        }
        //
        private void FormMain_Resize(object sender, EventArgs e)
        {
            CenterLabel();
            //groupBox1.Size = new Size(this.ClientSize.Width - groupBox1.Location.X - 10, this.ClientSize.Height - groupBox1.Location.Y - 10);
            menuStrip2.Size = new Size(this.ClientSize.Width - menuStrip2.Location.X - 10, this.ClientSize.Height - menuStrip2.Location.Y - 10);

            dscv.Size = new Size(this.ClientSize.Width - dscv.Location.X - 10, this.ClientSize.Height - dscv.Location.Y - 10);
        }
        private void CenterLabel()
        {
            int centerX = (this.ClientSize.Width - label1.Size.Width) / 2;
            int centerY = label1.Location.Y;

            label1.Location = new Point(centerX, centerY);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
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
            FormDuLieuNhanVien f = new FormDuLieuNhanVien();
            f.Show();
            this.Hide();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tiếnĐộCôngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTienDoCongViec f = new FormTienDoCongViec();
            f.Show();
            this.Hide();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCongViec f = new FormCongViec();
            f.Show();
            this.Hide();
        }

        private void dulieucudan_Click(object sender, EventArgs e)
        {
            FormDuLieuCuDan f = f = new FormDuLieuCuDan();
            f.Show();
            this.Hide();
        }

        private void tácVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nhậpXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpload_Download form = new FormUpload_Download();
            form.Show();
            this.Hide();
        }

        private void côngViệcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormThongKeKetQuaCongViec form = new FormThongKeKetQuaCongViec();
            form.Show();
            this.Hide();
        }

        private void hiệuQuảCôngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKeHieuQuaCongViec form = new FormThongKeHieuQuaCongViec();
            form.Show();
            this.Hide();
        }

        private void chưaHoànThànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaoCao form = new FormBaoCao();
            form.Show();
            this.Hide();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Dùng để kéo thả cửa sổ
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void menuStrip2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //
    }
}
