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
            menuStrip2.Renderer = new MyRenderer();

        }

        private void thongbaocv()
        {
            if (DatabaseAccess.getSLCV() >= 5 && DatabaseAccess.getUserQuyen(Program.UserID) == 1)
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
        public void UpdateNotification(int numberOfTasks, int slsaphethan)
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

            dscvpban.DataSource = DatabaseAccess.GetCTCVPban(Program.getUserIDPB()).Tables[0];
            dscvpban.AutoGenerateColumns = false;
            dscvpban.Columns["phongban"].HeaderText = "Phòng ban";
            dscvpban.Columns["chucvu"].HeaderText = "Chức vụ";
            dscvpban.Columns["maCV"].HeaderText = "Mã công việc";
            dscvpban.Columns["ten"].HeaderText = "Tên công việc";
            dscvpban.Columns["maNV"].HeaderText = "Mã nhân viên";
            dscvpban.Columns["hoten"].HeaderText = "Tên nhân viên";

            dscvpban.Columns["trangthai"].HeaderText = "Trạng thái";
            dscvpban.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
            dscvpban.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";

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

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
            this.Hide();


        }


        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTinCaNhan f = new FormThongTinCaNhan();
            f.Show();
            this.Hide();


        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
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

        private void gửiThôngBáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGuiThongBao form = new FormGuiThongBao();
            form.Show();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            checkQuyen();
            loadCTCVCty();
            loadCTCVPban();

        }

        private void checkQuyen()
        {
            string id = Program.UserID;
            int quyen = DatabaseAccess.getUserQuyen(id);
            if (quyen == 2)
            {
                thongbaocvnv();
                ToolStripMenuItem quanliMenuItem = (ToolStripMenuItem)menuStrip2.Items["quanly"];
                ToolStripDropDownItem congviecMenuItem = (ToolStripDropDownItem)quanliMenuItem.DropDownItems["congviec"];
                ToolStripDropDownItem dulieunhanvienMenuItem = (ToolStripDropDownItem)quanliMenuItem.DropDownItems["dulieunhanvien"];
                congviecMenuItem.Enabled = false;
                dulieunhanvien.Enabled = false;

            }
            else if (quyen == 3)
            {
                thongbaocv();
                thongbaocvnv();
                ToolStripMenuItem quanliMenuItem = (ToolStripMenuItem)menuStrip2.Items["quanly"];
                ToolStripDropDownItem congviecMenuItem = (ToolStripDropDownItem)quanliMenuItem.DropDownItems["congviec"];
                ToolStripDropDownItem dulieunhanvienMenuItem = (ToolStripDropDownItem)quanliMenuItem.DropDownItems["dulieunhanvien"];
                congviecMenuItem.Enabled = false;
                dulieunhanvien.Enabled = false;


            }
            else if (quyen == 1)
            {
                thongbaocv();

            }

        }

        private void UpdateLanguage()
        {
            // Lấy ngôn ngữ đã chọn từ biến global hoặc một cơ chế khác
            string selectedLanguage = GlobalSettings.Language;
            // Cập nhật ngôn ngữ cho các thành phần giao diện dựa trên ngôn ngữ đã chọn
            if (selectedLanguage == "Vietnamese")
            {
                tabControl1.TabPages[0].Text = "Công ty";
                tabControl1.TabPages[1].Text = "Phòng ban";
                groupBox1.Text = "Tìm kiếm";
                label1.Text = "Danh sách công việc";
                hethong.Text = "Hệ thống";
                thêmToolStripMenuItem.Text = "Thông tin cá nhân";
                quanly.Text = "Quản lý";
                thongke.Text = "Thống kê";
                đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
                dulieunhanvien.Text = "Dữ liệu nhân viên";
                trogiup.Text = "Ngôn ngữ";
                tacvu.Text = "Tác vụ";
                chưaHoànThànhToolStripMenuItem.Text = "Báo cáo công việc";
                côngViệcToolStripMenuItem1.Text = "Kết quả công việc";
                englishToolStripMenuItem.Text = "Tiếng Anh";
                vietnamToolStripMenuItem.Text = "Tiếng Việt";
                tiendocongviec.Text = "Tiến độ công việc cá nhân";
                dulieucudan.Text = "Dữ liệu cư dân";
                congviec.Text = "Công việc";
                nhậpXuấtToolStripMenuItem.Text = "Upload/ Download tài liệu";
                hiệuQuảCôngViệcToolStripMenuItem.Text = "Hiệu Quả Công Việc";
                gửiThôngBáoToolStripMenuItem.Text = "Gửi Thông Báo";

                dscvcty.Columns["phongban"].HeaderText = "Phòng ban";
                dscvcty.Columns["chucvu"].HeaderText = "Chức vụ";
                dscvcty.Columns["maCV"].HeaderText = "Mã công việc";
                dscvcty.Columns["ten"].HeaderText = "Tên công việc";
                dscvcty.Columns["maNV"].HeaderText = "Mã nhân viên";
                dscvcty.Columns["hoten"].HeaderText = "Tên nhân viên";
                dscvcty.Columns["trangthai"].HeaderText = "Trạng thái";
                dscvcty.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
                dscvcty.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";

                // DataGridView trong tabPage2
                dscvpban.Columns["phongban"].HeaderText = "Phòng ban";
                dscvpban.Columns["chucvu"].HeaderText = "Chức vụ";
                dscvpban.Columns["maCV"].HeaderText = "Mã công việc";
                dscvpban.Columns["ten"].HeaderText = "Tên công việc";
                dscvpban.Columns["maNV"].HeaderText = "Mã nhân viên";
                dscvpban.Columns["hoten"].HeaderText = "Tên nhân viên";
                dscvpban.Columns["trangthai"].HeaderText = "Trạng thái";
                dscvpban.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
                dscvpban.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";

            }
            else if (selectedLanguage == "English")
            {
                tabControl1.TabPages[0].Text = "Company";
                tabControl1.TabPages[1].Text = "Department";
                groupBox1.Text = "Search";
                label1.Text = "Work list";
                hethong.Text = "System";
                thêmToolStripMenuItem.Text = "Personal information";
                quanly.Text = "Manage";
                thongke.Text = "Statistics";
                đăngXuấtToolStripMenuItem.Text = "Log out";
                dulieunhanvien.Text = "Employee Data";
                trogiup.Text = "Language";
                tacvu.Text = "Tasks";
                chưaHoànThànhToolStripMenuItem.Text = "Work report";
                côngViệcToolStripMenuItem1.Text = "Tasks result";
                englishToolStripMenuItem.Text = "English";
                vietnamToolStripMenuItem.Text = "Vietnamese";
                tiendocongviec.Text = "Personal work progress";
                dulieucudan.Text = "Resident Data";
                congviec.Text = "Tasks";
                nhậpXuấtToolStripMenuItem.Text = "Upload/Download documents";
                hiệuQuảCôngViệcToolStripMenuItem.Text = "Task Efficiency";
                gửiThôngBáoToolStripMenuItem.Text = "Send Notification";
                // Cập nhật các thành phần khác tương ứng nếu cần

                dscvcty.Columns["phongban"].HeaderText = "Department";
                dscvcty.Columns["chucvu"].HeaderText = "Position";
                dscvcty.Columns["maCV"].HeaderText = "Task ID";
                dscvcty.Columns["ten"].HeaderText = "Task Name";
                dscvcty.Columns["maNV"].HeaderText = "Employee ID";
                dscvcty.Columns["hoten"].HeaderText = "Employee Name";
                dscvcty.Columns["trangthai"].HeaderText = "Status";
                dscvcty.Columns["thoiGianHoanThanh"].HeaderText = "Completion Time";
                dscvcty.Columns["Tuychonchiase"].HeaderText = "Sharing Options";

                // DataGridView trong tabPage2
                dscvpban.Columns["phongban"].HeaderText = "Department";
                dscvpban.Columns["chucvu"].HeaderText = "Position";
                dscvpban.Columns["maCV"].HeaderText = "Task ID";
                dscvpban.Columns["ten"].HeaderText = "Task Name";
                dscvpban.Columns["maNV"].HeaderText = "Employee ID";
                dscvpban.Columns["hoten"].HeaderText = "Employee Name";
                dscvpban.Columns["trangthai"].HeaderText = "Status";
                dscvpban.Columns["thoiGianHoanThanh"].HeaderText = "Completion Time";
                dscvpban.Columns["Tuychonchiase"].HeaderText = "Sharing Options";


            }
        }

        private void trogiup_Click(object sender, EventArgs e)
        {

        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalSettings.Language = "English"; // Cập nhật ngôn ngữ thành tiếng Anh
            UpdateLanguage();
        }

        private void vietnamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalSettings.Language = "Vietnamese"; // Cập nhật ngôn ngữ thành tiếng Việt
            UpdateLanguage();
        }

    }
}