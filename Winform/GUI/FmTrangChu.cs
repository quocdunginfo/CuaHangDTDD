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
using BaseClass.ModelControllers;
using BaseClass.Models;

namespace Winform.GUI
{
    public partial class FmTrangChu : Form
    {
        SettingController SCtr = new SettingController();
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

        private void btQuanLyDonHang_Click(object sender, EventArgs e)
        {
            FmQuanLyDonHang fm = new FmQuanLyDonHang();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void btQuanLyNhapHang_Click(object sender, EventArgs e)
        {
            FmQuanLyNhapHang fm = new FmQuanLyNhapHang();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void btQuanLyHangSX_Click(object sender, EventArgs e)
        {
            FmQuanLyHangSanXuat fm = new FmQuanLyHangSanXuat();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void btThongKeTonKho_Click(object sender, EventArgs e)
        {
            FmThongKeTonKho fm = new FmThongKeTonKho();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void btBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            FmBaoCaoDoanhThu fm = new FmBaoCaoDoanhThu();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btChinhDiaChiWeb_Click(object sender, EventArgs e)
        {
            Setting st = SettingController.get_by_key("path_to_website");
            InputDialog ip = new InputDialog("Địa chỉ trang Web", "Giá trị: ", (st != null) ? st.value : "http://");
            if (ip.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if(st == null)
                {
                    // new 
                    Setting _st = new Setting{ key = "path_to_website", value = ip.GiaTri};
                    if(SCtr.add(_st) > 0) MessageBox.Show("Chỉnh thành công.");
                    else MessageBox.Show("Chỉnh thất bại.");
                }
                else
                {
                    //modify
                    Setting _st = SCtr.get_by_id(st.id);
                    _st.value = ip.GiaTri;
                    SCtr.save(); 
                    MessageBox.Show("Chỉnh thành công.");
                }
            }
        }
    }
}
