using LiveCharts.Wpf;
using LiveCharts;
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
using DAL;
using System.Data.SqlClient;
using DTO;
using System.Runtime.ConstrainedExecution;

namespace QuanLyCongViec
{
    public partial class FormThongKeHieuQuaCongViec : Form
    {
        public FormThongKeHieuQuaCongViec()
        {
            InitializeComponent();
            labelDeMucBieuDo.Hide();
            labelDeMucBieuDo2.Hide();
            comboBoThongKe1.SelectedIndex = comboBoThongKe2.SelectedIndex = comboBoxPB.SelectedIndex = 0;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            //dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            //dataGridView2.CellFormatting += dataGridView2_CellFormatting;
        }

        //private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    dataGridView1.EnableHeadersVisualStyles = false;
        //    dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(246, 191, 2);
        //    foreach (DataGridViewRow row in dataGridView1.Rows)
        //    {
        //        for (int i = 0; i < row.Cells.Count; i++)
        //        {
        //            dataGridView1.Columns[i].HeaderCell.Style.SelectionBackColor = dataGridView1.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(175, 2, 0);

        //            row.Cells[i].Style.BackColor = Color.White;
        //            row.Cells[i].Style.ForeColor = Color.Black;

        //        }
        //    }
        //}
        //private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    dataGridView2.EnableHeadersVisualStyles = false;
        //    dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(246, 191, 2);
        //    foreach (DataGridViewRow row in dataGridView2.Rows)
        //    {
        //        for (int i = 0; i < row.Cells.Count; i++)
        //        {
        //            dataGridView2.Columns[i].HeaderCell.Style.SelectionBackColor = dataGridView2.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(175, 2, 0);

        //            row.Cells[i].Style.BackColor = Color.White;
        //            row.Cells[i].Style.ForeColor = Color.Black;

        //        }
        //    }
        //}

        // Dùng để kéo thả cửa sổ
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FormThongKeHieuQuaCongViec_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //

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

        private void loadThongKeHieuQuaCVNV(string maPB, DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            dataGridView1.Columns.Clear();
            if (comboBoThongKe1.Text == "Tổng quan")
            {
                dataGridView1.DataSource = DatabaseAccess.GetDuLieuThongKeHieuQuaCVNVTongQuan(maPB, NgayBatDau, NgayKetThuc).Tables[0];

            }
            else
            {
                dataGridView1.DataSource = DatabaseAccess.GetDuLieuThongKeHieuQuaCVNVChiTiet(maPB, NgayBatDau, NgayKetThuc).Tables[0];

                dataGridView1.Columns["maCV"].HeaderText = "Mã công việc";
                dataGridView1.Columns["ten"].HeaderText = "Tên công việc";
                dataGridView1.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
            }

            dataGridView1.Columns["solantrehan"].HeaderText = "Trễ hạn";
            dataGridView1.Columns["solankhonghoanthanh"].HeaderText = "Không hoàn thành";
            dataGridView1.Columns["solanhoanthanhdunghan"].HeaderText = "Hoàn thành đúng hạn";
            dataGridView1.Columns["solanhoanthanhsom"].HeaderText = "Hoàn thành sớm";

        }

