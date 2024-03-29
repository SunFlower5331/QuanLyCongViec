﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanLyCongViec
{
    public partial class FormDuLieuNhanVien : Form
    {
       

        public FormDuLieuNhanVien()
        {
            InitializeComponent();
        }

        private void FormDuLieu_Load(object sender, EventArgs e)
        {
            loadDsNv();
            loadDsPhongBan();
            loadDsTK();

            loadDsQuyen();
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
            dsnv.Columns["quyenhan"].HeaderText = "Quyền hạn";
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
                }
                else if (tabDulieu.SelectedTab == PhongBan)
                {
                    SaveLastRowData(dspb, "PhongBan");
                }
                else if (tabDulieu.SelectedTab == TaiKhoan)
                {
                    SaveLastRowData(dstk, "TaiKhoan");
                }
                else if (tabDulieu.SelectedTab == Quyen)
                {
                    SaveLastRowData(dslshd, "Quyen");
                }
              
            }
        }

        private void SaveLastRowData(DataGridView dgv, string tableName)
        {
            
            DataGridViewRow lastRow = dgv.Rows[dgv.Rows.Count - 1]; 
            object[] rowData = new object[lastRow.Cells.Count];
            for (int i = 0; i < lastRow.Cells.Count; i++)
            {
                rowData[i] = lastRow.Cells[i].Value;
            }

            try
            {
                DatabaseAccess.InsertData(tableName, dgv.Columns.Cast<DataGridViewColumn>().Select(c => c.DataPropertyName).ToArray(), rowData);

                MessageBox.Show("Dữ liệu đã được lưu vào cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Giá trị đã tồn tại trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi không xác định xảy ra. Vui lòng thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Đã xảy ra lỗi. Vui lòng thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private bool CheckDataGridViewData(DataGridView dgv)
        {
            if (dgv.CurrentRow != null && dgv.CurrentCell.RowIndex == dgv.Rows.Count - 1)
            {
                foreach (DataGridViewCell cell in dgv.Rows[dgv.CurrentCell.RowIndex].Cells)
                {
                    if (string.IsNullOrEmpty(cell.Value?.ToString()))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin cho hàng cuối cùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dgv.CurrentCell = dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0];
                        dgv.BeginEdit(true);
                        return false;
                    }
                }

                // Kiểm tra dữ liệu cụ thể của DataGridView nếu cần
                /*   bool isDataValid = true;
                   if (dgv == dscudan)
                   {
                       isDataValid &= CheckCuDanData(dgv);
                   }
                   // Thêm các kiểm tra dữ liệu của DataGridView khác nếu cần

                   if (!isDataValid)
                   {
                       return false;
                   }
              
            
            */
            }

            return true;
        }


        private bool CheckCuDanData(DataGridView dgv)
        {
        
            int maCD = Convert.ToInt32(dgv.Rows[dgv.Rows.Count - 1].Cells["maCD"].Value);
            string tenCH = dgv.Rows[dgv.Rows.Count - 1].Cells["tenCH"].Value.ToString();
            DateTime ngaySinh = Convert.ToDateTime(dgv.Rows[dgv.Rows.Count - 1].Cells["ngaySinh"].Value);
       
            if (ngaySinh > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgv.CurrentCell = dgv.Rows[dgv.Rows.Count - 1].Cells["ngaySinh"];
                return false;
            }

            // Các kiểm tra logic khác ở đây...

            return true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
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
                    // Gọi phương thức xóa dữ liệu
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
                    }

                    MessageBox.Show("Đã xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
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
 

            if (dgv != null)
            {
                List<int> changedRowsIndexes = GetChangedRowsIndexes(dgv);

                foreach (int rowIndex in changedRowsIndexes)
                {
                    DataGridViewRow row = dgv.Rows[rowIndex];
                    object[] rowData = new object[row.Cells.Count];
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        rowData[i] = row.Cells[i].Value;
                    }

          
                    string primaryKeyColumn = dgv.Columns[0].DataPropertyName;

                    try
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

                
                        DatabaseAccess.UpdateData(tableName, columnNames.ToArray(), values.ToArray(), conditionColumns, conditionValues);

                    
                        row.DataGridView.UpdateCellValue(row.Cells[0].ColumnIndex, row.Index);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi khi cập nhật dữ liệu hàng {rowIndex + 1}!\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            
                dgv.ReadOnly = true;
                btnCapNhat.Enabled = false;
                btnluu.Enabled = true;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                btnthem.Enabled = true;

                MessageBox.Show("Đã cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy DataGridView để cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private List<int> GetChangedRowsIndexes(DataGridView dataGridView)
        {
            List<int> changedRowsIndexes = new List<int>();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    bool rowChanged = false;
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && !row.Cells[i].Value.Equals(row.Cells[i].Tag))
                        {
                            rowChanged = true;
                            break;
                        }
                    }

                    if (rowChanged)
                    {
                        changedRowsIndexes.Add(row.Index);
                    }
                }
            }

            return changedRowsIndexes;
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

          

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }

        private void FormDuLieu_FormClosing(object sender, FormClosingEventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CuDan_Click(object sender, EventArgs e)
        {

        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            string keyword = txbtimkiem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


            if (dgv != null)
            {
                dgv.ClearSelection();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(keyword))
                        {
                            dgv.Rows[row.Index].Selected = true;
                            dgv.FirstDisplayedScrollingRowIndex = row.Index;
                            return;
                        }
                    }
                }

                MessageBox.Show("Không tìm thấy kết quả phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có DataGridView nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}

