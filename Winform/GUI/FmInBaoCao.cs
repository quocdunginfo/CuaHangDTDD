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
using Microsoft.Reporting.WinForms;

namespace Winform.GUI
{
    public partial class FmInBaoCao : Form
    {
        private List<ChiTiet_DonHang> ds_chitiet_donhang;
        private string tongcong = "";

        public FmInBaoCao(List<ChiTiet_DonHang> ds_chitiet_donhang, string tongcong)
        {
            InitializeComponent();
            this.ds_chitiet_donhang = ds_chitiet_donhang;
            if (tongcong == "") this.tongcong = "0";
            else this.tongcong = tongcong;
        }

        private void FmInBaoCao_Load(object sender, EventArgs e)
        {
            this.ChiTiet_DonHangBindingSource.DataSource = ds_chitiet_donhang;
            ReportParameter rp1 = new ReportParameter("tieude", "BÁO CÁO DOANH THU");
            this.rvKhungBaoCao.LocalReport.SetParameters(rp1);

            ReportParameter rp2 = new ReportParameter("tongcong", tongcong);
            this.rvKhungBaoCao.LocalReport.SetParameters(rp2);

            this.rvKhungBaoCao.RefreshReport();
        }
    }
}
