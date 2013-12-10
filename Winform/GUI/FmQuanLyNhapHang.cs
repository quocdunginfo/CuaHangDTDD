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
            dtgvDSNhapHang.DataSource = NHCtr._db.ds_nhaphang.ToList();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            FmThongTinNhapHang fm = new FmThongTinNhapHang();
            fm.ShowDialog();

            LoadDTGV_NhapHang();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dtgvDSNhapHang.CurrentCell == null) return;
            NhapHang nh = (NhapHang)dtgvDSNhapHang.SelectedRows[0].DataBoundItem;

            FmThongTinNhapHang fm = new FmThongTinNhapHang(nh);
            fm.ShowDialog();
            NHCtr._db.Entry(nh).Reload();
            dtgvDSNhapHang.Refresh();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dtgvDSNhapHang.CurrentCell == null) return;

            try
            {
                NhapHang nh = (NhapHang)dtgvDSNhapHang.SelectedRows[0].DataBoundItem;              
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc là muốn xoá đơn nhập hàng có tổng tiền " + TextLibrary.ToCommaStringNumber(nh.tongtien) + " chứ ?", "Xoá", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (nh.delete())
                    {
                        MessageBox.Show("Xoá thành công.");
                        LoadDTGV_NhapHang();
                    }
                    else MessageBox.Show("Xoá thất bại.");
                }
            }
            catch (Exception)
            { MessageBox.Show("Lỗi khi xoá sp."); }
        }
    }
}
