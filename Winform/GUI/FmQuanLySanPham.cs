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
        bool _reload = false;
        SanPhamController SPCtr = new SanPhamController();

        public FmQuanLySanPham()
        {
            InitializeComponent();
            dtgvDSSanPham.AutoGenerateColumns = false;
            LoadDTGV_DSSanPham();
        }

        public void LoadDTGV_DSSanPham()
        {
 //           IBindingList te = new BindingList<SanPham>(list);
  //          if (dtgvDSSanPham.Rows.Count > 0) dtgvDSSanPham.Rows.Clear();
            dtgvDSSanPham.DataSource = null;
            dtgvDSSanPham.DataSource = SPCtr.timkiem();
            //foreach (SanPham sp in list)
            //{
            //    dtgvDSSanPham.Rows.Add(sp.id, sp.masp, sp.ten, sp._get_hinhanh_macdinh()._get_image(), sp._get_gia(), sp.active, sp.hangsx.ten);
            //}
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dtgvDSSanPham.CurrentCell == null) return;
            try
            {
                SanPham sp = (SanPham)dtgvDSSanPham.SelectedRows[0].DataBoundItem;
                //           DialogResult dialogResult = MessageBox.Show("Bạn có chắc là muốn xoá sản phẩm " + dtgvDSSanPham["ten",rowindex].Value, "Xoá", MessageBoxButtons.YesNo);
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc là muốn xoá sản phẩm " + sp.ten, "Xoá", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (sp.delete())
                    {
                        MessageBox.Show("Xoá thành công.");
                        LoadDTGV_DSSanPham();
                    }
                    else MessageBox.Show("Xoá thất bại.");
                }
            }
            catch (Exception)
            { MessageBox.Show("Lỗi khi xoá sp."); }
            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            FmThongTinSanPham fm = new FmThongTinSanPham(null);
            fm.ShowDialog();
  //          SPCtr = new SanPhamController();

            LoadDTGV_DSSanPham();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dtgvDSSanPham.CurrentCell == null) return;
            SanPham sp = (SanPham)dtgvDSSanPham.SelectedRows[0].DataBoundItem;
            FmThongTinSanPham fm = new FmThongTinSanPham(sp);
            fm.ShowDialog();
  //          SanPham sp1 = SPCtr.get_by_id(sp.id);
            SPCtr = new SanPhamController();
   //         dtgvDSSanPham.Refresh();
  //          SPCtr._db.Entry<SanPham>(sp).Reload();
  //          for (int i = 0; i < sp.ds_hinhanh.Count; i++)
  //              SPCtr._db.Entry<HinhAnh>(sp.ds_hinhanh[i]).Reload();
  //          dtgvDSSanPham.Refresh();
    //        Image img = sp1.anhmacdinh;
      //      foreach(HinhAnh ha in sp.ds_hinhanh)
      //      {
      //          SPCtr._db.Entry<HinhAnh>(ha).Reload();
      //      }
           LoadDTGV_DSSanPham();
        }
    }
}
