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
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();

            //dsch.CellFormatting += dsch_CellFormatting;
            //dsyc.CellFormatting += dsyc_CellFormatting;
        }

        //private void dsch_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    dsch.EnableHeadersVisualStyles = false;
        //    dsch.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //    foreach (DataGridViewRow row in dsch.Rows)
        //    {
        //        for (int i = 0; i < row.Cells.Count; i++)
        //        {
        //            dsch.Columns[i].HeaderCell.Style.SelectionBackColor = dsch.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(160, 0, 0);

        //            row.Cells[i].Style.BackColor = Color.FromArgb(56, 56, 56);
        //                row.Cells[i].Style.ForeColor = Color.White;

        //        }
        //    }
        //}
        //private void dsyc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    dsyc.EnableHeadersVisualStyles = false;
        //    dsyc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //    foreach (DataGridViewRow row in dsyc.Rows)
        //    {
        //        for (int i = 0; i < row.Cells.Count; i++)
        //        {
        //            dsyc.Columns[i].HeaderCell.Style.SelectionBackColor = dsyc.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(160, 0, 0);

        //                row.Cells[i].Style.BackColor = Color.FromArgb(56, 56, 56);
        //                row.Cells[i].Style.ForeColor = Color.White;

        //        }
        //    }
        //}

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

        private void FormBaoCao_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            UpdateLanguage();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        //
        private void UpdateLanguage()
        {
            // Lấy ngôn ngữ đã chọn từ biến global hoặc một cơ chế khác
            string selectedLanguage = GlobalSettings.Language;

            // Cập nhật ngôn ngữ cho các thành phần giao diện dựa trên ngôn ngữ đã chọn
            if (selectedLanguage == "Vietnamese")
            {
                label1.Text = "Tìm kiếm:";
                label2.Text = "Kết quả:";
                groupBox1.Text = "Danh sách căn hộ";
                groupBox2.Text = "Yêu cầu dịch vụ";
                buttonTimKiem1.Text = "Tìm kiếm";
                buttonTiemKiem2.Text = "Tìm kiếm";

                dsch.Columns["MaCH"].HeaderText = "Mã căn hộ";
                dsch.Columns["TenCH"].HeaderText = "Tên căn hộ";
                dsch.Columns["TinhTrang"].HeaderText = "Tình trạng";
                dsch.Columns["CongNo"].HeaderText = "Công nợ";
                dsch.Columns["CPDienNuoc"].HeaderText = "Chi phí điện nước";
                dsch.Columns["CPQuanLy"].HeaderText = "Chi phí quản lý";
                dsch.Columns["CPKhac"].HeaderText = "Chi phí khác";
                dsch.Columns["XemThongTin"].HeaderText = "Xem thông tin";

                dsyc.Columns["MaCH_YC"].HeaderText = "Mã căn hộ";
                dsyc.Columns["NguoiYC"].HeaderText = "Người yêu cầu";
                dsyc.Columns["DichVuDinhKy"].HeaderText = "Dịch vụ định kỳ";
                dsyc.Columns["NgayYC"].HeaderText = "Ngày yêu cầu";
                dsyc.Columns["NDYC"].HeaderText = "Nội dung yêu cầu";
                dsyc.Columns["TinhTrang_YC"].HeaderText = "Tình trạng";
                dsyc.Columns["NVPhuTrach"].HeaderText = "Nhân viên phụ trách";
                dsyc.Columns["GhiChu"].HeaderText = "Ghi chú";
            }
            else if (selectedLanguage == "English")
            {
                label1.Text = "Search:";
                label2.Text = "Result:";
                groupBox1.Text = "Apartment List";
                groupBox2.Text = "Service Requests";
                buttonTimKiem1.Text = "Search";
                buttonTiemKiem2.Text = "Search";

                dsch.Columns["MaCH"].HeaderText = "Apartment ID";
                dsch.Columns["TenCH"].HeaderText = "Apartment Name";
                dsch.Columns["TinhTrang"].HeaderText = "Status";
                dsch.Columns["CongNo"].HeaderText = "Debt";
                dsch.Columns["CPDienNuoc"].HeaderText = "Electricity and Water Costs";
                dsch.Columns["CPQuanLy"].HeaderText = "Management Costs";
                dsch.Columns["CPKhac"].HeaderText = "Other Costs";
                dsch.Columns["XemThongTin"].HeaderText = "View Details";

                dsyc.Columns["MaCH_YC"].HeaderText = "Apartment ID";
                dsyc.Columns["NguoiYC"].HeaderText = "Requester";
                dsyc.Columns["DichVuDinhKy"].HeaderText = "Regular Services";
                dsyc.Columns["NgayYC"].HeaderText = "Request Date";
                dsyc.Columns["NDYC"].HeaderText = "Request Content";
                dsyc.Columns["TinhTrang_YC"].HeaderText = "Status";
                dsyc.Columns["NVPhuTrach"].HeaderText = "Assigned Staff";
                dsyc.Columns["GhiChu"].HeaderText = "Note";
            }
        }
    }
}
