using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongViec
{
    public partial class PopUpForm : Form
    {
        public PopUpForm()
        {
            InitializeComponent();
        }

        private void PopUpForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Thông báo cho người dùng", "Tiêu đề thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
