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
    public partial class FmThongTinSanPham : Form
    {
        SanPham sp;
        bool IsSave = false;
        bool EditMode = false;
        SanPhamController SPCtr;
        HangSXController HSXCtr;
        MauSacController MSCtr;
        public FmThongTinSanPham(SanPham sp = null)
        {
            InitializeComponent();
            dtgvHinhAnh.AutoGenerateColumns = false;
            dtgvChiTietSanPham.AutoGenerateColumns = false;
 //           if (spc != null) SPCtr = SPCtr = spc;
 //           else 
            SPCtr = new SanPhamController();
            HSXCtr = new HangSXController(this.SPCtr._db);
            MSCtr = new MauSacController(this.SPCtr._db);
            LoadCb_HangSX();
            if (sp == null)
            {
                this.sp = new SanPham(SPCtr._db);
                this.Text = "Thêm Mới Sản Phẩm";
            }
            else
            {
                this.sp = SPCtr.get_by_id(sp.id);
                EditMode = true;
                ThongTinFormSanPham = this.sp;
                LoadDTGV_HinhAnh();
                LoadDTGV_ChiTietSP();
            }

        }

        void LoadCb_HangSX()
        {
            if (cbHangSX.Items.Count > 0) cbHangSX.Items.Clear();
            cbHangSX.DataSource = HSXCtr.timkiem();
            cbHangSX.DisplayMember = "ten";
            cbHangSX.ValueMember = "id";
        }

        SanPham ThongTinFormSanPham
        {
            get
            {
                try
                {
                    SanPham sp = new SanPham();
                    sp.masp = tbMaSP.Text;
                    sp.ten = tbTenSP.Text;
                    sp.gia = TextLibrary.ToInt(tbGia.Text);
                    sp.active = ckbKichHoat.Checked;
                    sp.mota = rtbMoTa.Text;
                    sp.hangsx = (HangSX)cbHangSX.SelectedItem;
                    return sp;
                }
                catch (Exception)
                {
                    MessageBox.Show("Thông tin nhập chưa đúng.");
                    return null; }
            }
            set
            {
                tbID.Text = value.id.ToString();
                tbMaSP.Text = value.masp.ToString();
                tbTenSP.Text = value.ten.Trim();
                tbGia.Text = value.giasp.ToString();
                cbHangSX.SelectedValue = value.hangsx.id;
                ckbKichHoat.Checked = value.active;
                rtbMoTa.Text = value.mota.Trim();
            }
        }

        void LoadDTGV_HinhAnh()
        {
  //          IBindingList li = new BindingList<HinhAnh>(list);
            dtgvHinhAnh.DataSource = null;
            dtgvHinhAnh.DataSource = sp.ds_hinhanh;
        }

        void LoadDTGV_ChiTietSP()
        {
 //           IBindingList li = new BindingList<SanPham_ChiTiet>(list);
            dtgvChiTietSanPham.DataSource = null;
            dtgvChiTietSanPham.DataSource = sp.ds_sanpham_chitiet;
        }

        private void btThemHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName == "") return;
            HinhAnh ha = new HinhAnh();
            if (sp.ds_hinhanh.Count > 0) ha.id = sp.ds_hinhanh.Max(tt => tt.id) + 1;
            else ha.id = 1;
            ha.source_picture_from_web = false;
            ha.duongdan = ofd.FileName;
            sp.ds_hinhanh.Add(ha);
  //          dtgvHinhAnh.Refresh();
            LoadDTGV_HinhAnh();
        }

        private void btDatLamAnhMacDinh_Click(object sender, EventArgs e)
        {
            HinhAnh cur = sp.ds_hinhanh.Where(ha => ha.macdinh == true).FirstOrDefault();
            if (cur != null) cur.macdinh = false;

            HinhAnh after = (HinhAnh)dtgvHinhAnh.SelectedRows[0].DataBoundItem;
            after.macdinh = true;
            dtgvHinhAnh.Refresh();
  //          LoadDTGV_HinhAnh(sp.ds_hinhanh);
        }

        private void btXoaHinhAnh_Click(object sender, EventArgs e)
        {
            HinhAnh ha = (HinhAnh)dtgvHinhAnh.SelectedRows[0].DataBoundItem;
            sp.ds_hinhanh.Remove(ha);
            LoadDTGV_HinhAnh();
        }

        private void btThemChiTietSP_Click(object sender, EventArgs e)
        {
            gbThongTin.Enabled = true;
            btSuaChiTietSP.Enabled = false;
            btXoaChiTietSP.Enabled = false;
            LoadCb_MauSac();
            tbTonKho.Text ="0";
        }

        void LoadCb_MauSac(string type = "")
        {
            List<MauSac> list; 
            if (type == "all") list = MSCtr.timkiem();
            else list = MSCtr.timkiem().Where(ms => sp.ds_sanpham_chitiet.Where(spct => spct.mausac.id == ms.id).FirstOrDefault() == null).ToList();
            
            cbMauSac.DataSource = list;
            cbMauSac.DisplayMember = "giatri";
            cbMauSac.ValueMember = "id";
        }

        private void btHuyChiTietSP_Click(object sender, EventArgs e)
        {
            gbThongTin.Enabled = false;
            btThemChiTietSP.Enabled = true;
            btSuaChiTietSP.Enabled = true;
            btXoaChiTietSP.Enabled = true;
        }

        private void btLuuChiTietSP_Click(object sender, EventArgs e)
        {
            if (btThemChiTietSP.Enabled)
            {
                if (cbMauSac.Items.Count == 0) return;
                SanPham_ChiTiet spct = ThongTinFormMauSac;
                if (sp.ds_sanpham_chitiet.Count > 0) spct.id = sp.ds_sanpham_chitiet.Max(tt => tt.id) + 1;
                else spct.id = 1;
                sp.ds_sanpham_chitiet.Add(spct);
                LoadDTGV_ChiTietSP();
                MessageBox.Show("Thêm thành công");
                gbThongTin.Enabled = false;
                btSuaChiTietSP.Enabled = true;
                btXoaChiTietSP.Enabled = true;
            }
            else
            {
                SanPham_ChiTiet spct = (SanPham_ChiTiet)dtgvChiTietSanPham.SelectedRows[0].DataBoundItem;
                SanPham_ChiTiet infoform = ThongTinFormMauSac;
                if (infoform != null)
                {
                    if (sp.ds_sanpham_chitiet.Where(spctt => spctt.mausac.id == infoform.mausac.id).FirstOrDefault() != null)
                    {
                        MessageBox.Show("Màu này đã có rồi, không thể đổi được.");
                        return;
                    }
                    spct.change(infoform);
                    MessageBox.Show("Thay đổi thành công.");
                    LoadDTGV_ChiTietSP();
                    gbThongTin.Enabled = false;
                    btThemChiTietSP.Enabled = true;
                    btXoaChiTietSP.Enabled = true;
                }
            }
        }

        private void btSuaChiTietSP_Click(object sender, EventArgs e)
        {
            if (dtgvChiTietSanPham.CurrentCell == null) return;
            SanPham_ChiTiet spct = (SanPham_ChiTiet)dtgvChiTietSanPham.SelectedRows[0].DataBoundItem;
            ThongTinFormMauSac = spct;
            gbThongTin.Enabled = true;
            btThemChiTietSP.Enabled = false;
            btXoaChiTietSP.Enabled = false;
        }

        private SanPham_ChiTiet ThongTinFormMauSac
        {
            get
            {
                try
                {
                    SanPham_ChiTiet spct = new SanPham_ChiTiet();
                    spct.tonkho = Int32.Parse(tbTonKho.Text);
                    spct.active = ckbKichHoatChiTietSP.Checked;
                    spct.mausac = (MauSac)cbMauSac.SelectedItem;
                    return spct;
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi nhập trên form.");
                    return null;
                }
            }
            set
            {
                tbTonKho.Text = value.tonkho.ToString();
                ckbKichHoatChiTietSP.Checked = value.active;
                LoadCb_MauSac("all");
                cbMauSac.SelectedValue = value.mausac.id;
            }
        }

        private void btXoaChiTietSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvChiTietSanPham.CurrentCell != null)
                {
                    SanPham_ChiTiet spct = (SanPham_ChiTiet)dtgvChiTietSanPham.SelectedRows[0].DataBoundItem;
                    DialogResult dialogResult = MessageBox.Show("Xoá thằng màu " + spct.mausac.giatri + " chớ ?", "Xoá", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        sp.ds_sanpham_chitiet.Remove(spct);
                        LoadDTGV_ChiTietSP();
                        MessageBox.Show("Xoá thành công.");
                    }
                }
            }
            catch (Exception)
            { MessageBox.Show("Lỗi khi xoá."); }
            
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            SanPham infoform = ThongTinFormSanPham;
            if (infoform == null) return;
            sp.change(infoform);
                try
                {
                    // upload img
                    foreach (HinhAnh ha in sp.ds_hinhanh)
                    {
                        if (ha.source_picture_from_web) continue;
                        HinhAnh haa = ha._upload_to_host_winform_use_only(ha.duongdan);
                        ha.duongdan = haa.duongdan;
                        ha.duongdan_thumb = haa.duongdan_thumb;
                        ha.source_picture_from_web = true;
                    }
                    //save
                    if (EditMode) sp.update();
                    else sp.add();


                    MessageBox.Show("Lưu thành công.");
                    IsSave = true;
                    this.Close();
                }
                catch(Exception)
                {
                    MessageBox.Show("Lỗi khi lưu lại.");
                }
            
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
