﻿using DAL;
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
            //dscv.CellFormatting += dscv_CellFormatting;
            //dsnv.CellFormatting += dsnv_CellFormatting;
        }

        private void FormTienDoCongViec_Load(object sender, EventArgs e)
        {

            loadTienDoCongViec();
            loadData(Program.getUserIDPB());
            dsnv.CurrentCell = null;
            dscv.CurrentCell = null;



        }


/*        private void tuychonhienthi()
        {
            switch ("KT")
            {
                
                case "DV":
                    loadData("DV");
                    break;
                case "TC":
                    loadData("TC");
                    break;
                case "VS":
                    loadData("VS");
                    break;
                case "AN":
                    loadData("AN");
                    break;
                case "KT":
                    loadData("KT");
                    break;
                case "XD":
                    loadData("XD");
                    break;

            }
        }*/
private void loadthongtinkhachhang(string macv)
        {
            thongtinkh.DataSource=DatabaseAccess.getThongtinkh(macv).Tables[0];
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
        }
        private void loadTienDoCongViec()
        {
            try
            {
                dscv.CurrentCell = null;
                string maNV = Program.UserID;
                DataSet dataSet = DatabaseAccess.GetTienDoCongViec(maNV);

                DataTable dataTable = dataSet.Tables.Count >= 0 ? dataSet.Tables[0] : null;

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    
                    dscv.DataSource = dataTable;

                    dscv.Columns["maCV"].HeaderText = "Mã công việc";
                    dscv.Columns["ten"].HeaderText = "Tên công việc";
                    dscv.Columns["maCH"].HeaderText = "Mã căn hộ";
                    dscv.Columns["trangthai"].HeaderText = "Trạng thái";
                    dscv.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
                    dscv.Columns["songayhethan"].HeaderText = "Số ngày còn lại";
                    dscv.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";

                    
                    foreach (DataGridViewRow dgvRow in dscv.Rows)
                    {
                      
                        int soNgayHetHan = Convert.ToInt32(dgvRow.Cells["songayhethan"].Value);

                       
                        if (soNgayHetHan < 0 && string.Equals(dgvRow.Cells["trangthai"].Value.ToString(), "Chưa hoàn thành", StringComparison.OrdinalIgnoreCase)
)
                        {
                            dgvRow.DefaultCellStyle.BackColor = Color.Red;
                        }
                        else if (string.Equals(dgvRow.Cells["trangthai"].Value.ToString(), "Đã hoàn thành", StringComparison.OrdinalIgnoreCase))
                        {
                            dgvRow.DefaultCellStyle.BackColor = Color.Green;

                        }else if (soNgayHetHan < 3 && string.Equals(dgvRow.Cells["trangthai"].Value.ToString(), "Chưa hoàn thành", StringComparison.OrdinalIgnoreCase))
                        {
                            dgvRow.DefaultCellStyle.BackColor = Color.Orange;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void cbotuychonchiase_SelectedIndexChanged(object sender, EventArgs e)
        {
/*            if(cbotuychonchiase.SelectedIndex == 2) {
                dsmanv.Visible = true;
            }
            else
            {
                dsmanv.Visible = false;
            }*/
        }
        private void guiEmail(string to, string content)
        {
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
                    MessageBox.Show("Lỗi Cacth, không gửi đc");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }


        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            cbotrangthai.Enabled = true;
            cbotuychonchiase.Enabled = true;
           

        }

        private bool isThongTinKhVisible = false;

        private void btnthongtinkh_Click(object sender, EventArgs e)
        {
          
            isThongTinKhVisible = !isThongTinKhVisible;

            thongtinkh.Visible = isThongTinKhVisible;
            
        }
        

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {

                string maCV = tbomacv.Text;
                string maNV = tbomanv.Text;
                DateTime thoiGianHoanThanh = dtpthoihan.Value;
                string tuyChonChiaSe = cbotuychonchiase.Text;
                string trangthai = cbotrangthai.Text;
                string[] conditionColumns = { "maCV" };
                object[] conditionValues = { maCV };
                if (maNV != null)
                {
                    DatabaseAccess.UpdateData("CTCV", new string[] { "maNV", "thoiGianHoanThanh", "Tuychonchiase", "trangthai" },
                        new object[] { maNV, thoiGianHoanThanh, tuyChonChiaSe, trangthai }, conditionColumns, conditionValues);
                }
                else
                {
                    DatabaseAccess.UpdateData("CTCV", new string[] { "maNV", "thoiGianHoanThanh", "Tuychonchiase", "trangthai" },
                      new object[] { maNV, thoiGianHoanThanh, tuyChonChiaSe, trangthai }, conditionColumns, conditionValues);

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

                MessageBox.Show("Đã cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string email = DatabaseAccess.getEmailCEO();
                string content = "CẬP NHẬT CÔNG VIỆC  \nMã công việc: " + maCV + "\nMã nhân viên: " + maNV + "\nThời gian hoàn thành: " + thoiGianHoanThanh + "\nTùy chọn chia sẽ: " + tuyChonChiaSe + "\nTrạng thái: " + trangthai;
                guiEmail(email, content);

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Đã xảy ra lỗi khi cập nhật dữ liệu!\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dsnv.CurrentCell = null;
            dscv.CurrentCell = null;

        }

        private void dsnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

/*        private void button1_Click(object sender, EventArgs e)
        {
            tuychonhienthi();
        }*/

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
                cbotuychonchiase.Text= row1.Cells["Tuychonchiase"].Value.ToString();
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

        }

        private void dscv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                cbotrangthai.Text= row1.Cells["trangthai"].Value.ToString();
                cbotuychonchiase.Text= row1.Cells["Tuychonchiase"].Value.ToString();
                dtpthoihan.Text= row1.Cells["thoiGianHoanThanh"].Value.ToString();
                tbotencv.Text= row1.Cells["ten"].Value.ToString();

            }

           
        }
    }
}
