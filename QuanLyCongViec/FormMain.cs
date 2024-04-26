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
using System.Windows.Documents;
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
            labelTongNV.Parent = labelSoNV.Parent = pictureBoxTongNV;
            c.Parent = labelSoCV.Parent = pictureBoxTongCV;
            labelHieuSuat.Parent = labelSoHieuSuat.Parent = label3.Parent = pictureBoxHieuSuat;
            labelDoanhThu.Parent = labelSoDoanhThu.Parent = pictureBoxDoanhThu;
            dscvcty.CellFormatting += dscvcty_CellFormatting;
            dscvpban.CellFormatting += dscvpban_CellFormatting;
            labelSoCV.Text = DatabaseAccess.getTongCV().ToString();
            labelSoNV.Text = DatabaseAccess.getTongNV().ToString();
            labelSoHieuSuat.Text = ((DatabaseAccess.getSoCVHoanThanh() * 100) / (DatabaseAccess.getSoCVHoanThanh() + DatabaseAccess.getSoCVKhongHoanThanh())).ToString();
            labelSoDoanhThu.Text = DatabaseAccess.getDoanhThu().ToString();
        }

        private void dscvcty_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dscvcty.EnableHeadersVisualStyles = false;
            dscvcty.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            foreach (DataGridViewRow row in dscvcty.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dscvcty.Columns[i].HeaderCell.Style.SelectionBackColor = dscvcty.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(170, 170, 255);

                    row.Cells[i].Style.BackColor = Color.White;
                    row.Cells[i].Style.ForeColor = Color.Black;

                }
            }
        }
        private void dscvpban_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dscvpban.EnableHeadersVisualStyles = false;
            dscvpban.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            foreach (DataGridViewRow row in dscvpban.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dscvpban.Columns[i].HeaderCell.Style.SelectionBackColor = dscvpban.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(170, 170, 255);

                    row.Cells[i].Style.BackColor = Color.White;
                    row.Cells[i].Style.ForeColor = Color.Black;

                }
            }
        }

        private void thongbaocv()
        {
            string selectedLanguage = GlobalSettings.Language;
            if (DatabaseAccess.getSLCV() >= 5 && DatabaseAccess.getUserQuyen(Program.UserID) == 1)
            {
                if (selectedLanguage == "Vietnamese")
                {
                    ShowNotification("Có quá nhiều công việc chưa được nhân viên cập nhật!");
                }
                else if (selectedLanguage == "English")
                {
                    ShowNotification("There are too many jobs that have not been updated by employees!");
                }

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
            string selectedLanguage = GlobalSettings.Language;

            if (numberOfTasks > 0)
            {
                if (selectedLanguage == "Vietnamese")
                {
                    ShowNotification($"Bạn có {numberOfTasks} công việc chưa cập nhật. Và có {slsaphethan} công việc sắp hết hạn ");
                }
                else if (selectedLanguage == "English")
                {
                    ShowNotification($"You have {numberOfTasks} tasks that are not up to date. And there are {slsaphethan} tasks that are about to expire");
                }
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
            dscvcty.Columns["phongban"].Width = 65;
            dscvcty.Columns["chucvu"].HeaderText = "Chức vụ";
            dscvcty.Columns["maCV"].HeaderText = "  Mã công việc";
            dscvcty.Columns["maCV"].Width = 75;
            dscvcty.Columns["ten"].HeaderText = "Tên công việc";
            dscvcty.Columns["maNV"].HeaderText = "Mã nhân viên";
            dscvcty.Columns["maNV"].Width = 75;
            dscvcty.Columns["hoten"].HeaderText = "Tên nhân viên";

            dscvcty.Columns["trangthai"].HeaderText = "Trạng thái";
            dscvcty.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
            dscvcty.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";
            dscvcty.Columns["ngaycapnhat"].HeaderText = "Ngày cập nhật";
            dscvcty.Columns["ngaycapnhat"].Width = 80;


        }
        private void loadCTCVPban()
        {

            dscvpban.DataSource = DatabaseAccess.GetCTCVPban(Program.getUserIDPB()).Tables[0];
            dscvpban.AutoGenerateColumns = false;
            dscvpban.Columns["phongban"].HeaderText = "Phòng ban";
            dscvpban.Columns["phongban"].Width = 65;
            dscvpban.Columns["chucvu"].HeaderText = "Chức vụ";
            dscvpban.Columns["maCV"].HeaderText = "Mã công việc";
            dscvpban.Columns["maCV"].Width = 75;
            dscvpban.Columns["ten"].HeaderText = "Tên công việc";
            dscvpban.Columns["maNV"].HeaderText = "Mã nhân viên";
            dscvpban.Columns["hoten"].HeaderText = "Tên nhân viên";
            dscvpban.Columns["maNV"].Width = 75;

            dscvpban.Columns["trangthai"].HeaderText = "Trạng thái";
            dscvpban.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
            dscvpban.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";
            dscvpban.Columns["ngaycapnhat"].HeaderText = "Ngày cập nhật";
        }



        // Chỉnh sửa màu menustrip
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }
        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.FromArgb(18, 57, 166); }
            }
            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.FromArgb(37, 37, 37); }
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
            UpdateLanguage();
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
                congviec.Enabled = false;

            }
            else if (quyen == 3)
            {
                thongbaocv();
                thongbaocvnv();
                ToolStripMenuItem quanliMenuItem = (ToolStripMenuItem)menuStrip2.Items["quanly"];
                ToolStripDropDownItem congviecMenuItem = (ToolStripDropDownItem)quanliMenuItem.DropDownItems["congviec"];
                ToolStripDropDownItem dulieunhanvienMenuItem = (ToolStripDropDownItem)quanliMenuItem.DropDownItems["dulieunhanvien"];
                congviecMenuItem.Enabled = false;
                congviec.Enabled = false;


            }
            else if (quyen == 1)
            {
                thongbaocv();
         
            }
         
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Tìm kiếm";
                textBox1.ForeColor = Color.DimGray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Tìm kiếm")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
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
                label2.Text = "     Danh sách công việc phòng ban";
                label1.Text = "     Danh sách công việc công ty";
                hethong.Text = "Hệ thống";
                thêmToolStripMenuItem.Text = "Thông tin cá nhân";
                quanly.Text = "Quản lý";
                thongke.Text = "Thống kê";
                đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
                congviec.Text = "Công việc";
                trogiup.Text = "Ngôn ngữ";
                tacvu.Text = "Tác vụ";
                chưaHoànThànhToolStripMenuItem.Text = "Báo cáo công việc";
                côngViệcToolStripMenuItem1.Text = "Kết quả công việc";
                englishToolStripMenuItem.Text = "Tiếng Anh";
                vietnamToolStripMenuItem.Text = "Tiếng Việt";
                tiendocongviec.Text = "Tiến độ công việc cá nhân";
                dulieucudan.Text = "Dữ liệu cư dân";
                dulieunhanvien.Text = "Dữ liệu nhân viên";
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
                dscvcty.Columns["ngaycapnhat"].HeaderText = "Ngày cập nhật"; 

                textBox1.Text = "Tìm kiếm";
                c.Text = "Tổng công việc";
                labelHieuSuat.Text = "Hiệu suất";
                labelDoanhThu.Text = "Doanh thu";
                labelTongNV.Text = "Tổng nhân viên";
                

            }
            else if (selectedLanguage == "English")
            {
                tabControl1.TabPages[0].Text = "Company";
                tabControl1.TabPages[1].Text = "Department";
                label1.Text = "     Company Work list";
                label2.Text = "     Department Work list";
                hethong.Text = "System";
                thêmToolStripMenuItem.Text = "Personal information";
                quanly.Text = "Manage";
                thongke.Text = "Statistics";
                đăngXuấtToolStripMenuItem.Text = "Log out";
                congviec.Text = "Tasks";
                trogiup.Text = "Language";
                tacvu.Text = "Tasks";
                chưaHoànThànhToolStripMenuItem.Text = "Work report";
                côngViệcToolStripMenuItem1.Text = "Tasks result";
                englishToolStripMenuItem.Text = "English";
                vietnamToolStripMenuItem.Text = "Vietnamese";
                tiendocongviec.Text = "Personal work progress";
                dulieucudan.Text = "Resident Data";
                dulieunhanvien.Text = "Employee Data";
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
                 dscvcty.Columns["ngaycapnhat"].HeaderText = "Update day";

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
                dscvcty.Columns["ngaycapnhat"].HeaderText = "Update date";

                textBox1.Text = "Search";
                c.Text = "Total work";
                labelHieuSuat.Text = "Performance";
                labelDoanhThu.Text = "Revenue";

                labelTongNV.Text = "General staff";


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


        private void menuStrip2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timkiem_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(selectedLanguage == "Vietnamese" ? "Bạn có muốn thoát chương trình không?" : "Do you want to exit the program?",
                                                      selectedLanguage == "Vietnamese" ? "Xác nhận" : "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        private void EndResponsive()
        {
            if (this.Width < 925)
            {
                labelTongNV.Location = new Point(24, 24);
                labelTongNV.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
                c.Location = new Point(24, 24);
                c.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
                labelHieuSuat.Location = new Point(24, 24);
                labelHieuSuat.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
                labelDoanhThu.Location = new Point(24, 24);
                labelDoanhThu.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
            }
            else 
            {
                labelTongNV.Location = new Point(44, 24);
                labelTongNV.Font = new Font("Segoe UI Semibold", 16, FontStyle.Bold);
                c.Location = new Point(44, 24);
                c.Font = new Font("Segoe UI Semibold", 16, FontStyle.Bold);
                labelHieuSuat.Location = new Point(44, 24);
                labelHieuSuat.Font = new Font("Segoe UI Semibold", 16, FontStyle.Bold);
                labelDoanhThu.Location = new Point(44, 24);
                labelDoanhThu.Font = new Font("Segoe UI Semibold", 16, FontStyle.Bold);
            }
        }

        private void labelDoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            EndResponsive();
        }

        private void quanly_Click(object sender, EventArgs e)
        {

        }
    }
}
