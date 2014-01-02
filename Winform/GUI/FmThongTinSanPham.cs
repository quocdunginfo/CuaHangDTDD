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
using System.Data.Entity.Infrastructure;
using System.Data.Objects;

namespace Winform.GUI
{
    public partial class FmThongTinSanPham : Form
    {
        SanPham sp;
        bool IsSave = false;
        bool IsChange = false;
        bool EditMode = false;
        SanPhamController SPCtr;
        HangSXController HSXCtr;
        MauSacController MSCtr;
        HinhAnhController HACtr;
        SanPham_ChiTietController SPCTCtr;

        public delegate void callback();
        public callback DTGV_DSSanPham;

        public FmThongTinSanPham(SanPham sp = null, SanPhamController spc = null)
        {
            InitializeComponent();
            dtgvHinhAnh.AutoGenerateColumns = false;
            dtgvChiTietSanPham.AutoGenerateColumns = false;
            //set primary context
            if (spc != null) SPCtr = spc;
            else SPCtr = new SanPhamController();

            HSXCtr = new HangSXController(this.SPCtr._db);
            MSCtr = new MauSacController(this.SPCtr._db);
            HACtr = new HinhAnhController(this.SPCtr._db);
            SPCTCtr = new SanPham_ChiTietController(this.SPCtr._db);
            MSCtr.timkiem();
            LoadCb_HangSX();
            if (sp == null)
            {
                this.sp = new SanPham(SPCtr._db);
                this.Text = "Thêm Mới Sản Phẩm";
            }
            else
            {
                this.sp = sp;
                this.sp._set_context(SPCtr._db);
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
                    sp.masp = tbMaSP.Text.Trim();
                    if (sp.masp.Length == 0)
                    {
                        MessageBox.Show("Mã sản phẩm không được để trống.");
                        return null;
                    }
                    sp.ten = tbTenSP.Text.Trim();
                    if (sp.ten.Length == 0)
                    {
                        MessageBox.Show("Tên sản phẩm không được để trống.");
                        return null;
                    }
                    sp.gia = TextLibrary.ToInt(tbGia.Text.Trim());
                    if (sp.gia == 0)
                    {
                        MessageBox.Show("Hãy nhập lại giá.");
                        return null;
                    }
                    sp.active = ckbKichHoat.Checked;
                    sp.mota = rtbMoTa.Text.Trim();
                    if (sp.mota.Length == 0)
                    {
                        MessageBox.Show("Hãy nhập mô tả.");
                        return null;
                    }
                    sp.hangsx = (HangSX)cbHangSX.SelectedItem;
                    if (sp.hangsx == null)
                    {
                        MessageBox.Show("Hãy thêm hãng sản xuất thông qua Trang Quản Lý Hãng Sản Xuất.");
                        return null;
                    }
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
                cbHangSX.SelectedItem = value.hangsx;
                ckbKichHoat.Checked = value.active;
                rtbMoTa.Text = value.mota.Trim();
            }
        }

        void LoadDTGV_HinhAnh()
        {
            dtgvHinhAnh.DataSource = null;
            if(sp.ds_hinhanh.Count > 0) dtgvHinhAnh.DataSource = sp.ds_hinhanh;
        }

        void LoadDTGV_ChiTietSP()
        {

            dtgvChiTietSanPham.DataSource = null;
            if (sp.ds_sanpham_chitiet.Count > 0)  dtgvChiTietSanPham.DataSource = sp.ds_sanpham_chitiet;    
           
        }

        private void btThemHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.ShowDialog();
            bool file_ok = false;
            foreach (string path in ofd.FileNames)
            {
                if (path.Trim() == "") continue;
                HinhAnh ha = new HinhAnh();
                ha.source_picture_from_web = false;
                ha.duongdan = path;
                ha.duongdan_thumb = path;
                sp.ds_hinhanh.Add(ha);
                file_ok = true;
            }

            if (file_ok)
            {
                LoadDTGV_HinhAnh();
                MessageBox.Show("Thêm thành công.");
                IsChange = true;
            }
            
        }

        private void btDatLamAnhMacDinh_Click(object sender, EventArgs e)
        {
            if (dtgvHinhAnh.SelectedRows.Count == 0) return;
            HinhAnh a = (HinhAnh)dtgvHinhAnh.SelectedRows[0].DataBoundItem;
            if (a.macdinh)
            {
                MessageBox.Show("Ảnh đã là mặc định rồi.");
                return;
            } 
            sp._set_hinhanh_macdinh(a);
            dtgvHinhAnh.Refresh();
            MessageBox.Show("Thay đổi thành công.");
            IsChange = true;
        }

