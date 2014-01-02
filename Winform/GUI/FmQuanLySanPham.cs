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
using System.IO;
using System.Net;

namespace Winform.GUI
{
    public partial class FmQuanLySanPham : Form
    {
        SanPhamController SPCtr = new SanPhamController();

        public FmQuanLySanPham()
        {
            InitializeComponent();
            dtgvDSSanPham.AutoGenerateColumns = false;
            LoadDTGV_DSSanPham();
        }

        public void LoadDTGV_DSSanPham()
        {
            dtgvDSSanPham.DataSource = null;
            dtgvDSSanPham.DataSource = SPCtr.timkiem();
        }

        public void RefreshDTGV_DSSanPham()
        {
            dtgvDSSanPham.Refresh();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dtgvDSSanPham.SelectedRows.Count == 0) return;
            SanPham sp = (SanPham)dtgvDSSanPham.SelectedRows[0].DataBoundItem;
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc là muốn xoá sản phẩm " + sp.ten + " chứ?", "Xoá", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (SanPham_ChiTiet spct in sp.ds_sanpham_chitiet)
                {
                    if (spct.check_relation_entities_exist())
                    {
                        MessageBox.Show("Không xoá được do có các hoá đơn chứa sản phẩm này.");
                        return;
                    }
                }
                sp._set_context(SPCtr._db);
                if (sp.delete())
                {
                    MessageBox.Show("Xoá thành công.");
                    LoadDTGV_DSSanPham();
                }
                else MessageBox.Show("Xoá thất bại.");
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            FmThongTinSanPham fm = new FmThongTinSanPham(null,SPCtr);
            fm.DTGV_DSSanPham = new FmThongTinSanPham.callback(this.LoadDTGV_DSSanPham);
            fm.ShowDialog();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dtgvDSSanPham.SelectedRows.Count == 0) return;
            SanPham sp = (SanPham)dtgvDSSanPham.SelectedRows[0].DataBoundItem;
            FmThongTinSanPham fm = new FmThongTinSanPham(sp,SPCtr);
            fm.DTGV_DSSanPham = new FmThongTinSanPham.callback(this.RefreshDTGV_DSSanPham);
            fm.ShowDialog();
        }
    }
}