        private void loadThongKeHieuQuaCVPB(string maNV, DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            dataGridView2.Columns.Clear();
            if (comboBoThongKe2.Text == "Tổng quan")
            {
                dataGridView2.DataSource = DatabaseAccess.GetDuLieuThongKeHieuQuaCVPBTongQuan(maNV, NgayBatDau, NgayKetThuc).Tables[0];

                dataGridView2.Columns["doanhthu"].HeaderText = "Doanh thu";
            }
            else
            {
                dataGridView2.DataSource = DatabaseAccess.GetDuLieuThongKeHieuQuaCVPBChiTiet(maNV, NgayBatDau, NgayKetThuc).Tables[0];

                dataGridView2.Columns["maNV"].HeaderText = "Mã nhân viên";
                dataGridView2.Columns["hoten"].HeaderText = "Họ tên";
                dataGridView2.Columns["luong"].HeaderText = "Doanh thu";
            }

            dataGridView2.Columns["solantrehan"].HeaderText = "Trễ hạn";
            dataGridView2.Columns["solankhonghoanthanh"].HeaderText = "Không hoàn thành";
            dataGridView2.Columns["solanhoanthanhdunghan"].HeaderText = "Hoàn thành đúng hạn";
            dataGridView2.Columns["solanhoanthanhsom"].HeaderText = "Hoàn thành sớm";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //show table
            loadThongKeHieuQuaCVNV(textboxMaNV.Text, dateTimePickerStart.Value.AddDays(-1), dateTimePickerEnd.Value);

            //show chart
            DataSet data = GetDataFromSQLNV(textboxMaNV.Text, dateTimePickerStart.Value.AddDays(-1), dateTimePickerEnd.Value);
            if (data.Tables[0].Rows.Count > 0)
            {
                LiveCharts.WinForms.PieChart pieChart = new LiveCharts.WinForms.PieChart();
                pieChart.Width = 225;
                pieChart.Height = 225;
                pieChart.BackColorTransparent = true;

                SeriesCollection seriesCollection = new SeriesCollection();

                DataRow row = data.Tables[0].Rows[0];
                seriesCollection.Add(new PieSeries
                {
                    Title = "Trễ hạn",
                    Values = new ChartValues<int> { Convert.ToInt32(row["solantrehan"]) },
                    DataLabels = true
                });
                seriesCollection.Add(new PieSeries
                {
                    Title = "Không hoàn thành",
                    Values = new ChartValues<int> { Convert.ToInt32(row["solankhonghoanthanh"]) },
                    DataLabels = true
                });
                seriesCollection.Add(new PieSeries
                {
                    Title = "Hoàn thành đúng hạn",
                    Values = new ChartValues<int> { Convert.ToInt32(row["solanhoanthanhdunghan"]) },
                    DataLabels = true
                });
                seriesCollection.Add(new PieSeries
                {
                    Title = "Hoàn thành sớm",
                    Values = new ChartValues<int> { Convert.ToInt32(row["solanhoanthanhsom"]) },
                    DataLabels = true
                });

                pieChart.Series = seriesCollection;
                this.panel1.Controls.Clear();
                this.panel1.Controls.Add(pieChart);
                labelDeMucBieuDo.Show();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // show table
            loadThongKeHieuQuaCVPB(comboBoxPB.Text, dateTimePickerStart2.Value.AddDays(-1), dateTimePickerEnd2.Value);

            //show chart
            DataSet data = GetDataFromSQLPB(comboBoxPB.Text, dateTimePickerStart2.Value.AddDays(-1), dateTimePickerEnd2.Value);
            if (data.Tables[0].Rows.Count > 0)
            {
                LiveCharts.WinForms.PieChart pieChart = new LiveCharts.WinForms.PieChart();
                pieChart.Width = 225;
                pieChart.Height = 225;
                pieChart.BackColorTransparent = true;

                SeriesCollection seriesCollection = new SeriesCollection();

                DataRow row = data.Tables[0].Rows[0];
                seriesCollection.Add(new PieSeries
                {
                    Title = "Trễ hạn",
                    Values = new ChartValues<int> { Convert.ToInt32(row["solantrehan"]) },
                    DataLabels = true
                });
                seriesCollection.Add(new PieSeries
                {
                    Title = "Không hoàn thành",
                    Values = new ChartValues<int> { Convert.ToInt32(row["solankhonghoanthanh"]) },
                    DataLabels = true
                });
                seriesCollection.Add(new PieSeries
                {
                    Title = "Hoàn thành đúng hạn",
                    Values = new ChartValues<int> { Convert.ToInt32(row["solanhoanthanhdunghan"]) },
                    DataLabels = true
                });
                seriesCollection.Add(new PieSeries
                {
                    Title = "Hoàn thành sớm",
                    Values = new ChartValues<int> { Convert.ToInt32(row["solanhoanthanhsom"]) },
                    DataLabels = true
                });

                pieChart.Series = seriesCollection;
                this.panel2.Controls.Clear();
                this.panel2.Controls.Add(pieChart);
                labelDeMucBieuDo2.Show();
            }
        }

        private DataSet GetDataFromSQLNV(string maNV, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return DatabaseAccess.GetDuLieuThongKeHieuQuaCVNVTongQuan(maNV, ngayBatDau, ngayKetThuc);
        }

        private DataSet GetDataFromSQLPB(string maPB, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return DatabaseAccess.GetDuLieuThongKeHieuQuaCVPBTongQuan(maPB, ngayBatDau, ngayKetThuc);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
