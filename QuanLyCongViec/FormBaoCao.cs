using DAL;
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
        //
        private void FormBaoCao_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void loadBaoCaoCanHo(DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            dsch.DataSource = DatabaseAccess.GetDuLieuBaoCaoCanHo(NgayBatDau, NgayKetThuc).Tables[0];
            dsch.AutoGenerateColumns = false;

            dsch.Columns["CongNo"].Visible = checkBoxCongNo.Checked;
            dsch.Columns["TongChiPhiDienNuoc"].Visible = checkBoxTongChiPhi.Checked;
            dsch.Columns["TongphiQuanLy"].Visible = checkBoxTongChiPhi.Checked;
            dsch.Columns["TongphiDichVu"].Visible = checkBoxTongChiPhi.Checked;
            dsch.Columns["tinhTrangNguoiO"].Visible = checkBoxTinhTrangCanHo.Checked;
            dsch.Columns["tinhTrangBanGiao"].Visible = checkBoxTinhTrangCanHo.Checked;
            dsch.Columns["tinhTrangNoiThat"].Visible = checkBoxTinhTrangCanHo.Checked;
            dsch.Columns["quoctich"].Visible = checkBoxQuocTich.Checked;

            dsch.Columns["maCH"].HeaderText = "Mã căn hộ";
            dsch.Columns["tenCH"].HeaderText = "Tên chủ hộ";
            dsch.Columns["CongNo"].HeaderText = "Công nợ";
            dsch.Columns["tinhTrangNguoiO"].HeaderText = "Tình trạng người ở";
            dsch.Columns["tinhTrangBanGiao"].HeaderText = "Tình trạng bàn giao";
            dsch.Columns["tinhTrangNoiThat"].HeaderText = "Tình trạng nội thất";
            dsch.Columns["TongChiPhiDienNuoc"].HeaderText = "Tổng chi phí điện nước";
            dsch.Columns["TongphiQuanLy"].HeaderText = "Tổng chi phí quản lý";
            dsch.Columns["TongPhiDichVu"].HeaderText = "Tổng phí dịch vụ";
            dsch.Columns["quoctich"].HeaderText = "Quốc tịch";
        }

        private void loadBaoCaoTimKiem(DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            dsch.DataSource = DatabaseAccess.GetDuLieuBaoCaoTimKiem(textBoxTimKiem.Text, NgayBatDau, NgayKetThuc).Tables[0];
            dsch.AutoGenerateColumns = false;

            dsch.Columns["CongNo"].Visible = checkBoxCongNo.Checked;
            dsch.Columns["TongChiPhiDienNuoc"].Visible = checkBoxTongChiPhi.Checked;
            dsch.Columns["TongphiQuanLy"].Visible = checkBoxTongChiPhi.Checked;
            dsch.Columns["TongphiDichVu"].Visible = checkBoxTongChiPhi.Checked;
            dsch.Columns["tinhTrangNguoiO"].Visible = checkBoxTinhTrangCanHo.Checked;
            dsch.Columns["tinhTrangBanGiao"].Visible = checkBoxTinhTrangCanHo.Checked;
            dsch.Columns["tinhTrangNoiThat"].Visible = checkBoxTinhTrangCanHo.Checked;
            dsch.Columns["quoctich"].Visible = checkBoxQuocTich.Checked;

            dsch.Columns["maCH"].HeaderText = "Mã căn hộ";
            dsch.Columns["tenCH"].HeaderText = "Tên chủ hộ";
            dsch.Columns["CongNo"].HeaderText = "Công nợ";
            dsch.Columns["tinhTrangNguoiO"].HeaderText = "Tình trạng người ở";
            dsch.Columns["tinhTrangBanGiao"].HeaderText = "Tình trạng bàn giao";
            dsch.Columns["tinhTrangNoiThat"].HeaderText = "Tình trạng nội thất";
            dsch.Columns["TongChiPhiDienNuoc"].HeaderText = "Tổng chi phí điện nước";
            dsch.Columns["TongphiQuanLy"].HeaderText = "Tổng chi phí quản lý";
            dsch.Columns["TongPhiDichVu"].HeaderText = "Tổng phí dịch vụ";
            dsch.Columns["quoctich"].HeaderText = "Quốc tịch";
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dsch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            loadBaoCaoCanHo(dateTimePickerStart.Value.AddDays(-1), dateTimePickerEnd.Value);
        }

        private void textBoxTimKiem_Enter(object sender, EventArgs e)
        {
            if (textBoxTimKiem.Text == "Tìm kiếm theo mã căn hộ")
            {
                textBoxTimKiem.Text = "";
                textBoxTimKiem.ForeColor = Color.Black;
            }
        }
        private void textBoxTimKiem_Leave(object sender, EventArgs e)
        {
            if (textBoxTimKiem.Text == "")
            {
                textBoxTimKiem.Text = "Tìm kiếm theo mã căn hộ";
                textBoxTimKiem.ForeColor = Color.DimGray;
            }
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            loadBaoCaoTimKiem(dateTimePickerStart.Value.AddDays(-1), dateTimePickerEnd.Value);
        }
    }
}
