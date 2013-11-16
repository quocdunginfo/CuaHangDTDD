using BaseClass._Library;
using BaseClass.ModelController;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseClass.Models
{
    public class HinhAnh
    {
        public HinhAnh()
        {
            this.id = 0;
            this.duongdan = "";
            this.duongdan_thumb = "";
            this.macdinh = false;
        }
        public int id { get; set; }
        public String duongdan { get; set; }//đường dẫn tương đối
        public String duongdan_thumb { get; set; }//đường dẫn tương đối
        public Boolean macdinh { get; set; }//đường dẫn tương đối
        //external
        public virtual SanPham sanpham { get; set; }

        //method
        public string _get_full_duongdan()
        {
            string path = "~/_Upload/HinhAnh/";
            path += this.duongdan;
            UrlHelper helper = new UrlHelper(HttpContext.Current.Request.RequestContext);
            return helper.Content(path);
        }
        public string _get_full_duongdan_thumb()
        {
            string path = "~/_Upload/HinhAnh/";
            path += this.duongdan_thumb;
            UrlHelper helper = new UrlHelper(HttpContext.Current.Request.RequestContext);
            return helper.Content(path);
        }
    }
    public class SanPham_ChiTiet
    {
        public SanPham_ChiTiet()
        {
            this.id = 0;
            this.active = true;
        }
        [Key]
        public int id { get; set; }
        public Boolean active { get; set; }
        public int tonkho { get; set; }
        //external
        public virtual MauSac mausac { get; set; }
        public virtual SanPham sanpham { get; set; }
        public virtual List<TonKho> ds_tonkho { get; set; }
    }
    public class MauSac
    {
        public MauSac()
        {
            this.id = 0;
            this.giatri = "";
            this.ds_sanpham_chitiet = new List<SanPham_ChiTiet>();
        }
        [Key]
        public int id { get; set; }
        public string giatri { get; set; }
        public virtual List<SanPham_ChiTiet> ds_sanpham_chitiet { get; set; }
    }
    public class SanPham
    {
        public SanPham()
        {
            this.ds_hinhanh = new List<HinhAnh>();
            this.masp = "";
            this.ten = "";
            this.mota = "";
            this.gia = 0;
            this.active = true;
        }
        [Key]
        public int id { get; set; }
        public String masp { get; set; }
        public String ten { get; set; }
        public String mota { get; set; }
        public int gia { get; set; }
        public Boolean active { get; set; }
        //thuộc tính DTDT
        //...

        //external
        public virtual List<HinhAnh> ds_hinhanh { get; set; }
        public virtual HangSX hangsx { get; set; }
        public virtual List<SanPham_ChiTiet> ds_sanpham_chitiet { get; set; }
        //method
        public HinhAnh _get_hinhanh_macdinh()
        {
            HinhAnh tmp = this.ds_hinhanh.Where(x => x.macdinh == true).FirstOrDefault();
            if (tmp == null)
            {
                tmp = new HinhAnh();
                tmp.duongdan =tmp.duongdan_thumb= "default.jpg";
            }
            return tmp;
        }
        public string _get_mota_lite(int max_length = 200)
        {
            if (this.mota.Equals(""))
            {
                return "(Chưa có mô tả cho sản phẩm)";
            }
            try
            {
                string tmp = this.mota;
                tmp = TextLibrary.HTML_Strip(tmp);
                tmp = TextLibrary.Unicode_Substring(tmp, max_length);
                return tmp + "...";
            }
            catch (Exception ex)
            {
                return this.mota + "...";
            }
        }
    }
    
    public class HangSX
    {
        public HangSX()
        {
            this.ds_sanpham = new List<SanPham>();
            this.id = 0;
            this.ten = "";
            this.active = true;
        }
        [Key]
        public int id { get; set; }
        public String ten { get; set; }
        public Boolean active { get; set; }
        //external
        public virtual List<SanPham> ds_sanpham { get; set; }
    }

    public class NhapHang
    {
        public NhapHang()
        {
            this.ds_chitiet_nhaphang = new List<ChiTiet_NhapHang>();
            this.id = 0;
            this.ngay = DateTime.Now;
            this.tongtien = 0;
            this.active = true;
        }
        [Key]
        public int id { get; set; }
        public DateTime ngay { get; set; }
        public int tongtien { get; set; }
        public Boolean active { get; set; }
        //external
        public virtual List<ChiTiet_NhapHang> ds_chitiet_nhaphang { get; set; }
    }
    public class ChiTiet_NhapHang
    {
        public ChiTiet_NhapHang()
        {
            this.id = 0;
            this.soluong = 0;
            this.dongia = 0;
        }
        [Key]
        public int id { get; set; }
        public int soluong { get; set; }
        public int dongia { get; set; }
        //external
        public virtual NhapHang nhaphang { get; set; }
        public virtual SanPham_ChiTiet sanpham_chitiet { get; set; }
    }
    public class DonHang
    {
        public DonHang()
        {
            this.ds_chitiet_donhang = new List<ChiTiet_DonHang>();
            this.id = 0;
            this.ngay = DateTime.Now;
            this.tongtien = 0;
            this.dagiaohang = false;
            this.active = true;
            this.kh_ten = "";
            this.kh_diachi = "";
            this.kh_email = "";
            this.kh_sdt = "";
        }
        [Key]
        public int id { get; set; }
        public DateTime ngay { get; set; }
        public int tongtien { get; set; }
        public Boolean dagiaohang { get; set; }
        public Boolean active { get; set; }
        //KHACHHANG
        public String kh_ten { get; set; }
        public String kh_diachi { get; set; }
        public String kh_email { get; set; }
        public String kh_sdt { get; set; }
        //external
        public virtual List<ChiTiet_DonHang> ds_chitiet_donhang { get; set; }
        //method
        private int _get_tongtien_int()
        {
            int sum = 0;
            foreach (var item in this.ds_chitiet_donhang)
            {
                sum += item.dongia * item.soluong;
            }
            return sum;
        }
        public String _get_ngay()
        {
            String format = "dd/MM/yyyy";
            return String.Format("{0:" + format + "}", this.ngay);
        }
        public String _get_tongtien()
        {
            if (this._get_tongtien_int() != this.tongtien)
            {
                return TextLibrary.ToCommaStringNumber(this._get_tongtien_int());
            }
            return TextLibrary.ToCommaStringNumber(this.tongtien);
        }
        public Boolean _remove_from_cart(int chitietsp_id = 0)
        {
            ChiTiet_DonHang obj = this.ds_chitiet_donhang.Where(x => x.sanpham_chitiet.id == chitietsp_id).FirstOrDefault();
            if (obj == null)
            {
                return false;
            }
            this.ds_chitiet_donhang.Remove(obj);
            return true;

        }
        public Boolean _update_cart(int chitietsp_id = 0, int chitietsp_soluong = 0)
        {
            ChiTiet_DonHang obj = this.ds_chitiet_donhang.Where(x => x.sanpham_chitiet.id == chitietsp_id).FirstOrDefault();
            if (obj == null)
            {
                return false;
            }
            SanPham_ChiTietController ctr = new SanPham_ChiTietController();
            SanPham_ChiTiet in_system = ctr.get_by_id(chitietsp_id);
            if (in_system.tonkho < chitietsp_soluong || chitietsp_soluong<=0)
            {
                return false;
            }
            obj.soluong = chitietsp_soluong;
            return true;
        }
        public Boolean _add_to_cart(ChiTiet_DonHang obj)
        {
            if (obj == null || obj.sanpham_chitiet == null || obj.soluong == 0)
            {
                return false;
            }
            //check if exist in cart
            foreach (var item in this.ds_chitiet_donhang)
            {
                if (item.sanpham_chitiet.id == obj.sanpham_chitiet.id)
                {
                    //đã có trong giỏ hàng
                    //chỉ cộng trường số lượng
                    item.soluong += obj.soluong;
                    return true;
                }
            }
            //chưa có
            //thì thêm vào
            this.ds_chitiet_donhang.Add(obj);
            return true;
        }
    }
    public class ChiTiet_DonHang
    {
        public ChiTiet_DonHang()
        {
            this.id = 0;
            this.soluong = 0;
            this.dongia = 0;
        }
        [Key]
        public int id { get; set; }
        public int soluong { get; set; }
        public int dongia { get; set; }
        //external
        public virtual DonHang donhang { get; set; }
        public virtual SanPham_ChiTiet sanpham_chitiet { get; set; }
        //method
        public string _get_total()
        {
            return TextLibrary.ToCommaStringNumber(this.soluong * this.dongia);
        }
    }
    
    public class TonKho
    {
        public TonKho()
        {
            this.id = 0;
            this.soluong = 0;
            this.ngay = DateTime.Now;
        }
        [Key]
        public int id { get; set; }
        public int soluong { get; set; }
        public DateTime ngay { get; set; }
        //external
        public virtual SanPham_ChiTiet sanpham_chitiet { get; set; }
    }
    public class DTDDDbContext : DbContext
    {
        public DbSet<DonHang> ds_donhang { get; set; }
        public DbSet<ChiTiet_DonHang> ds_chitiet_donhang { get; set; }
        public DbSet<SanPham> ds_sanpham { get; set; }
        public DbSet<SanPham_ChiTiet> ds_sanpham_chitiet { get; set; }
        public DbSet<HangSX> ds_hangsx { get; set; }
        public DbSet<HinhAnh> ds_hinhanh { get; set; }
        public DbSet<ChiTiet_NhapHang> ds_chitiet_nhaphang { get; set; }
        public DbSet<NhapHang> ds_nhaphang { get; set; }
        public DbSet<TonKho> ds_tonkho { get; set; }
    }
}