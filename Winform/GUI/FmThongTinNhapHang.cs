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
    public partial class FmThongTinNhapHang : Form
    {
        bool EditMode = false;
        NhapHangController NHCtr;
        SanPham_ChiTietController SPCTCtr;
        NhapHang nh;
        public FmThongTinNhapHang(NhapHang nh = null)
        {
            InitializeComponent();
            NHCtr = new NhapHangController();
            SPCTCtr = new SanPham_ChiTietController(NHCtr._db);
            dtgvChiTietNH.AutoGenerateColumns = false;
            dtgvChiTietSP.AutoGenerateColumns = false;
            if (nh == null)
            {
                this.nh = new NhapHang(NHCtr._db);
            }
            else
            {
                EditMode = true;
                this.nh = NHCtr.get_by_id(nh.id);
                ThongTinFormNhapHang = this.nh;
            }
            LoadDTGV_ChiTietNH();
            LoadDTGV_ChiTietSP();
        }

        void LoadDTGV_ChiTietNH()
        {
            dtgvChiTietNH.DataSource = null;
            dtgvChiTietNH.DataSource = nh.ds_chitiet_nhaphang;
        }

        void LoadDTGV_ChiTietSP()
        {
            dtgvChiTietSP.DataSource = null;
            dtgvChiTietSP.DataSource = SPCTCtr.timkiem();
        }

        NhapHang ThongTinFormNhapHang
        {
            get
            {
                try
                {
                    NhapHang nh = new NhapHang(NHCtr._db);
   //                 nh.id = Int32.Parse(tbID.Text);
                    nh.active = ckbKichHoat.Checked;
                    nh.ngay = dtpNgay.Value;
                    nh.tongtien_change = tbTongTien.Text;
                    return nh;
                }
                catch (Exception)
                {
                    MessageBox.Show("Thông tin nhập sai.");
                    return null;
                }
            }
            set
            {
                tbID.Text = value.id.ToString();
                ckbKichHoat.Checked = value.active;
                dtpNgay.Value = value.ngay;
                tbTongTien.Text = value.tongtien_change;
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            SanPham_ChiTiet spct = (SanPham_ChiTiet)dtgvChiTietSP.SelectedRows[0].DataBoundItem;

            if (nh.check_exist_spct_in_donhang(spct.id))
            {
                MessageBox.Show("Đơn hàng đã có chứa sản phẩm này rồi.");
                return;
            }

            ChiTiet_NhapHang ctnh = new ChiTiet_NhapHang(NHCtr._db);
            ctnh.soluong = Int32.Parse(tbSoLuong.Text);
            ctnh.dongia = Int32.Parse(tbDonGia.Text);
            ctnh.sanpham_chitiet = spct;

            //set lai tong tien
            int num = TextLibrary.ToInt(tbTongTien.Text);
            num += ctnh.soluong * ctnh.dongia;
            tbTongTien.Text = TextLibrary.ToCommaStringNumber(num);

            nh.ds_chitiet_nhaphang.Add(ctnh);

            LoadDTGV_ChiTietNH();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            NhapHang infoform = ThongTinFormNhapHang;
            if (infoform == null) return;
            nh.change(infoform);

            try
            {
                nh.update_tonkho();
                if (EditMode) nh.update();
                else nh.add();

                MessageBox.Show("Lưu thành công.");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi lưu lại.");
            }
        }
    }
}