        private void btXoaHinhAnh_Click(object sender, EventArgs e)
        {
            if (dtgvHinhAnh.SelectedRows.Count == 0) return;
            DialogResult dr = MessageBox.Show("Xoá hình ảnh chứ ?", "Xoá", MessageBoxButtons.YesNo);
            if (dr != DialogResult.Yes) return;
            HinhAnh ha = (HinhAnh)dtgvHinhAnh.SelectedRows[0].DataBoundItem;
            sp.ds_hinhanh.Remove(ha);
            LoadDTGV_HinhAnh();
            MessageBox.Show("Xoá thành công.");
            IsChange = true;
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
            if (type == "all") list = MSCtr.get_list_mausac_local_source(new List<MauSac>());
            else list = MSCtr.get_list_mausac_local_source(sp.get_list_mausac());
            
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
                SanPham_ChiTiet spct = ThongTinFormSanPhamChiTiet;
                if (spct == null || spct.mausac == null)
                {
                    MessageBox.Show("Hãy thêm màu.");
                    return;
                }

                sp.ds_sanpham_chitiet.Add(spct);
                dtgvChiTietSanPham.DataSource = sp.ds_sanpham_chitiet;
                LoadDTGV_ChiTietSP();
                gbThongTin.Enabled = false;
                btSuaChiTietSP.Enabled = true;
                btXoaChiTietSP.Enabled = true;
                MessageBox.Show("Thêm thành công.");
                IsChange = true;
            }
            else
            {
                SanPham_ChiTiet spct = (SanPham_ChiTiet)dtgvChiTietSanPham.SelectedRows[0].DataBoundItem;
                SanPham_ChiTiet infoform = ThongTinFormSanPhamChiTiet;
                if (infoform != null)
                {
                    if(sp.check_exist_mausac(infoform.mausac.id))
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
                    IsChange = true;
                }
            }
        }

        private void btSuaChiTietSP_Click(object sender, EventArgs e)
        {
            if (dtgvChiTietSanPham.SelectedRows.Count == 0) return;
            SanPham_ChiTiet spct = (SanPham_ChiTiet)dtgvChiTietSanPham.SelectedRows[0].DataBoundItem;
            ThongTinFormSanPhamChiTiet = spct;
            gbThongTin.Enabled = true;
            btThemChiTietSP.Enabled = false;
            btXoaChiTietSP.Enabled = false;
        }

        private SanPham_ChiTiet ThongTinFormSanPhamChiTiet
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
                    MessageBox.Show("Thông tin nhập không đúng.");
                    return null;
                }
            }
            set
            {
                tbTonKho.Text = value.tonkho.ToString();
                ckbKichHoatChiTietSP.Checked = value.active;
                LoadCb_MauSac("all");
                cbMauSac.SelectedItem = value.mausac;
            }
        }

        private void btXoaChiTietSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvChiTietSanPham.SelectedRows.Count > 0)
                {
                    SanPham_ChiTiet spct = (SanPham_ChiTiet)dtgvChiTietSanPham.SelectedRows[0].DataBoundItem;
                    DialogResult dialogResult = MessageBox.Show("Xoá sản phẩm có màu " + spct.mausac.giatri + " chứ ?", "Xoá", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (spct.check_relation_entities_exist())
                        {
                            MessageBox.Show("Không xoá được do có các hoá đơn chứa sản phẩm này.");
                            return;
                        }
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

                    // clean db
                    if (EditMode)
                    {
                        SPCTCtr.clean_db();
                        HACtr.clean_db();
                    }

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

        private void FmThongTinSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            //reload entity
            if (EditMode)
            {
                if (IsSave) DTGV_DSSanPham();
                else
                {
                    if (IsChange) SPCtr.reload(sp);
                } 
            }
            else
            {
                if (IsSave) DTGV_DSSanPham();
            }        
        }
        private void btThemMau_Click(object sender, EventArgs e)
        {
            InputDialog ip = new InputDialog();
            if (ip.ShowDialog() == DialogResult.OK)
            {
                MauSac ms = new MauSac();
                ms.giatri = ip.GiaTri;
                ms.id = MSCtr.get_max_id_local_source() + 1;
                MSCtr.add_without_save(ms);
                MessageBox.Show("Thêm thành công.");
                if (btThemChiTietSP.Enabled) LoadCb_MauSac();
                else LoadCb_MauSac("all");
                IsChange = true;
            }
        }
    }
}
