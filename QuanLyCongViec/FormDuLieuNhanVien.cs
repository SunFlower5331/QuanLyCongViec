﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyCongViec
{
    public partial class FormDuLieuNhanVien : Form
    {
       

        public FormDuLieuNhanVien()
        {
            InitializeComponent();

            dslshd.CellFormatting += dslshd_CellFormatting;
            dsnv.CellFormatting += dsnv_CellFormatting;
            dstk.CellFormatting += dstk_CellFormatting;
            dspb.CellFormatting += dspb_CellFormatting;
            dsuqcv.CellFormatting += dsuqcv_CellFormatting;
            txbtimkiem.KeyDown += new KeyEventHandler(txbtimkiem_KeyDown);
        }

        private void FormDuLieu_Load(object sender, EventArgs e)
        {
            loadDsNv();
            loadDsPhongBan();
            loadDsTK();
            loadDsUyQuyenCV();
            loadDsQuyen();
            UpdateLanguage();
        }

        private void dslshd_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dslshd.EnableHeadersVisualStyles = false;
            dslshd.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dslshd.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dslshd.Columns[i].HeaderCell.Style.SelectionBackColor = dslshd.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(18, 57, 166);

                    row.Cells[i].Style.BackColor = Color.White;
                    row.Cells[i].Style.ForeColor = Color.Black;

                }
            }
        }
        private void dstk_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dstk.EnableHeadersVisualStyles = false;
            dstk.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dstk.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dstk.Columns[i].HeaderCell.Style.SelectionBackColor = dstk.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(18, 57, 166);

                    row.Cells[i].Style.BackColor = Color.White;
                    row.Cells[i].Style.ForeColor = Color.Black;

                }
            }
        }
        private void dsnv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dsnv.EnableHeadersVisualStyles = false;
            dsnv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dsnv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dsnv.Columns[i].HeaderCell.Style.SelectionBackColor = dsnv.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(18, 57, 166);

                    row.Cells[i].Style.BackColor = Color.White;
                    row.Cells[i].Style.ForeColor = Color.Black;

                }
            }
        }
        private void dspb_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dspb.EnableHeadersVisualStyles = false;
            dspb.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dspb.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dspb.Columns[i].HeaderCell.Style.SelectionBackColor = dspb.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(18, 57, 166);

                    row.Cells[i].Style.BackColor = Color.White;
                    row.Cells[i].Style.ForeColor = Color.Black;

                }
            }
        }
        private void dsuqcv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dsuqcv.EnableHeadersVisualStyles = false;
            dsuqcv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dsuqcv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dsuqcv.Columns[i].HeaderCell.Style.SelectionBackColor = dsuqcv.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(18, 57, 166);

                    row.Cells[i].Style.BackColor = Color.White;
                    row.Cells[i].Style.ForeColor = Color.Black;

                }
            }
        }

        private void loadDsNv()
        {
            
            dsnv.DataSource = DatabaseAccess.GetAllNhanVien().Tables[0];
            dsnv.AutoGenerateColumns = false;
            dsnv.Columns["manv"].HeaderText = "Mã nhân viên";
            dsnv.Columns["hoten"].HeaderText = "Họ và tên";
            dsnv.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dsnv.Columns["gioitinh"].HeaderText = "Giới tính";
            dsnv.Columns["diachi"].HeaderText = "Địa chỉ";
            dsnv.Columns["didong"].HeaderText = "Đi động";
            dsnv.Columns["email"].HeaderText = "Email";
            dsnv.Columns["chucvu"].HeaderText = "Chức vụ";
            dsnv.Columns["phongban"].HeaderText = "Phòng ban";
            dsnv.Columns["luong"].HeaderText = "Lương";
            dsnv.Columns["trangthai"].HeaderText = "Trạng thái";
            dsnv.Columns["trinhdohocvan"].HeaderText = "Trình độ học vấn";
            dsnv.Columns["loaihinh"].HeaderText = "Loại hình";
           
        }
        private void loadDsUyQuyenCV()
        {
            dsuqcv.DataSource = DatabaseAccess.GetDSUYCV().Tables[0];
            dsuqcv.AutoGenerateColumns = false;
            dsuqcv.Columns["maNV_cu"].HeaderText = "Mã nhân viên cũ";
            dsuqcv.Columns["maCV"].HeaderText = "Mã công việc";
            dsuqcv.Columns["maNV_moi"].HeaderText = "Mã nhân viên được ủy quyền";
            dsuqcv.Columns["trangthai"].HeaderText = "Trạng thái";
            dsuqcv.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
            dsuqcv.Columns["songayhethan"].HeaderText = "Số ngày hết hạn";
            dsuqcv.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";
            dsuqcv.Columns["ngayBanGiao"].HeaderText = "Ngày bàn giao";
            btnthem.Enabled = false;
            btnluu.Enabled = false;
        }
        private void loadDsPhongBan()
        {

            dspb.DataSource = DatabaseAccess.GetAllPhongBan().Tables[0];
            dspb.AutoGenerateColumns = false;
            dspb.Columns["id"].HeaderText = "Mã phòng ban";
            dspb.Columns["ten"].HeaderText = "Tên phòng ban";

        }
       
        private void loadDsQuyen()
        {
            dslshd.DataSource = DatabaseAccess.GetAllQuyen().Tables[0];
            dslshd.Columns["id"].HeaderText = "Mã quyền";
            dslshd.Columns["ten"].HeaderText = "Tên quyền hạn";

        }
        private void loadDsTK()
        {

            dstk.DataSource = DatabaseAccess.GetAllTK().Tables[0];
            dstk.AutoGenerateColumns = false;
            dstk.Columns["id"].HeaderText = "Tên đăng nhập";
            dstk.Columns["mk"].HeaderText = "Mật khẩu";
            dstk.Columns["loaiTK"].HeaderText = "Loại tài khoản";

        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            DataGridView dgv = null;
            btnluu.Enabled = true;
             if (tabDulieu.SelectedTab == NhanVien)
            {
             
                dgv = dsnv;
            }
            else if (tabDulieu.SelectedTab == PhongBan)
            {
             
                dgv = dspb;
            }
            else if (tabDulieu.SelectedTab == TaiKhoan)
            {
              
                dgv = dstk;
            }
            else if (tabDulieu.SelectedTab == Quyen)
            {
                
                dgv = dslshd;
            }else if (tabDulieu.SelectedTab== DsUyQuyenCV)
            {
                dgv = dsuqcv;
            }

            if (dgv != null)
            {
                dgv.AllowUserToAddRows = true;
                dgv.ReadOnly = false;

                dgv.ClearSelection();
                dgv.Rows[dgv.Rows.Count - 1].Selected = true;

                if (dgv.Columns.Count > 0)
                    dgv.CurrentCell = dgv.Rows[dgv.Rows.Count - 1].Cells[0];


                dgv.AllowUserToAddRows = false;
            }
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            bool isDataValid = true;
            isDataValid &= CheckDataGridViewData(dslshd);
           
            isDataValid &= CheckDataGridViewData(dspb);
            isDataValid &= CheckDataGridViewData(dsnv);
            isDataValid &= CheckDataGridViewData(dstk);
          
          
            if (isDataValid)
            {

                if (tabDulieu.SelectedTab == NhanVien)
                {
                    SaveLastRowData(dsnv, "NhanVien");
                    loadDsNv();
                }
                else if (tabDulieu.SelectedTab == PhongBan)
                {
                    SaveLastRowData(dspb, "PhongBan");
                    loadDsPhongBan();
                }
                else if (tabDulieu.SelectedTab == TaiKhoan)
                {
                    SaveLastRowData(dstk, "TaiKhoan");
                    loadDsTK();
                }
                else if (tabDulieu.SelectedTab == Quyen)
                {
                    SaveLastRowData(dslshd, "Quyen");
                    loadDsQuyen();
                }else if(tabDulieu.SelectedTab == DsUyQuyenCV)
                {
                    SaveLastRowData(dsuqcv, "DsUyQuyenCV");
                    loadDsUyQuyenCV();

                }
                
              
            }
        }


        private bool IsEmailValid(string email)
        {
            // Biểu thức chính quy kiểm tra định dạng email của Gmail không phân biệt chữ hoa chữ thường
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";


            // Kiểm tra email có phù hợp với biểu thức chính quy không (không phân biệt chữ hoa và chữ thường)
            return Regex.IsMatch(email.ToLower(), pattern, RegexOptions.IgnoreCase);
        }


        private void SaveLastRowData(DataGridView dgv, string tableName)
        {
            string selectedLanguage = GlobalSettings.Language;

            DataGridViewRow lastRow = dgv.Rows[dgv.Rows.Count - 1];
            object[] rowData = new object[lastRow.Cells.Count];
            for (int i = 0; i < lastRow.Cells.Count; i++)
            {
                rowData[i] = lastRow.Cells[i].Value;
            }

            try
            {
                if (dgv.Columns.Contains("email"))
                {
                    string email = lastRow.Cells["email"].Value?.ToString() ?? null;

                    if (string.IsNullOrEmpty(email) && dgv == dsnv)
                    {
                        MessageBox.Show("Định dạng mail không chính xác | Email format is incorrect !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {

                            string id = lastRow.Cells["manv"].Value.ToString();
                        DatabaseAccess.InsertData(tableName, dgv.Columns.Cast<DataGridViewColumn>().Select(c => c.DataPropertyName).ToArray(), rowData);
                        DatabaseAccess.insertTK(id);
                        loadDsTK();
                       
                       
                        
                    }

                   
                }
                else if (dgv == dsuqcv)
                {
                    // Thêm dữ liệu vào database, bỏ qua cột "songayhethan" khi dgv là dsuqcv
                    List<string> columnNames = new List<string>();
                    List<object> values = new List<object>();

                    for (int i = 1; i < dgv.Columns.Count; i++)
                    {
                        // Bỏ qua cột "songayhethan"
                        if (dgv.Columns[i].DataPropertyName != "songayhethan")
                        {
                            columnNames.Add(dgv.Columns[i].DataPropertyName);
                            values.Add(rowData[i]);
                        }
                    }
                    DatabaseAccess.InsertData(tableName, columnNames.ToArray(), values.ToArray());
                }
                else
                {
                    // Thêm dữ liệu vào database cho các trường hợp khác
                    DatabaseAccess.InsertData(tableName, dgv.Columns.Cast<DataGridViewColumn>().Select(c => c.DataPropertyName).ToArray(), rowData);
                }
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Dữ liệu đã được lưu vào cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("Data has been saved to database!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Giá trị đã tồn tại trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("The value already exists in the database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Lỗi không xác định xảy ra. Vui lòng thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("An unknown error occurred. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Đã xảy ra lỗi. Vui lòng thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("An error occurred. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private bool CheckDataGridViewData(DataGridView dgv)
        {
            // Kiểm tra xem DataGridView và ngôn ngữ được chọn có tồn tại không
            if (dgv == null || string.IsNullOrEmpty(GlobalSettings.Language))
            {
                // Xử lý lỗi hoặc trả về false nếu không thể kiểm tra dữ liệu
                return false;
            }

            string selectedLanguage = GlobalSettings.Language;

            // Kiểm tra xem có hàng được chọn và có phải là hàng cuối cùng không
            if (dgv.CurrentRow != null && dgv.CurrentCell.RowIndex == dgv.Rows.Count - 1)
            {
                // Lặp qua từng ô trong hàng cuối cùng
                foreach (DataGridViewCell cell in dgv.Rows[dgv.CurrentCell.RowIndex].Cells)
                {
                    // Kiểm tra xem ô đó có giá trị null hoặc rỗng không
                    if (string.IsNullOrEmpty(cell.Value?.ToString()))
                    {
                        // Hiển thị thông báo dựa trên ngôn ngữ được chọn
                        string message = selectedLanguage == "Vietnamese" ?
                            "Vui lòng nhập đầy đủ thông tin cho hàng cuối cùng!" :
                            "Please enter complete information for the last row!";
                        MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        // Đặt ô hiện tại và bắt đầu chỉnh sửa
                        dgv.CurrentCell = dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0];
                        dgv.BeginEdit(true);
                        return false;
                    }
                }
            }

            // Trả về true nếu không có ô nào rỗng
            return true;
        }


        private bool CheckCuDanData(DataGridView dgv)
        {
            string selectedLanguage = GlobalSettings.Language;
            int maCD = Convert.ToInt32(dgv.Rows[dgv.Rows.Count - 1].Cells["maCD"].Value);
            string tenCH = dgv.Rows[dgv.Rows.Count - 1].Cells["tenCH"].Value.ToString();
            DateTime ngaySinh = Convert.ToDateTime(dgv.Rows[dgv.Rows.Count - 1].Cells["ngaySinh"].Value);
       
            if (ngaySinh > DateTime.Now)
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("Date of birth cannot be greater than current date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgv.CurrentCell = dgv.Rows[dgv.Rows.Count - 1].Cells["ngaySinh"];
                return false;
            }

            // Các kiểm tra logic khác ở đây...

            return true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            DataGridView dgv = null;

            if (tabDulieu.SelectedTab == NhanVien)
            {
                dgv = dsnv;
            }
            else if (tabDulieu.SelectedTab == PhongBan)
            {
                dgv = dspb;
            }
            else if (tabDulieu.SelectedTab == TaiKhoan)
            {
                dgv = dstk;
            }
            else if (tabDulieu.SelectedTab == Quyen)
            {
                dgv = dslshd;
            }
            else if (tabDulieu.SelectedTab == DsUyQuyenCV)
            {
                dgv = dsuqcv;

            }

            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];
                object[] rowData = new object[selectedRow.Cells.Count];
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    rowData[i] = selectedRow.Cells[i].Value;
                }

                string primaryKeyColumn = dgv.Columns[0].DataPropertyName;

                try
                {
                   
                    DatabaseAccess.DeleteData(tabDulieu.SelectedTab.Name, new string[] { primaryKeyColumn }, new object[] { rowData[0] });

                    // Sau khi xóa dữ liệu, cần load lại danh sách dữ liệu để cập nhật giao diện
                    if (tabDulieu.SelectedTab == NhanVien)
                    {
                        loadDsNv();
                    }
                    else if (tabDulieu.SelectedTab == PhongBan)
                    {
                        loadDsPhongBan();
                    }
                    else if (tabDulieu.SelectedTab == TaiKhoan)
                    {
                        loadDsTK();
                    }
                    else if (tabDulieu.SelectedTab == Quyen)
                    {
                        loadDsQuyen();
                    }else if (tabDulieu.SelectedTab == DsUyQuyenCV)
                    {
                        loadDsUyQuyenCV();
                    }

                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Đã xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("Data deleted successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("An error occurred while deleting data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("Please select a row to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            DataGridView dgv = null;

            if (tabDulieu.SelectedTab == NhanVien)
            {
                dgv = dsnv;
            }
            else if (tabDulieu.SelectedTab == PhongBan)
            {
                dgv = dspb;
            }
            else if (tabDulieu.SelectedTab == TaiKhoan)
            {
                dgv = dstk;
            }
            else if (tabDulieu.SelectedTab == Quyen)
            {
                dgv = dslshd;
            }
            else if (tabDulieu.SelectedTab == DsUyQuyenCV)
            {
                dgv = dsuqcv;
            }

            if (dgv != null)
            {
                DataGridViewRow selectedRow = dgv.CurrentRow; // Lấy dòng được chọn
                if (selectedRow != null)
                {
                    try
                    {
                        object[] rowData = new object[selectedRow.Cells.Count];
                        for (int i = 0; i < selectedRow.Cells.Count; i++)
                        {
                            rowData[i] = selectedRow.Cells[i].Value;
                        }

                        string primaryKeyColumn = dgv.Columns[0].DataPropertyName;
                        if (dgv.Columns.Contains("email"))
                        {

                            string email = selectedRow.Cells["email"].Value?.ToString() ?? null;

                            if (string.IsNullOrEmpty(email) && !IsEmailValid(email) && dgv == dsnv)
                            {
                                MessageBox.Show("Định dạng mail không chính xác | Email format is incorrect !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;

                            }
                        }else if (dgv == dsuqcv)
                        {
                            List<string> columnNames = new List<string>();
                            List<object> values = new List<object>();

                            for (int i = 1; i < dgv.Columns.Count; i++)
                            {
                                // Bỏ qua cột "songayhethan"
                                if (dgv.Columns[i].DataPropertyName != "songayhethan")
                                {
                                    columnNames.Add(dgv.Columns[i].DataPropertyName);
                                    values.Add(rowData[i]);
                                }
                            }

                            string[] conditionColumns = { primaryKeyColumn };
                            object[] conditionValues = { rowData[0] };

                            // Thực hiện cập nhật dữ liệu
                            DatabaseAccess.UpdateData(tabDulieu.SelectedTab.Name, columnNames.ToArray(), values.ToArray(), conditionColumns, conditionValues);
                            MessageBox.Show(selectedLanguage == "Vietnamese" ? "Đã cập nhật dữ liệu thành công!" : "Data updated successfully!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            string tableName = tabDulieu.SelectedTab.Name;

                            List<string> columnNames = new List<string>();
                            List<object> values = new List<object>();
                            for (int i = 1; i < dgv.Columns.Count; i++)
                            {
                                columnNames.Add(dgv.Columns[i].DataPropertyName);
                                values.Add(rowData[i]);
                            }

                            string[] conditionColumns = { primaryKeyColumn };
                            object[] conditionValues = { rowData[0] };

                            // Thực hiện cập nhật dữ liệu
                            DatabaseAccess.UpdateData(tableName, columnNames.ToArray(), values.ToArray(), conditionColumns, conditionValues);
                            selectedRow.DataGridView.UpdateCellValue(selectedRow.Cells[0].ColumnIndex, selectedRow.Index);

                            dgv.ReadOnly = true;
                            btnCapNhat.Enabled = false;
                           
                            btnsua.Enabled = true;
                            btnxoa.Enabled = true;
                            btnthem.Enabled = true;

                            MessageBox.Show(selectedLanguage == "Vietnamese" ? "Đã cập nhật dữ liệu thành công!" : "Data updated successfully!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while updating selected row data!\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(selectedLanguage == "Vietnamese" ? "Không tìm thấy DataGridView để cập nhật!" : "DataGridView not found to update!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void btnsua_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = btnxoa.Enabled = btnthem.Enabled = false;
            btnCapNhat.Enabled=true;
            DataGridView dgv = null;

      
            if (tabDulieu.SelectedTab == NhanVien)
            {
                dgv = dsnv;
                dsnv.ReadOnly = false;
            }
            else if (tabDulieu.SelectedTab == PhongBan)
            {
                dgv = dspb;
                dspb.ReadOnly = false;
            }
            else if (tabDulieu.SelectedTab == TaiKhoan)
            {
                dgv = dstk;
                dstk.ReadOnly = false;
            }
            else if (tabDulieu.SelectedTab == Quyen)
            {
                dgv = dslshd;
                dslshd.ReadOnly = false;
            }
            else if (tabDulieu.SelectedTab == DsUyQuyenCV)
            {
                dgv = dsuqcv;
                dsuqcv.ReadOnly = false;

            }



        }

        private void FormDuLieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain form = new FormMain();
            form.Show();
            this.Hide();
        }

      
        private void txbtimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Gọi hàm tìm kiếm khi người dùng nhấn phím Enter
                timkiem_Click(sender, e);
            }
        }
        private void timkiem_Click(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            string keyword = txbtimkiem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("Please enter search keywords", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }

            DataGridView dgv = null;

            if (tabDulieu.SelectedTab == NhanVien)
            {
                dgv = dsnv;
            }
            else if (tabDulieu.SelectedTab == PhongBan)
            {
                dgv = dspb;
            }
            else if (tabDulieu.SelectedTab == TaiKhoan)
            {
                dgv = dstk;
            }
            else if (tabDulieu.SelectedTab == Quyen)
            {
                dgv = dslshd;
            }
            else if (tabDulieu.SelectedTab == DsUyQuyenCV)
            {
                dgv = dsuqcv;
            }

            if (dgv != null)
            {
                dgv.ClearSelection();
                bool found = false;

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(keyword))
                        {
                            dgv.Rows[row.Index].Selected = true;
                            dgv.FirstDisplayedScrollingRowIndex = row.Index;
                            found = true;
                            // Không dừng ngay sau khi tìm thấy một hàng
                        }
                    }
                }

                if (!found)
                {
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Không tìm thấy kết quả phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("No matches found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Không có DataGridView nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("No DataGridView selected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void UpdateLanguage()
        {
            // Lấy ngôn ngữ đã chọn từ biến global hoặc một cơ chế khác
            string selectedLanguage = GlobalSettings.Language;

            // Cập nhật ngôn ngữ cho các thành phần giao diện dựa trên ngôn ngữ đã chọn
            if (selectedLanguage == "Vietnamese")
            {
                // Cập nhật các nhãn và các điều khiển khác trong giao diện với ngôn ngữ tiếng Việt
                NhanVien.Text = "Nhân viên";
                PhongBan.Text = "Phòng ban";
                TaiKhoan.Text = "Tài khoản";
                Quyen.Text = "Quyền";
                DsUyQuyenCV.Text = "Uỷ quyền công việc";
                btnCapNhat.Text = "Cập nhật";
                btnluu.Text = "Lưu";
                btnsua.Text = "Sửa";
                btnxoa.Text = "Xóa";
                btnthem.Text = "Thêm";


                dsnv.Columns["manv"].HeaderText = "Mã nhân viên";
                dsnv.Columns["hoten"].HeaderText = "Họ và tên";
                dsnv.Columns["ngaysinh"].HeaderText = "Ngày sinh";
                dsnv.Columns["gioitinh"].HeaderText = "Giới tính";
                dsnv.Columns["diachi"].HeaderText = "Địa chỉ";
                dsnv.Columns["didong"].HeaderText = "Đi động";
                dsnv.Columns["email"].HeaderText = "Email";
                dsnv.Columns["chucvu"].HeaderText = "Chức vụ";
                dsnv.Columns["phongban"].HeaderText = "Phòng ban";
                dsnv.Columns["luong"].HeaderText = "Lương";
                dsnv.Columns["trangthai"].HeaderText = "Trạng thái";
                dsnv.Columns["trinhdohocvan"].HeaderText = "Trình độ học vấn";
                dsnv.Columns["loaihinh"].HeaderText = "Loại hình";
              

                dsuqcv.Columns["maNV_cu"].HeaderText = "Mã nhân viên cũ";
                dsuqcv.Columns["maCV"].HeaderText = "Mã công việc";
                dsuqcv.Columns["maNV_moi"].HeaderText = "Người được ủy quyền";
                dsuqcv.Columns["trangthai"].HeaderText = "Trạng thái";
                dsuqcv.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
                dsuqcv.Columns["songayhethan"].HeaderText = "Số ngày hết hạn";
                dsuqcv.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";
                dsuqcv.Columns["ngaybangiao"].HeaderText = "Ngày bàn giao";

                dspb.Columns["id"].HeaderText = "Mã phòng ban";
                dspb.Columns["ten"].HeaderText = "Tên phòng ban";

                dslshd.Columns["id"].HeaderText = "Mã quyền";
                dslshd.Columns["ten"].HeaderText = "Tên quyền hạn";

                dstk.Columns["id"].HeaderText = "Tên đăng nhập";
                dstk.Columns["mk"].HeaderText = "Mật khẩu";
                dstk.Columns["loaiTK"].HeaderText = "Loại tài khoản";

                buttonXuatPDF.Text = "Xuất PDF";
                buttonExportExcel.Text = "Xuất Excel";

                buttonXuatPDF2.Text = "Xuất PDF";
                buttonExportExcel2.Text = "Xuất Excel";

                buttonXuatPDF3.Text = "Xuất PDF";
                buttonExportExcel3.Text = "Xuất Excel";

                buttonXuatPDF4.Text = "Xuất PDF";
                buttonExportExcel4.Text = "Xuất Excel";
            }
            else if (selectedLanguage == "English")
            {
                // Cập nhật các nhãn và các điều khiển khác trong giao diện với ngôn ngữ tiếng Anh
                NhanVien.Text = "Employee";
                PhongBan.Text = "Department";
                TaiKhoan.Text = "Account";
                Quyen.Text = "Permission";
                btnCapNhat.Text = "Update";
                btnluu.Text = "Save";
                btnsua.Text = "Edit";
                btnxoa.Text = "Delete";
                btnthem.Text = "Add";
                DsUyQuyenCV.Text = "List of permissions";


                dsnv.Columns["manv"].HeaderText = "Employee ID";
                dsnv.Columns["hoten"].HeaderText = "Full Name";
                dsnv.Columns["ngaysinh"].HeaderText = "Date of Birth";
                dsnv.Columns["gioitinh"].HeaderText = "Gender";
                dsnv.Columns["diachi"].HeaderText = "Address";
                dsnv.Columns["didong"].HeaderText = "Mobile";
                dsnv.Columns["email"].HeaderText = "Email";
                dsnv.Columns["chucvu"].HeaderText = "Position";
                dsnv.Columns["phongban"].HeaderText = "Department";
                dsnv.Columns["luong"].HeaderText = "Salary";
                dsnv.Columns["trangthai"].HeaderText = "Status";
                dsnv.Columns["trinhdohocvan"].HeaderText = "Educational Background";
                dsnv.Columns["loaihinh"].HeaderText = "Type";


                dsuqcv.Columns["maNV_cu"].HeaderText = "Old Employee ID";
                dsuqcv.Columns["maCV"].HeaderText = "Job ID";
                dsuqcv.Columns["maNV_moi"].HeaderText = "New Delegate";
                dsuqcv.Columns["trangthai"].HeaderText = "Status";
                dsuqcv.Columns["thoiGianHoanThanh"].HeaderText = "Completion Time";
                dsuqcv.Columns["songayhethan"].HeaderText = "Days Overdue";
                dsuqcv.Columns["Tuychonchiase"].HeaderText = "Sharing Options";
                dsuqcv.Columns["ngaybangiao"].HeaderText = "Handover date";

                dspb.Columns["id"].HeaderText = "Department ID";
                dspb.Columns["ten"].HeaderText = "Department Name";

                dslshd.Columns["id"].HeaderText = "Role ID";
                dslshd.Columns["ten"].HeaderText = "Role Name";

                dstk.Columns["id"].HeaderText = "Username";
                dstk.Columns["mk"].HeaderText = "Password";
                dstk.Columns["loaiTK"].HeaderText = "Account Type";

                buttonXuatPDF.Text = "Export PDF";
                buttonExportExcel.Text = "Export Excel";

                buttonXuatPDF2.Text = "Export PDF";
                buttonExportExcel2.Text = "Export Excel";

                buttonXuatPDF3.Text = "Export PDF";
                buttonExportExcel3.Text = "Export Excel";

                buttonXuatPDF4.Text = "Export PDF";
                buttonExportExcel4.Text = "Export Excel";

                buttonXuatPDF5.Text = "Export PDF";
                buttonExportExcel5.Text = "Export Excel";

            }
        }


        private void buttonExportExcel_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "DataGridViewExport.xlsx";
            saveFileDialog.Filter = "Excel (*xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName, dslshd);
                    Process.Start(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã có lỗi xảy ra trong quá trình xuất file\n" + ex.Message);
                }
            }
        }

        private void buttonExportExcel2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "DataGridViewExport.xlsx";
            saveFileDialog.Filter = "Excel (*xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName, dstk);
                    Process.Start(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã có lỗi xảy ra trong quá trình xuất file\n" + ex.Message);
                }
            }
        }

        private void buttonExportExcel3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "DataGridViewExport.xlsx";
            saveFileDialog.Filter = "Excel (*xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName, dsnv);
                    Process.Start(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã có lỗi xảy ra trong quá trình xuất file\n" + ex.Message);
                }
            }
        }

        private void buttonExportExcel4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "DataGridViewExport.xlsx";
            saveFileDialog.Filter = "Excel (*xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName, dspb);
                    Process.Start(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã có lỗi xảy ra trong quá trình xuất file\n" + ex.Message);
                }
            }
        }

        private void buttonExportExcel5_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "DataGridViewExport.xlsx";
            saveFileDialog.Filter = "Excel (*xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName, dsuqcv);
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
            if (dslshd.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "DataGridViewExport.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var htmlContent = GetHtmlFromDataGridView(dslshd);
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

        private void buttonXuatPDF2_Click(object sender, EventArgs e)
        {
            if (dstk.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "DataGridViewExport.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var htmlContent = GetHtmlFromDataGridView(dstk);
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

        private void buttonXuatPDF3_Click(object sender, EventArgs e)
        {
            if (dsnv.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "DataGridViewExport.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var htmlContent = GetHtmlFromDataGridView(dsnv);
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

        private void buttonXuatPDF4_Click(object sender, EventArgs e)
        {
            if (dspb.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "DataGridViewExport.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var htmlContent = GetHtmlFromDataGridView(dspb);
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

        private void buttonXuatPDF5_Click(object sender, EventArgs e)
        {
            if (dsuqcv.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "DataGridViewExport.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var htmlContent = GetHtmlFromDataGridView(dsuqcv);
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

