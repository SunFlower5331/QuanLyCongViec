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

namespace QuanLyCongViec
{
    public partial class FormThongKeHieuQuaCongViec : Form
    {
        public FormThongKeHieuQuaCongViec()
        {
            InitializeComponent();
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            LiveCharts.WinForms.PieChart pieChart = new LiveCharts.WinForms.PieChart();
            pieChart.Width = 225;
            pieChart.Height = 225;
            Random rnd = new Random();
            SeriesCollection sers = new SeriesCollection();
            for (int n = 0; n < 5; n++)
            {
                PieSeries ser = new PieSeries();
                ser.Values = new ChartValues<double> { Math.Round(rnd.NextDouble(), 2) };
                ser.Title = "ID" + (n + 1).ToString();
                ser.DataLabels = true;
                sers.Add(ser);
            }

            pieChart.Series = sers;
            pieChart.BackColorTransparent = true;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(pieChart);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LiveCharts.WinForms.PieChart pieChart = new LiveCharts.WinForms.PieChart();
            pieChart.Width = 225;
            pieChart.Height = 225;
            Random rnd = new Random();
            SeriesCollection sers = new SeriesCollection();
            for (int n = 0; n < 5; n++)
            {
                PieSeries ser = new PieSeries();
                ser.Values = new ChartValues<double> { Math.Round(rnd.NextDouble(), 2) };
                ser.Title = "ID" + (n + 1).ToString();
                ser.DataLabels = true;
                sers.Add(ser);
            }

            pieChart.Series = sers;
            pieChart.BackColorTransparent = true;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(pieChart);
        }
    }
}
