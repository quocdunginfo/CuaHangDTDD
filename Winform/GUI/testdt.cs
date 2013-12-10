using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseClass.Models;
using BaseClass.ModelControllers;

namespace Winform.GUI
{
    public partial class testdt : Form
    {
        MauSacController msctr = new MauSacController();
        public testdt()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
  //          msctr.Binding_DB_To_ListTemp();
 //           dataGridView1.DataSource = msctr.ds_mausac;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MauSac ms = (MauSac)dataGridView1.SelectedRows[0].DataBoundItem;
            msctr._db.ds_mausac.Remove(ms);
            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MauSac ms = (MauSac)dataGridView1.SelectedRows[0].DataBoundItem;
            textBox1.Text = ms.giatri;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MauSac ms = new MauSac();
            ms.giatri = textBox1.Text;
            msctr._db.ds_mausac.Add(ms);
   //         dataGridView1.AllowUserToAddRows = true;
            dataGridView1.Rows.Add(ms.id,ms.giatri,ms.active);
    //        dataGridView1.AllowUserToAddRows = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IBindingList list = new BindingList<MauSac>(msctr.timkiem());
            dataGridView1.DataSource = list;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SanPhamController spc = new SanPhamController();
            SanPham sp = spc.get_by_id(3);

            HinhAnh ha = new HinhAnh();
            ha.duongdan = "123";
            sp.ds_hinhanh.Add(ha);

            sp.update();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SanPhamController spc = new SanPhamController();
            SanPham sp = spc.get_by_id(3);
            sp.mota += "4";
            sp.update();
        }
    }
}
