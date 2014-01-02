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
        bool IsSave = false;
        bool ViewMode = false;
        NhapHangController NHCtr;
        SanPham_ChiTietController SPCTCtr;
        NhapHang nh;

        public delegate void callback();
        public callback DTGV_NhapHang;
        public FmThongTinNhapHang(NhapHang nh = null, NhapHangController nhctr = null)
        {
            InitializeComponent();
            if (nhctr == null) NHCtr = new NhapHangController();
            else NHCtr = nhctr;
            SPCTCtr = new SanPham_ChiTietController(NHCtr._db);
            dtgvChiTietNH.AutoGenerateColumns = false;
            dtgvChiTietSP.AutoGenerateColumns = false;
            if (nh == null)
            {
                this.nh = new NhapHang(NHCtr._db);
                this.Text = "Thêm Mới Đơn Nhập Hàng";
                LoadDTGV_ChiTietSP();
                dtpkNgay.Value = DateTime.Now;
            }
            else
            {
                ViewMode = true;
                this.nh = nh;
                this.nh._set_context(NHCtr._db);
                ThongTinFormNhapHang = this.nh;
                btLuu.Enabled = false;
                btThem.Enabled = false;
                btXoa.Enabled = false;
                gbDSSanPham.Enabled = false;
                LoadDTGV_ChiTietNH();
            }      
        }

        void LoadDTGV_ChiTietNH()
        {
            dtgvChiTietNH.DataSource = null;
            if (nh.ds_chitiet_nhaphang.Count > 0) dtgvChiTietNH.DataSource = nh.ds_chitiet_nhaphang;
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
                    nh.active = ckbKichHoat.Checked;
                    nh.ngay = dtpkNgay.Value;
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
                dtpkNgay.Value = value.ngay;
                tbTongTien.Text = value.tongtien_change;
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            SanPham_ChiTiet spct = (SanPham_ChiTiet)dtgvChiTietSP.SelectedRows[0].DataBoundItem;

            if (nh.check_exist_spct_in_donnhaphang(spct.id))
            {
                MessageBox.Show("Đơn nhập hàng đã có chứa sản phẩm này rồi.");
                return;
            }

            ChiTiet_NhapHang ctnh = new ChiTiet_NhapHang(NHCtr._db);
            ctnh.soluong = Int32.Parse(tbSoLuong.Text);
            if (ctnh.soluong == 0)
            {
                MessageBox.Show("Chỉ được nhập số lượng lớn hơn 0.");
                return;
            }
            ctnh.dongia = Int32.Parse(tbDonGia.Text);
            if (ctnh.dongia == 0)
            {
                MessageBox.Show("Chỉ được nhập đơn giá lớn hơn 0.");
                return;
            }
            ctnh.sanpham_chitiet = spct;

            //set lai tong tien
            int num = TextLibrary.ToInt(tbTongTien.Text);
            num += ctnh.soluong * ctnh.dongia;
            tbTongTien.Text = TextLibrary.ToCommaStringNumber(num);
            nh.ds_chitiet_nhaphang.Add(ctnh);
            MessageBox.Show("Thêm thành công.");
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
                nh.add();

                MessageBox.Show("Lưu thành công.");
                IsSave = true;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi lưu lại.");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {  
            if (dtgvChiTietNH.SelectedRows.Count > 0)
            {
                ChiTiet_NhapHang ctnh = (ChiTiet_NhapHang)dtgvChiTietNH.SelectedRows[0].DataBoundItem;
                DialogResult dialogResult = MessageBox.Show("Xoá sản phẩm " + ctnh.sanpham_chitiet.sanpham.ten + " chứ ?", "Xoá", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //set lai tong tien
                    int num = TextLibrary.ToInt(tbTongTien.Text);
                    num -= ctnh.soluong * ctnh.dongia;
                    tbTongTien.Text = TextLibrary.ToCommaStringNumber(num);
                    nh.ds_chitiet_nhaphang.Remove(ctnh);
                    LoadDTGV_ChiTietNH();
                    MessageBox.Show("Xoá thành công.");
                }
            }
        }

        private void FmThongTinNhapHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ViewMode)
            {
                if (IsSave) DTGV_NhapHang();
            }
        }
    
    }
}
