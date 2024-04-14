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
            InitializeNotifyIcon();
            InitializeComponent();
            this.Resize += new EventHandler(FormMain_Resize);
            menuStrip2.Renderer = new MyRenderer();
            thongbaocv();
            thongbaocvnv();

            
        }

        private void thongbaocv()
        {
            if (DatabaseAccess.getSLCV() >= 5 && DatabaseAccess.getUserQuyen(Program.UserID)==1)
            {
                ShowNotification("Có quá nhiều công việc chưa được nhân viên cập nhật!");
            }

        }
        private void thongbaocvnv()
        {
            string manv = Program.UserID;
            if (DatabaseAccess.getUserQuyen(manv) != 1)
            {
                UpdateNotification(DatabaseAccess.getSLCVNV(manv), DatabaseAccess.getSLCVSapHetHan(manv));
            }
        }
        private void InitializeNotifyIcon()
        {
            notifyIcon1 = new NotifyIcon();
            notifyIcon1.Icon = SystemIcons.Information; 
            notifyIcon1.Visible = true;
            notifyIcon1.DoubleClick += NotifyIcon_DoubleClick; 
        }
        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
        public void ShowNotification(string message)
        {
            notifyIcon1.BalloonTipText = message;
            notifyIcon1.ShowBalloonTip(5000);
        }

        // Sử dụng phương thức này để cập nhật thông báo
        public void UpdateNotification(int numberOfTasks,int slsaphethan)
        {
            if (numberOfTasks > 0)
            {
                ShowNotification($"Bạn có {numberOfTasks} công việc chưa cập nhật. Và có {slsaphethan} công việc sắp hết hạn ");
            }
            else
            {
             
                notifyIcon1.Visible = false;
            }
        }
        private void loadCTCVCty()
        {
            dscvcty.DataSource = DatabaseAccess.GetCTCVCty().Tables[0];
            dscvcty.AutoGenerateColumns = false;
            dscvcty.Columns["phongban"].HeaderText = "Phòng ban";
            dscvcty.Columns["chucvu"].HeaderText = "Chức vụ";
            dscvcty.Columns["maCV"].HeaderText = "Mã công việc";
            dscvcty.Columns["ten"].HeaderText = "Tên công việc";
            dscvcty.Columns["maNV"].HeaderText = "Mã nhân viên";
            dscvcty.Columns["hoten"].HeaderText = "Tên nhân viên";

            dscvcty.Columns["trangthai"].HeaderText = "Trạng thái";
            dscvcty.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
            dscvcty.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";

        }
        private void loadCTCVPban()
        {
            
            dscvcty.DataSource = DatabaseAccess.GetCTCVPban(Program.getUserIDPB()).Tables[0];
            dscvcty.AutoGenerateColumns = false;
            dscvcty.Columns["phongban"].HeaderText = "Phòng ban";
            dscvcty.Columns["chucvu"].HeaderText = "Chức vụ";
            dscvcty.Columns["maCV"].HeaderText = "Mã công việc";
            dscvcty.Columns["ten"].HeaderText = "Tên công việc";
            dscvcty.Columns["maNV"].HeaderText = "Mã nhân viên";
            dscvcty.Columns["hoten"].HeaderText = "Tên nhân viên";

            dscvcty.Columns["trangthai"].HeaderText = "Trạng thái";
            dscvcty.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
            dscvcty.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";

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
            groupBox1.Size = new Size(this.ClientSize.Width - groupBox1.Location.X - 10, this.ClientSize.Height - groupBox1.Location.Y - 10);
            menuStrip2.Size = new Size(this.ClientSize.Width - menuStrip2.Location.X - 10, this.ClientSize.Height - menuStrip2.Location.Y - 10);

            dscvcty.Size = new Size(this.ClientSize.Width - dscvcty.Location.X - 10, this.ClientSize.Height - dscvcty.Location.Y - 10);
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
            dscvcty.DataSource = DatabaseAccess.GetCTCVCty().Tables[0];
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            ShowPopupForm();
        }
        // Trong sự kiện button click hoặc bất kỳ sự kiện nào khác
        private void ShowPopupForm()
        {
            PopUpForm popupForm = new PopUpForm(); // Tạo một instance của form pop-up
            popupForm.TopMost = true; // Đảm bảo form luôn ở trên cùng
            popupForm.Show(); // Hiển thị form pop-up
        }




        //
    }
}
