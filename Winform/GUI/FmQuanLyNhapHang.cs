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
using BaseClass._Library;

namespace Winform.GUI
{
    public partial class FmQuanLyNhapHang : Form
    {
        NhapHangController NHCtr = new NhapHangController();
        public FmQuanLyNhapHang()
        {
            InitializeComponent();
            dtgvDSNhapHang.AutoGenerateColumns = false;
            LoadDTGV_NhapHang();
        }

        void LoadDTGV_NhapHang()
        {
            dtgvDSNhapHang.DataSource = null;
            dtgvDSNhapHang.DataSource = NHCtr.get_list();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            FmThongTinNhapHang fm = new FmThongTinNhapHang(null,NHCtr);
            fm.DTGV_NhapHang = new FmThongTinNhapHang.callback(LoadDTGV_NhapHang);
            fm.ShowDialog();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            if (dtgvDSNhapHang.SelectedRows.Count == 0) return;
            NhapHang nh = (NhapHang)dtgvDSNhapHang.SelectedRows[0].DataBoundItem;
            FmThongTinNhapHang fm = new FmThongTinNhapHang(nh,NHCtr);
            fm.ShowDialog();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
