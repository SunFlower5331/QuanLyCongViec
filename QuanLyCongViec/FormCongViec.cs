using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyCongViec
{
    public partial class FormCongViec : Form
    {
        public FormCongViec()
        {
            InitializeComponent();
            dscv.CellFormatting += dscv_CellFormatting;
            dsnv.CellFormatting += dsnv_CellFormatting;
            dsdpc.CellFormatting += dsdpc_CellFormatting;
        }
        // Chỉnh sửa màu của 3 dataGridView
        private void dscv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dscv.EnableHeadersVisualStyles = false;
            dscv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dscv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dscv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dscv.Columns[i].HeaderCell.Style.SelectionBackColor = dscv.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(160, 0, 0);
                    if (row.Cells[i].Value != null)
                    {
                        row.Cells[i].Style.BackColor = Color.FromArgb(56, 56, 56);
                        row.Cells[i].Style.ForeColor = Color.White;
                    }
                }
            }
        }
        private void dsnv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dsnv.EnableHeadersVisualStyles = false;
            dsnv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dsnv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dsnv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dsnv.Columns[i].HeaderCell.Style.SelectionBackColor = dsnv.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(160, 0, 0);
                    if (row.Cells[i].Value != null)
                    {
                        row.Cells[i].Style.BackColor = Color.FromArgb(56, 56, 56);
                        row.Cells[i].Style.ForeColor = Color.White;
                    }
                }
            }
        }
        private void dsdpc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dsdpc.EnableHeadersVisualStyles = false;
            dsdpc.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dsdpc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dsdpc.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dsdpc.Columns[i].HeaderCell.Style.SelectionBackColor = dsdpc.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(160, 0, 0);
                    if (row.Cells[i].Value != null)
                    {
                        row.Cells[i].Style.BackColor = Color.FromArgb(56, 56, 56);
                        row.Cells[i].Style.ForeColor = Color.White;
                    }
                }
            }
        }

        private void FormCongViec_Load(object sender, EventArgs e)
        {
            dtpthoihan.Format = DateTimePickerFormat.Short;
            dtpthoihan.CustomFormat = "dd/MM/yyyy";
            loadDsCongViec();
            cbotrangthai.SelectedIndex = 0;
            cbotuychonchiase.SelectedIndex = 0;
            cbotuychonhienthi.SelectedIndex = 0;
            tuychonhienthi();

            dsnv.CurrentCell = null;
            dscv.CurrentCell = null;
            dsdpc.CurrentCell = null;


        }
        private void cbotuychonhienthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            tuychonhienthi();

        }
        private void tuychonhienthi()
        {
            switch (cbotuychonhienthi.SelectedIndex)
            {
                case 0:
                    loadDsNv();
                    loadCTCV();
                    break;
                case 1:
                    loadData("DV");
                    break;
                case 2:
                    loadData("TC");
                    break;
                case 3:
                    loadData("VS");
                    break;
                case 4:
                    loadData("AN");
                    break;
                case 5:
                    loadData("KT");
                    break;
                case 6:
                    loadData("XD");
                    break;

            }
        }

        private void loadData(string phongBan)
        {
            dsnv.DataSource = DatabaseAccess.GetNhanVienTheoPhongBan(phongBan).Tables[0];
            dsnv.AutoGenerateColumns = false;
            dsnv.Columns["chucvu"].HeaderText = "Chức vụ";
            dsnv.Columns["manv"].HeaderText = "Mã nhân viên";
            dsnv.Columns["hoten"].HeaderText = "Họ và tên";

            dsdpc.DataSource = DatabaseAccess.GetCTCVTheoPhongBan(phongBan).Tables[0];
            dsdpc.AutoGenerateColumns = false;

            dsdpc.Columns["chucvu"].HeaderText = "Chức vụ";
            dsdpc.Columns["maCV"].HeaderText = "Mã công việc";
            dsdpc.Columns["ten"].HeaderText = "Tên công việc";
            dsdpc.Columns["maNV"].HeaderText = "Mã nhân viên";
            dsdpc.Columns["hoten"].HeaderText = "Tên nhân viên";
            dsdpc.Columns["trangthai"].HeaderText = "Trạng thái";
            dsdpc.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
            dsdpc.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";
            dsdpc.Columns["ngaycapnhat"].HeaderText = "Ngày cập nhật";
        }     

        private void loadDsNv()
        {

            dsnv.DataSource = DatabaseAccess.GetNhanVien().Tables[0];
            dsnv.AutoGenerateColumns = false;
            dsnv.Columns["phongban"].HeaderText = "Phòng ban";
            dsnv.Columns["chucvu"].HeaderText = "Chức vụ";
            dsnv.Columns["manv"].HeaderText = "Mã nhân viên";
            dsnv.Columns["hoten"].HeaderText = "Họ và tên";
        }

        private void loadDsCongViec()
        {
            dscv.DataSource = DatabaseAccess.GetAllDscv().Tables[0];
            dscv.Columns["maCV"].HeaderText = "Mã công việc";
            dscv.Columns["ten"].HeaderText = "Tên công việc";
            dscv.Columns["ngayYC"].HeaderText = "Ngày yêu cầu";
        }
        UyQuyen uy1;
        UyQuyen uy2;
        private void loadCTCV()
        {
            dsdpc.DataSource = DatabaseAccess.GetCTCV().Tables[0];
            dsdpc.AutoGenerateColumns = false;
            dsdpc.Columns["phongban"].HeaderText = "Phòng ban";
            dsdpc.Columns["chucvu"].HeaderText = "Chức vụ";
            dsdpc.Columns["maCV"].HeaderText = "Mã công việc";
            dsdpc.Columns["ten"].HeaderText = "Tên công việc";
            dsdpc.Columns["maNV"].HeaderText = "Mã nhân viên";
            dsdpc.Columns["hoten"].HeaderText = "Tên nhân viên";

            dsdpc.Columns["trangthai"].HeaderText = "Trạng thái";
            dsdpc.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
            dsdpc.Columns["songayhethan"].HeaderText = "Thời gian còn lại";
            dsdpc.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";
            dsdpc.Columns["ngaycapnhat"].HeaderText = "Ngày cập nhật";
            foreach (DataGridViewRow dgvRow in dsdpc.Rows)
            {
                if (dgvRow.Cells["songayhethan"].Value != null && dgvRow.Cells["trangthai"].Value != null)
                {
                    int soNgayHetHan;
                   
                    if (int.TryParse(dgvRow.Cells["songayhethan"].Value.ToString(), out soNgayHetHan))
                    {
                        if (soNgayHetHan < 0 && string.Equals(dgvRow.Cells["trangthai"].Value.ToString(), "Trễ hạn", StringComparison.OrdinalIgnoreCase))
                        {
                            dgvRow.DefaultCellStyle.BackColor = Color.Red;
                        }
                        else if (string.Equals(dgvRow.Cells["trangthai"].Value.ToString(), "Hoàn thành đúng hạn ", StringComparison.OrdinalIgnoreCase))
                        {
                            dgvRow.DefaultCellStyle.BackColor = Color.Green;
                        }
                        else if (string.Equals(dgvRow.Cells["trangthai"].Value.ToString(), "Hoàn thành sớm ", StringComparison.OrdinalIgnoreCase))
                        {
                            dgvRow.DefaultCellStyle.BackColor = Color.Blue;
                        }
                        else if (soNgayHetHan < 3 && string.Equals(dgvRow.Cells["trangthai"].Value.ToString(), "Chưa hoàn thành", StringComparison.OrdinalIgnoreCase))
                        {
                            dgvRow.DefaultCellStyle.BackColor = Color.Orange;
                        }
                    }
                }
            }


        }
        private void dscv_Click(Object sender, EventArgs e)
        {
            button1.Enabled = false;
            btnchinhsuaphancong.Enabled = false;
            btnphancong.Enabled = true;
            if (dscv.CurrentRow != null && dscv.CurrentRow.Index >= 0)
            {
                DataGridViewRow row1 = dscv.CurrentRow;
                tbomacv.Text = row1.Cells["maCV"].Value.ToString();
                tbotencv.Text = row1.Cells["ten"].Value.ToString();


            }

        }
        private void UyQuyen(UyQuyen uy1, UyQuyen uy2)
        {
            if (uy1 != null && uy2 != null)
            {
                DatabaseAccess.InsertData("DsUyQuyenCV", new string[] { "maNV_cu", "maCV", "maNV_moi", "trangthai", "thoiGianHoanThanh", "Tuychonchiase", "ngayBanGiao" },
                                            new object[] { uy1.maNV, uy1.maCV, uy2.maNV, uy1.trangthai, uy1.thoiGianHoanThanh, uy1.Tuychonchiase , uy1.ngayBanGiao});

            }
        }

        private void dsnv_Click(object sender, EventArgs e)
        {
            if (dscv.CurrentRow != null)
            {
                button1.Enabled = false;

            }
            else
            {
                button1.Enabled = true;
            }
            if (dsnv.CurrentRow != null && dsnv.CurrentRow.Index >= 0)
            {
                DataGridViewRow row1 = dsnv.CurrentRow;
                tbobophan.Text = row1.Cells["phongban"].Value.ToString();
                tbotennv.Text = row1.Cells["hoten"].Value.ToString();
                tbomanv.Text = row1.Cells["maNV"].Value.ToString();
                DataGridViewRow row2 = dsnv.CurrentRow;
                uy2 = null;
                uy2 = new UyQuyen(tbomacv.Text, tbotencv.Text, tbobophan.Text, tbotennv.Text, tbomanv.Text, dtpthoihan.Text, cbotuychonchiase.Text, cbotrangthai.Text, DateTime.Now.Date);
              
            }
        }

        private void dsdpc_Click(object sender, EventArgs e)
        {
            dscv.CurrentCell = null;
            btnphancong.Enabled = false;
            button1.Enabled = false;
            if (dsdpc.CurrentRow != null && dsdpc.CurrentRow.Index >= 0)
            {
                btnchinhsuaphancong.Enabled = true;
                DataGridViewRow row1 = dsdpc.CurrentRow;

                tbomacv.Text = row1.Cells["maCV"].Value.ToString();
                tbotencv.Text = row1.Cells["ten"].Value.ToString();
                tbobophan.Text = row1.Cells["phongban"].Value.ToString();
                tbotennv.Text = row1.Cells["hoten"].Value.ToString();
                tbomanv.Text = row1.Cells["maNV"].Value.ToString();
                dtpthoihan.Text = row1.Cells["thoiGianHoanThanh"].Value.ToString();
                cbotuychonchiase.Text = row1.Cells["Tuychonchiase"].Value.ToString();
                cbotrangthai.Text = row1.Cells["trangthai"].Value.ToString();
                uy1 = null;
                uy1 = new UyQuyen(tbomacv.Text, tbotencv.Text, tbobophan.Text, tbotennv.Text, tbomanv.Text, dtpthoihan.Text, cbotuychonchiase.Text, cbotrangthai.Text, DateTime.Now.Date);
            
            }
        }


        private void btnphancong_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(tbomacv.Text) || string.IsNullOrEmpty(tbomanv.Text) || string.IsNullOrEmpty(cbotuychonchiase.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string maCV = tbomacv.Text;
                string maNV = tbomanv.Text;
                DateTime thoiGianHoanThanh = dtpthoihan.Value;
                string tuyChonChiaSe = cbotuychonchiase.Text;
                string trangthai = cbotrangthai.Text;
                DateTime ngaycapnhat = DateTime.Now.Date;

                // phân loại hoàn thành trễ, đúng, sớm
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



                if (DatabaseAccess.IsDuplicateData("CTCV", new string[] { "maCV", "maNV" }, new object[] { maCV, maNV }))
                {
                    MessageBox.Show("Dữ liệu đã tồn tại trong cơ sở dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                DatabaseAccess.InsertData("CTCV", new string[] { "maCV", "maNV", "trangthai", "thoiGianHoanThanh", "Tuychonchiase", "ngaycapnhat" },
                    new object[] { maCV, maNV, trangthai, thoiGianHoanThanh, tuyChonChiaSe, ngaycapnhat });

                loadCTCV();

                MessageBox.Show("Đã lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string email = DatabaseAccess.getEmail(maNV);
                string content = "PHÂN CÔNG CÔNG VIỆC  \nMã công việc: " + maCV + "\nMã nhân viên: " + maNV + "\nThời gian hoàn thành: " + thoiGianHoanThanh + "\nTùy chọn chia sẻ: " + tuyChonChiaSe + "\nTrạng thái: " + trangthai + "\nNgày cập nhật: " + ngaycapnhat;
                guiEmail(email, content);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi lưu dữ liệu!\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dsnv.CurrentCell = null;
            dscv.CurrentCell = null;
            dsdpc.CurrentCell = null;
        }

        private void btnchinhsuaphancong_Click(object sender, EventArgs e)
        {
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

                DatabaseAccess.UpdateData("CTCV", new string[] { "maNV", "thoiGianHoanThanh", "Tuychonchiase", "trangthai", "ngaycapnhat" },
                  new object[] { maNV, thoiGianHoanThanh, tuyChonChiaSe, trangthai, ngaycapnhat }, conditionColumns, conditionValues);
                loadCTCV();
                tbomacv.Text = "";
                tbotencv.Text = "";
                tbobophan.Text = "";
                tbotennv.Text = "";
                tbomanv.Text = "";
                dtpthoihan.Text = "";
                cbotuychonchiase.Text = "";
                cbotrangthai.Text = "";
                dsnv.CurrentCell = null;
                dscv.CurrentCell = null;
                dsdpc.CurrentCell = null;
                dsnv.CurrentCell = null;
                dscv.CurrentCell = null;
                dsdpc.CurrentCell = null;
                MessageBox.Show("Đã cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string email=DatabaseAccess.getEmail(maNV);
                string content="CẬP NHẬT CÔNG VIỆC  \nMã công việc: "+maCV+"\nMã nhân viên: "+maNV+"\nThời gian hoàn thành: "+thoiGianHoanThanh+"\nTùy chọn chia sẽ: "+tuyChonChiaSe+"\nTrạng thái: " + trangthai + "\nNgày cập nhật: " + ngaycapnhat;
                guiEmail(email,content);

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Đã xảy ra lỗi khi cập nhật dữ liệu!\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dsnv.CurrentCell = null;
            dscv.CurrentCell = null;
            dsdpc.CurrentCell = null;


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
                mail.Subject = "[THÔNG BÁO ỨNG DỤNG QUẢN LÍ CÔNG VIỆC] CÔNG VIỆC";
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            dscv.AllowUserToAddRows = true;
            btnluu.Enabled = true;

            DataTable dataTable = (DataTable)dscv.DataSource;

            // Thêm một hàng mới vào DataTable
            DataRow newRow = dataTable.NewRow();
            newRow["ngayYC"] = DateTime.Now.Date;

            // Thêm hàng mới vào DataTable
            dataTable.Rows.Add(newRow);
            dscv.BeginEdit(true);
            dsnv.CurrentCell = null;
            dscv.CurrentCell = null;
            dsdpc.CurrentCell = null;

            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {

                dscv.Enabled = true;
                if (dscv.CurrentRow != null && dscv.SelectedRows.Count >= 0)
                {
                    DataGridViewRow selectedRow = dscv.CurrentRow;
                    string maCV = selectedRow.Cells["maCV"].Value.ToString();
                    string ten = selectedRow.Cells["ten"].Value.ToString();
                    string ngayYC = selectedRow.Cells["ngayYC"].Value.ToString();

                    string[] conditionColumns = { "maCV", "ten", "ngayYC" };
                    object[] conditionValues = { maCV, ten, ngayYC };

                    DatabaseAccess.DeleteData("DsCongViec", conditionColumns, conditionValues);

                    loadDsCongViec();
                    MessageBox.Show("Đã xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dsdpc.CurrentRow != null && dsdpc.SelectedRows.Count >= 0)
                {
                    DataGridViewRow selectedRow = dsdpc.CurrentRow;
                    int maCV = Convert.ToInt32(selectedRow.Cells["maCV"].Value);
                    DatabaseAccess.delCTCV(maCV);

                    loadCTCV();

                    MessageBox.Show("Đã xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hàng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi xóa dữ liệu!\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dsnv.CurrentCell = null;
            dscv.CurrentCell = null;
            dsdpc.CurrentCell = null;
        }

        private void dscv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnluu_Click(sender, e);
                dscv.CurrentCell = dscv.Rows[dscv.Rows.Count - 1].Cells[0];
                dscv.BeginEdit(true);

            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {

                DataGridViewRow newRow = dscv.Rows[dscv.Rows.Count - 2];
                foreach (DataGridViewCell cell in newRow.Cells)
                {
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value?.ToString()))
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string maCV = newRow.Cells["maCV"].Value.ToString();
                string ten = newRow.Cells["ten"].Value.ToString();
                DateTime ngayYC = DateTime.Now.Date;

                // Kiểm tra xem dữ liệu đã tồn tại trong cơ sở dữ liệu chưa
                bool dataExists = DatabaseAccess.CheckDataExists("DsCongViec", "maCV", maCV);
                if (dataExists)
                {
                    MessageBox.Show("Dữ liệu đã tồn tại trong cơ sở dữ liệu|Bạn chưa nhập dữ liệu mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Nếu dữ liệu chưa tồn tại, thêm vào cơ sở dữ liệu
                DatabaseAccess.InsertData("DsCongViec",
                    new string[] { "maCV", "ten", "ngayYC" },
                    new object[] { maCV, ten, ngayYC });

                MessageBox.Show("Đã thêm dữ liệu mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDsCongViec();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi thêm dữ liệu mới!\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dsnv.CurrentCell = null;
            dscv.CurrentCell = null;
            dsdpc.CurrentCell = null;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {

            // Lấy thông tin từ hàng được chọn trong DataGridView
            if (dscv.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dscv.CurrentRow;
                string maCV = selectedRow.Cells["maCV"].Value.ToString(); // Giả sử cột maCV là cột chứa mã công việc
                                                                          // Lấy thông tin cập nhật từ các điều khiển khác trên form
                string tenMoi = selectedRow.Cells["ten"].Value.ToString(); // Ví dụ, txtTenMoi là TextBox chứa tên mới cần cập nhật

                DateTime ngayYC = DateTime.Now.Date;
                // Cập nhật dữ liệu trong cơ sở dữ liệu
                try
                {
                    // Gọi phương thức UpdateData để cập nhật dữ liệu
                    DatabaseAccess.UpdateData("DsCongViec", new string[] { "ten", "ngayYC" }, new object[] { tenMoi, ngayYC }, new string[] { "maCV" }, new object[] { maCV });
                    MessageBox.Show("Đã cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật lại DataGridView để hiển thị dữ liệu mới
                    loadDsCongViec(); // Gọi phương thức loadDsCongViec để làm mới dữ liệu trong DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi cập nhật dữ liệu!\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dsnv.CurrentCell = null;
            dscv.CurrentCell = null;
            dsdpc.CurrentCell = null;
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
        private void FormCongViec_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
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

            if (DatabaseAccess.CheckCV(maCV, maNV) == false)

            {
                MessageBox.Show("uy1" + uy1.maNV + "uy2" + uy2.maNV);
                UyQuyen(uy1, uy2);
                DatabaseAccess.UpdateData("CTCV", new string[] { "maNV", "thoiGianHoanThanh", "Tuychonchiase", "trangthai", "ngaycapnhat" },
              new object[] { maNV, thoiGianHoanThanh, tuyChonChiaSe, trangthai, ngaycapnhat }, conditionColumns, conditionValues);
                loadCTCV();
                tbomacv.Text = "";
                tbotencv.Text = "";
                tbobophan.Text = "";
                tbotennv.Text = "";
                tbomanv.Text = "";
                dtpthoihan.Text = "";
                cbotuychonchiase.Text = "";
                cbotrangthai.Text = "";
                dsnv.CurrentCell = null;
                dscv.CurrentCell = null;
                dsdpc.CurrentCell = null;
                dsnv.CurrentCell = null;
                dscv.CurrentCell = null;
                dsdpc.CurrentCell = null;
                MessageBox.Show("Đã cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string email = DatabaseAccess.getEmail(maNV);
                string content ="ỦY QUYỀN CÔNG VIỆC  \nMã công việc: " + maCV + "\nMã nhân viên: " + maNV + "\nThời gian hoàn thành: " + thoiGianHoanThanh + "\nTùy chọn chia sẽ: " + tuyChonChiaSe + "\nTrạng thái: " + trangthai + "\nNgày cập nhật: " + ngaycapnhat;
                guiEmail(email, content);

            }

        }

        private void buttonExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "DataGridViewExport.xlsx";
            saveFileDialog.Filter = "Excel (*xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName, dsdpc);
                    Process.Start(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã có lỗi xảy ra trong quá trình xuất file\n" + ex.Message);
                }
            }
        }

        private void ExportExcel(string path, DataGridView data)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < data.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = data.Columns[i].HeaderText;
            }
            for (int i = 0; i < data.Rows.Count; i++)
            {
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = data.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void buttonXuatPDF_Click(object sender, EventArgs e)
        {
            if (dsdpc.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "DataGridViewExport.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var htmlContent = GetHtmlFromDataGridView(dsdpc);
                    var pdfFile = TransferHtmlToPdf(htmlContent, saveFileDialog.FileName);
                    Process.Start(pdfFile);
                    MessageBox.Show("Xuất dữ liệu sang PDF thành công!", "Info");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu để xuất ra PDF!", "Info");
            }
        }

        private string GetHtmlFromDataGridView(DataGridView dataGridView)
        {
            string fileName = Path.Combine(Path.GetTempPath(), DateTime.Now.ToString("ddMMyyyyhhmmss") + ".html");
            string html = "<!DOCTYPE html><html><head><style>table { border-collapse: collapse; } th, td { border: 1px solid black; padding: 8px; }</style></head><body><table>";

            // Add headers
            html += "<tr>";
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                html += "<th>" + column.HeaderText + "</th>";
            }
            html += "</tr>";

            // Add data
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                html += "<tr>";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    html += "<td>" + cell.Value.ToString() + "</td>";
                }
                html += "</tr>";
            }

            html += "</table></body></html>";

            System.IO.File.WriteAllText(fileName, html);
            return fileName;
        }

        private string TransferHtmlToPdf(string htmlContent, string pdfFilePath)
        {
            string pdfFile = pdfFilePath.Replace(".html", ".pdf");
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
            info.Arguments = "--headless --disable-gpu --print-to-pdf=\"" + pdfFile + "\" \"" + htmlContent + "\"";
            info.CreateNoWindow = true;
            Process process = new Process();
            process.StartInfo = info;
            process.Start();
            process.WaitForExit();

            return pdfFile;
        }
    }
}


