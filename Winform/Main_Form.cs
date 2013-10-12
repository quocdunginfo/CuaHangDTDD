using CuaHangDTDD.Controllers.ModelController;
using CuaHangDTDD.Models;
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
        public Main_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVienController ctr=new NhanVienController();
            NhanVien_ChiTiet f = new NhanVien_ChiTiet();
            f.obj = ctr.get_by_username("admin");
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NhanVien_ChiTiet f = new NhanVien_ChiTiet();
            f.obj = new NhanVien();
            f.mode = "them";
            f.ShowDialog();
        }
    }
}
