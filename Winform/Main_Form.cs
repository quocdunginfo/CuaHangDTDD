using BaseClass.ModelControllers;
using BaseClass.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class Main_Form : Form
    {
        SanPhamController _ctr;
        public Main_Form()
        {
            InitializeComponent();
            _ctr = new SanPhamController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<SanPham> list = _ctr.timkiem();
            this.dataGridView1.DataSource = list;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SanPham obj= (SanPham)this.dataGridView1.SelectedRows[0].DataBoundItem;
            obj.ten = "hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh";
            obj.update();
        }
    }
}
