﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            
        }

        //private void dscv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    dscv.EnableHeadersVisualStyles = false;
        //    dscv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //    foreach (DataGridViewRow row in dscv.Rows)
        //    {
        //        for (int i = 0; i < row.Cells.Count; i++)
        //        {
        //            dscv.Columns[i].HeaderCell.Style.SelectionBackColor = dscv.Columns[i].HeaderCell.Style.BackColor = Color.Firebrick;

        //            row.Cells[i].Style.BackColor = Color.White;
        //            row.Cells[i].Style.ForeColor = Color.Black;

        //        }
        //    }
        //}
        //private void dsnv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    dsnv.EnableHeadersVisualStyles = false;
        //    dsnv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //    foreach (DataGridViewRow row in dsnv.Rows)
        //    {
        //        for (int i = 0; i < row.Cells.Count; i++)
        //        {
        //            dsnv.Columns[i].HeaderCell.Style.SelectionBackColor = dsnv.Columns[i].HeaderCell.Style.BackColor = Color.Firebrick;

        //            row.Cells[i].Style.BackColor = Color.FromArgb(56, 56, 56);
        //            row.Cells[i].Style.ForeColor = Color.White;

        //        }
        //    }
        //}

        private void tuychonhienthi()
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
        }
        private void loadData(string phongBan)
        {
            dsnv.DataSource = DatabaseAccess.GetNhanVienTheoPhongBan(phongBan).Tables[0];
            dsnv.AutoGenerateColumns = false;
            dsnv.Columns["chucvu"].HeaderText = "Chức vụ";
            dsnv.Columns["manv"].HeaderText = "Mã nhân viên";
            dsnv.Columns["hoten"].HeaderText = "Họ và tên";

            dscv.DataSource = DatabaseAccess.GetCTCVTheoPhongBan(phongBan).Tables[0];
            dscv.AutoGenerateColumns = false;

            dscv.Columns["chucvu"].HeaderText = "Chức vụ";
            dscv.Columns["maCV"].HeaderText = "Mã công việc";
            dscv.Columns["ten"].HeaderText = "Tên công việc";
            dscv.Columns["maNV"].HeaderText = "Mã nhân viên";
            dscv.Columns["hoten"].HeaderText = "Tên nhân viên";
            dscv.Columns["trangthai"].HeaderText = "Trạng thái";
            dscv.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
            dscv.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";
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
                    // Gán dữ liệu cho DataGridView
                    dscv.DataSource = dataTable;

                    // Thiết lập tiêu đề cột
                    dscv.Columns["maCV"].HeaderText = "Mã công việc";
                    dscv.Columns["ten"].HeaderText = "Tên công việc";
                    dscv.Columns["maCH"].HeaderText = "Mã căn hộ";
                    dscv.Columns["trangthai"].HeaderText = "Trạng thái";
                    dscv.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
                    dscv.Columns["songayhethan"].HeaderText = "Số ngày còn lại";
                    dscv.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";

                    // Lặp qua từng hàng trong DataGridView
                    foreach (DataGridViewRow dgvRow in dscv.Rows)
                    {
                        // Lấy giá trị của cột "songayhethan" trong hàng hiện tại
                        int soNgayHetHan = Convert.ToInt32(dgvRow.Cells["songayhethan"].Value);

                        // Kiểm tra nếu số ngày còn lại nhỏ hơn 0, tô màu đỏ cho hàng đó
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
            if(cbotuychonchiase.SelectedIndex == 2) {
                dsmanv.Visible = true;
            }
            else
            {
                dsmanv.Visible = false;
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
            dsmanv.Visible = false;
            cbotuychonchiase.SelectedIndex = -1;
            cbotrangthai.SelectedIndex = -1;
        }

        private void dsnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tuychonhienthi();
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
        //
    }
}
