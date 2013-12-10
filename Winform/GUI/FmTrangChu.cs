using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.GUI;

namespace Winform.GUI
{
    public partial class FmTrangChu : Form
    {
        public FmTrangChu()
        {
            InitializeComponent();
        }

        private void btQuanLySanPham_Click(object sender, EventArgs e)
        {
            FmQuanLySanPham fm = new FmQuanLySanPham();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }
    }
}
