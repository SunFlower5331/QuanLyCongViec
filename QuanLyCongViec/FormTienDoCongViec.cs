using DAL;
using DTO;
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
    public partial class FormTienDoCongViec : Form
    {
        public FormTienDoCongViec()
        {
            InitializeComponent();
        }

        private void FormTienDoCongViec_Load(object sender, EventArgs e)
        {

            loadTienDoCongViec();
            loadData(Program.getUserIDPB());

            dsnv.CurrentCell = null;
            dscv.CurrentCell = null;
            checkQuyen();
            UpdateLanguage();

        }
        private void checkQuyen()
        {
            string id = Program.UserID;
            int quyen = DatabaseAccess.getUserQuyen(id);

            if (quyen == 3)
            {
                dsnv.Enabled = false;
                dsmanv.Enabled = false;
                dtpthoihan.Enabled = false;
            }

        }

        private void loadthongtinkhachhang(string macv)
        {
            thongtinkh.DataSource = DatabaseAccess.getThongtinkh(macv).Tables[0];
            thongtinkh.Columns["maCD"].HeaderText = "Mã cư dân";
            thongtinkh.Columns["hinhthuc"].HeaderText = "Hình thức";
            thongtinkh.Columns["tenCH"].HeaderText = "Tên căn hộ";
            thongtinkh.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            thongtinkh.Columns["cccd"].HeaderText = "CCCD";
            thongtinkh.Columns["sdt"].HeaderText = "Số điện thoại";
            thongtinkh.Columns["email"].HeaderText = "Email";
            thongtinkh.Columns["quoctich"].HeaderText = "Quốc tịch";
            thongtinkh.Columns["sothetamtru"].HeaderText = "Số thẻ tạm trú";
            thongtinkh.Columns["sdt_nguoithan"].HeaderText = "Số điện thoại người thân";
            thongtinkh.Columns["tinhtrangcongno"].HeaderText = "Tỉnh trạng công nợ";
            thongtinkh.Columns["dk_thucung"].HeaderText = "Đăng ký thú cưng";
        }
        private void loadData(string phongBan)
        {
            dsnv.DataSource = DatabaseAccess.GetNhanVienTheoPhongBan(phongBan).Tables[0];
            dsnv.AutoGenerateColumns = false;
            dsnv.Columns["chucvu"].HeaderText = "Chức vụ";
            dsnv.Columns["manv"].HeaderText = "Mã nhân viên";
            dsnv.Columns["hoten"].HeaderText = "Họ và tên";

            dsmanv.DataSource = DatabaseAccess.GetCTCVTheoPhongBan(phongBan).Tables[0];
            dsmanv.AutoGenerateColumns = false;

            dsmanv.Columns["chucvu"].HeaderText = "Chức vụ";
            dsmanv.Columns["maCV"].HeaderText = "Mã công việc";
            dsmanv.Columns["ten"].HeaderText = "Tên công việc";
            dsmanv.Columns["maNV"].HeaderText = "Mã nhân viên";
            dsmanv.Columns["hoten"].HeaderText = "Tên nhân viên";
            dsmanv.Columns["trangthai"].HeaderText = "Trạng thái";
            dsmanv.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
            dsmanv.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";
            dsmanv.Columns["ngaycapnhat"].HeaderText = "Ngày cập nhật";
        }
        private void loadTienDoCongViec()
        {
            string selectedLanguage = GlobalSettings.Language;
            try
            {
                dscv.CurrentCell = null;
                string maNV = Program.UserID;
                dscv.DataSource = DatabaseAccess.GetTienDoCongViec(maNV).Tables[0];

                dscv.Columns["maCV"].HeaderText = "Mã công việc";
                dscv.Columns["ten"].HeaderText = "Tên công việc";
                dscv.Columns["maCH"].HeaderText = "Mã căn hộ";
                dscv.Columns["trangthai"].HeaderText = "Trạng thái";
                dscv.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
                dscv.Columns["songayhethan"].HeaderText = "Số ngày còn lại";
                dscv.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";
                dscv.Columns["ngaycapnhat"].HeaderText = "Ngày cập nhật";

                foreach (DataGridViewRow dgvRow in dscv.Rows)
                {

                    int soNgayHetHan = Convert.ToInt32(dgvRow.Cells["songayhethan"].Value);
              
                    if (soNgayHetHan < 3 && string.Equals(dgvRow.Cells["trangthai"].Value.ToString(), "Chưa hoàn thành", StringComparison.OrdinalIgnoreCase))
                    {
                        dgvRow.DefaultCellStyle.ForeColor = Color.White;
                        dgvRow.DefaultCellStyle.BackColor = Color.Orange;
                    }
                }
            }

            catch (Exception ex)
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guiEmail(string to, string content)
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
                mail.Subject = "[THÔNG BÁO CÔNG VIỆC] NHÂN VIÊN CẬP NHẬT TIẾN ĐỘ CÔNG VIỆC";
                mail.Body = content;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(mail);
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
                }
            }
            catch
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Lỗi hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("System error!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }


        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            cbotrangthai.Enabled = true;
            cbotuychonchiase.Enabled = true;
            btnluu.Enabled = true;


        }

        private bool isThongTinKhVisible = false;

        private void btnthongtinkh_Click(object sender, EventArgs e)
        {
            if (tbomacv.Text != null)
            {
                loadthongtinkhachhang(tbomacv.Text);
                isThongTinKhVisible = !isThongTinKhVisible;
                thongtinkh.Visible = isThongTinKhVisible;

            }

        }


        private void btnluu_Click(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            try
            {

                string maCV = tbomacv.Text;
                string maNV = tbomanv.Text;
                DateTime thoiGianHoanThanh = dtpthoihan.Value;
                string tuyChonChiaSe = cbotuychonchiase.Text;
                string trangthai = cbotrangthai.Text;
                DateTime ngaycapnhat = DateTime.Now.Date;
                string[] conditionColumns = { "maCV" };
                object[] conditionValues = { maCV };

                if (trangthai == "Đã hoàn thành")
                {
                    if (ngaycapnhat < thoiGianHoanThanh)
                    {
                        trangthai = "Hoàn thành sớm";
                    }
                    else if (ngaycapnhat == thoiGianHoanThanh)
                    {
                        trangthai = "Hoàn thành đúng hạn";
                    }
                    else
                    {
                        trangthai = "Trễ hạn";
                    }

                }

                if (maNV != null)
                {
                    DatabaseAccess.UpdateData("CTCV", new string[] { "maNV", "thoiGianHoanThanh", "Tuychonchiase", "trangthai", "ngaycapnhat" },
                        new object[] { maNV, thoiGianHoanThanh, tuyChonChiaSe, trangthai, ngaycapnhat }, conditionColumns, conditionValues);
                }
                else
                {
                    DatabaseAccess.UpdateData("CTCV", new string[] { "maNV", "thoiGianHoanThanh", "Tuychonchiase", "trangthai", "ngaycapnhat" },
                        new object[] { maNV, thoiGianHoanThanh, tuyChonChiaSe, trangthai, ngaycapnhat }, conditionColumns, conditionValues);

                }
                this.FormTienDoCongViec_Load(null, null);

                tbomacv.Text = "";
                tbotencv.Text = "";
                tbochucvu.Text = "";
                tbotennv.Text = "";
                tbomanv.Text = "";
                dtpthoihan.Text = "";
                cbotuychonchiase.Text = "";
                cbotrangthai.Text = "";

                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Đã cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("Data updated successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                string email = DatabaseAccess.getEmailCEO();
                string content = "CẬP NHẬT CÔNG VIỆC  \nMã công việc: " + maCV + "\nMã nhân viên: " + maNV + "\nThời gian hoàn thành: " + thoiGianHoanThanh + "\nTùy chọn chia sẽ: " + tuyChonChiaSe + "\nTrạng thái: " + trangthai + "\nNgày cập nhật: " + ngaycapnhat;

                if (selectedLanguage == "Vietnamese")
                {
                    content = "CẬP NHẬT CÔNG VIỆC  \nMã công việc: " + maCV + "\nMã nhân viên: " + maNV + "\nThời gian hoàn thành: " + thoiGianHoanThanh + "\nTùy chọn chia sẽ: " + tuyChonChiaSe + "\nTrạng thái: " + trangthai + "\nNgày cập nhật: " + ngaycapnhat;
                }
                else if (selectedLanguage == "English")
                {
                    content = "UPDATE JOB \nJob code: " + maCV + "\nEmployee code: " + maNV + "\nCompletion time: " + thoiGianHoanThanh + "\nSharing options: " + tuyChonChiaSe + "\nStatus: " + trangthai + "\nNgày cập nhật: " + ngaycapnhat;
                }
                guiEmail(email, content);

            }
            catch (Exception ex)
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi cập nhật dữ liệu!\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show($"An error occurred while updating data!\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            dsnv.CurrentCell = null;
            dscv.CurrentCell = null;

        }

        private void dsnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            FormMain form = new FormMain();
            form.Show();
            this.Hide();
        }
        // Dùng để kéo thả cửa sổ
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FormTienDoCongViec_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dscv_Click(object sender, EventArgs e)
        {
            if (dscv.CurrentRow != null && dscv.CurrentRow.Index >= 0)
            {
                DataGridViewRow row1 = dscv.CurrentRow;
                tbomacv.Text = row1.Cells["maCV"].Value.ToString();
                tbotencv.Text = row1.Cells["ten"].Value.ToString();
                tbomanv.Text = Program.UserID;
                cbotuychonchiase.Text = row1.Cells["Tuychonchiase"].Value.ToString();
                cbotrangthai.Text = row1.Cells["trangthai"].Value.ToString();



            }
            if (tbomacv.Text != null)
            {
                loadthongtinkhachhang(tbomacv.Text);
            }

        }

        private void dsnv_Click(object sender, EventArgs e)
        {
            if (dsnv.CurrentRow != null && dsnv.CurrentRow.Index >= 0)
            {
                DataGridViewRow row1 = dsnv.CurrentRow;
                tbochucvu.Text = row1.Cells["chucvu"].Value.ToString();
                tbomanv.Text = row1.Cells["maNV"].Value.ToString();
                tbotennv.Text = row1.Cells["hoten"].Value.ToString();

            }

        }

        private bool check = false;

        private void btnxemcvpb_Click(object sender, EventArgs e)
        {

            check = !check;

            dsmanv.Visible = check;
            if (tbomacv.Text != null)
            {
                loadthongtinkhachhang(tbomacv.Text);
            }

        }


        private void dsmanv_Click(object sender, EventArgs e)
        {
            if (dsmanv.CurrentRow != null && dsmanv.CurrentRow.Index >= 0)
            {
                DataGridViewRow row1 = dsmanv.CurrentRow;
                tbochucvu.Text = row1.Cells["chucvu"].Value.ToString();
                tbomanv.Text = row1.Cells["maNV"].Value.ToString();
                tbotennv.Text = row1.Cells["hoten"].Value.ToString();
                tbomacv.Text = row1.Cells["maCV"].Value.ToString();
                cbotrangthai.Text = row1.Cells["trangthai"].Value.ToString();
                cbotuychonchiase.Text = row1.Cells["Tuychonchiase"].Value.ToString();
                dtpthoihan.Text = row1.Cells["thoiGianHoanThanh"].Value.ToString();
                tbotencv.Text = row1.Cells["ten"].Value.ToString();

            }
            if (tbomacv.Text != null)
            {
                loadthongtinkhachhang(tbomacv.Text);
            }


        }
        private void UpdateLanguage()
        {
            string selectedLanguage = GlobalSettings.Language;
            // Use selectedLanguage instead of getting language from GlobalSettings or other source
            if (selectedLanguage == "Vietnamese")
            {
                // Cập nhật các nhãn và điều khiển trong giao diện với ngôn ngữ tiếng Việt
                groupBox1.Text = "Thông tin nhân viên";
                groupBox2.Text = "Chia sẻ công việc";
                label1.Text = "Mã nhân viên:";
                label2.Text = "Thời hạn:";
                label3.Text = "Mã công việc:";
                label4.Text = "Tên công việc:";
                label5.Text = "Chức vụ:";
                label6.Text = "Họ và tên:";
                label7.Text = "Tùy chọn chia sẻ:";
                label8.Text = "Trạng thái:";
                btnluu.Text = "Lưu";
                btncapnhat.Text = "Cập nhật";
                btnthongtinkh.Text = "Thông tin khác hàng";
                btnxemcvpb.Text = "Xem công việc theo phòng ban";
                groupBox3.Text = "Danh sách nhân viên";

        

        

            }
            else if (selectedLanguage == "English")
            {
                // Cập nhật các nhãn và điều khiển trong giao diện với ngôn ngữ tiếng Anh
                groupBox1.Text = "Employee Information";
                groupBox2.Text = "Share Job";
                label1.Text = "Employee ID:";
                label2.Text = "Deadline:";
                label3.Text = "Job ID:";
                label4.Text = "Job Name:";
                label5.Text = "Position:";
                label6.Text = "Full Name:";
                label7.Text = "Share Option:";
                label8.Text = "Status:";
                btnluu.Text = "Save";
                btncapnhat.Text = "Update";
                btnthongtinkh.Text = "Customer Information";
                btnxemcvpb.Text = "View jobs by department";
                groupBox3.Text = "The list of Employee";
            }
        }
            private void dscv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
            {
                // Chỉ xử lý cho cột trạng thái
                if (dscv.Columns[e.ColumnIndex].Name == "trangthai")
                {
                    DataGridViewRow row = dscv.Rows[e.RowIndex];
                    int soNgayHetHan = Convert.ToInt32(row.Cells["songayhethan"].Value);
                if (soNgayHetHan < 0 && string.Equals(e.Value.ToString(), "Trễ hạn", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else if (string.Equals(e.Value.ToString(), "Hoàn thành đúng hạn", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (string.Equals(e.Value.ToString(), "Hoàn thành sớm", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = Color.Blue;
                }
            }
        }
    }
}