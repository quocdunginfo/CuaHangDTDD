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
    public partial class FmQuanLyDonHang : Form
    {
        DonHangController DHCtr = new DonHangController();
        public FmQuanLyDonHang()
        {
            InitializeComponent();
            dtgvDSDonHang.AutoGenerateColumns = false;
            LoadDTGV_DSDonHang();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadDTGV_DSDonHang()
        {
            dtgvDSDonHang.DataSource = null;
            dtgvDSDonHang.DataSource = DHCtr.get_list();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            if (dtgvDSDonHang.SelectedRows.Count == 0) return;
            DonHang dh = (DonHang)dtgvDSDonHang.SelectedRows[0].DataBoundItem;
            FmThongTinDonHang fm = new FmThongTinDonHang(dh);
            fm.ShowDialog();
        }

        private void btChuyenTrangThaiDonHang_Click(object sender, EventArgs e)
        {
            if (dtgvDSDonHang.SelectedRows.Count == 0) return;
            DonHang dh = (DonHang)dtgvDSDonHang.SelectedRows[0].DataBoundItem;
            if (dh.dagiaohang)
            {
                MessageBox.Show("Đơn hàng đã giao rồi nên không thể chuyển trạng thái.");
                return;
            }

            string hoi = "Bạn có chắc là muốn chuyển đơn hàng có id " + dh.id + " từ Chưa Giao Hàng sang Đã Giao Hàng chứ ?";
            DialogResult dialogResult = MessageBox.Show(hoi, "Xoá", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dh.set_status();
                try
                {
                    if (dh.update())
                    {
                        MessageBox.Show("Đổi trạng thái thành công.");
                        dtgvDSDonHang.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Đổi thất bại.");
                        dh.set_status();
                    } 
                }
                catch (Exception)
                { MessageBox.Show("Lỗi khi lưu lại."); dh.set_status(); }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dtgvDSDonHang.SelectedRows.Count == 0) return;
            DonHang dh = (DonHang)dtgvDSDonHang.SelectedRows[0].DataBoundItem;
            if (dh.dagiaohang)
            {
                MessageBox.Show("Đơn hàng đã giao rồi nên không thể xoá.");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc là muốn xoá đơn hàng có id  " + dh.id + " chứ ?", "Xoá", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (dh.delete())
                {
                    MessageBox.Show("Xoá thành công.");
                    LoadDTGV_DSDonHang();
                }
                else MessageBox.Show("Xoá thất bại.");
            }
        }

        private void dtgvDSDonHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvDSDonHang.SelectedRows.Count == 0) return;
            DonHang dh = (DonHang)dtgvDSDonHang.SelectedRows[0].DataBoundItem;
            btXoa.Enabled = !dh.dagiaohang;
            btChuyenTrangThaiDonHang.Enabled = !dh.dagiaohang;
        }
    }
}
