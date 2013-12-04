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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HinhAnhController ctr=new HinhAnhController();
            HinhAnh obj = ctr.get_by_id(1);
            pictureBox1.ImageLocation = obj._get_full_duongdan();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            textBox1.Text = op.FileName;
            SanPhamController ctr1 = new SanPhamController();
            HinhAnhController ctr = new HinhAnhController();
            HinhAnh re = ctr.upload_winform_use_only(textBox1.Text);
            SanPham obj = ctr1.get_by_id(7);
            obj.ds_hinhanh.Add(re);
            obj.update();
        }
    }
}
