using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseClass.ModelControllers;
using BaseClass.Models;

namespace Winform.GUI
{
    public partial class FmThongTinDonHang : Form
    {
        DonHang dh;
        public FmThongTinDonHang(DonHang dh = null)
        {
            InitializeComponent();
            dtgvChiTietNH.AutoGenerateColumns = false;

            if (dh == null) this.dh = new DonHang();
            else
            {
                this.dh = dh;
                ThongTinFormDonHang = this.dh;
                LoadDTGV_ChiTietDonHang();
            }      
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DonHang ThongTinFormDonHang
        {
            set
            {
                ckbKichHoat.Checked = value.active;
                ckbDaGiaoHang.Checked = value.dagiaohang;
                lbID.Text = value.id.ToString();
                lbNgay.Text = value.ngay_to_string;
                lbTongTien.Text = value.tongtien_change;
                lbTenKH.Text = value.kh_ten;
                lbDiaChi.Text = value.kh_diachi;
                lbEmail.Text = value.kh_email;
                lbSDT.Text = value.kh_sdt;
            }
        }

        void LoadDTGV_ChiTietDonHang()
        {
            dtgvChiTietNH.DataSource = null;
            if(dh.ds_chitiet_donhang.Count > 0) dtgvChiTietNH.DataSource = dh.ds_chitiet_donhang;
        }
    }
}
