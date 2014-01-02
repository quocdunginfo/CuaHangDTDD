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
    public partial class FmQuanLyHangSanXuat : Form
    {
        HangSXController HSXCtr;
        public FmQuanLyHangSanXuat()
        {
            InitializeComponent();
            dtgvHangSX.AutoGenerateColumns = false;
            HSXCtr = new HangSXController();
            LoadDTGV_HangSX();
        }

        public void LoadDTGV_HangSX()
        {
            dtgvHangSX.DataSource = null;
            dtgvHangSX.DataSource = HSXCtr.timkiem();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            btXoa.Enabled = false;
            btSua.Enabled = false;
            gbThongTin.Enabled = true;
            ThongTinFormHangSX = new HangSX();
        }

        HangSX ThongTinFormHangSX
        {
            get
            {
                HangSX hsx = new HangSX();
                hsx.ten = tbTen.Text.Trim();
                if (hsx.ten.Length == 0)
                {
                    MessageBox.Show("Nhập lại tên hãng sản xuất.");
                    return null;
                }
                hsx.active = chkKichHoat.Checked;
                return hsx;
            }
            set
            {
                tbID.Text = value.id.ToString();
                tbTen.Text = value.ten;
                chkKichHoat.Checked = value.active;
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dtgvHangSX.SelectedRows.Count == 0) return;
            btXoa.Enabled = false;
            btThem.Enabled = false;
            gbThongTin.Enabled = true;
            ThongTinFormHangSX = (HangSX)dtgvHangSX.SelectedRows[0].DataBoundItem;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dtgvHangSX.SelectedRows.Count == 0) return;
            HangSX hsx = (HangSX)dtgvHangSX.SelectedRows[0].DataBoundItem;
            if (hsx.check_relation_entities_exist())
            {
                MessageBox.Show("Không xoá được vì có sản phẩm liên quan đến hãng này.");
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc là muốn xoá Hãng SX  " + hsx.ten + " chứ ?", "Xoá", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                hsx._set_context(HSXCtr._db);
                if (hsx.delete())
                {
                    MessageBox.Show("Xoá thành công.");
                    LoadDTGV_HangSX();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại.");
                }
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            btThem.Enabled = true;
            btSua.Enabled = true;
            btXoa.Enabled = true;
            gbThongTin.Enabled = false;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            HangSX infoform = ThongTinFormHangSX;
            if (infoform == null) return;
            if (btThem.Enabled)
            {
                HSXCtr.add(infoform);
                MessageBox.Show("Thêm thành công.");
                LoadDTGV_HangSX();
                gbThongTin.Enabled = false;
                btXoa.Enabled = true;
                btSua.Enabled = true;
            }
            else
            {
                HangSX hsx = (HangSX)dtgvHangSX.SelectedRows[0].DataBoundItem;
                hsx._set_context(HSXCtr._db);
                hsx.change(infoform);
                hsx.update();
                MessageBox.Show("Sửa thành công.");
                dtgvHangSX.Refresh();
                gbThongTin.Enabled = false;
                btXoa.Enabled = true;
                btThem.Enabled = true;
            }
        }
    }
}
