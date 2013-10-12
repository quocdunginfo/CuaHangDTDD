using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CuaHangDTDD.Models
{
    public class HinhAnh
    {
        public int id { get; set; }
        public String duongdan { get; set; }//đường dẫn tương đối
    }
    public class SanPham
    {
        public SanPham()
        {
            //  this.ds_dathang = new List<DatHang>();
            this.ds_hinhanh = new List<HinhAnh>();
            this.masp = "";
            this.ten = "";
            this.mota = "";
            this.gia = 0;
        }
        [Key]
        public int id { get; set; }
        public String masp { get; set; }
        public String ten { get; set; }
        public String mota { get; set; }
        public int gia { get; set; }
        public Boolean active { get; set; }
        //external
        // public virtual List<DatHang> ds_dathang { get; set; }
        public virtual List<HinhAnh> ds_hinhanh { get; set; }
        public virtual HangSX hangsx { get; set; }
        //  public virtual NhanVien nguoidung { get; set; }
    }
    public class Topic
    {
        public Topic()
        {
            this.ds_phanhoi = new List<PhanHoi>();
            this.ten = "";
            this.noidung = "";
            this.ngay = DateTime.Now;
        }
        [Key]
        public int id { get; set; }
        public String ten { get; set; }
        public String noidung { get; set; }
        public DateTime ngay { get; set; }
        public Boolean active { get; set; }
        //external
        public virtual KhachHang nguoitao { get; set; }
        public virtual List<PhanHoi> ds_phanhoi { get; set; }
    }
    public class PhanHoi
    {
        public PhanHoi()
        {
            this.ten = "";
            this.noidung = "";
            this.ngay = DateTime.Now;
        }
        [Key]
        public int id { get; set; }
        public String ten { get; set; }
        public String noidung { get; set; }
        public DateTime ngay { get; set; }
        public Boolean active { get; set; }
        //external
        public virtual NhanVien nhanvien { get; set; }//Nhân viên gửi
        public virtual KhachHang khachhang { get; set; }//Khách Hàng gửi
        public virtual Topic topic { get; set; }//thuộc Topic nào
    }
    public class HangSX
    {
        public HangSX()
        {
            this.ds_sanpham = new List<SanPham>();
            this.tenhsx = "";
        }
        [Key]
        public int id { get; set; }
        public String tenhsx { get; set; }
        public Boolean active { get; set; }
        //external
        public virtual List<SanPham> ds_sanpham { get; set; }
    }
    public class NhaCC
    {
        public NhaCC()
        {
            this.ds_nhaphang = new List<NhapHang>();
            this.ten_ncc = "";
            this.diachi_ncc = "";
            this.sdt_ncc = "";
        }
        [Key]
        public int id { get; set; }
        public String ten_ncc { get; set; }
        public String diachi_ncc { get; set; }
        public String sdt_ncc { get; set; }
        public Boolean active { get; set; }
        //external
        public virtual List<NhapHang> ds_nhaphang { get; set; }
    }
    public class NhapHang
    {
        public NhapHang()
        {
            this.ds_chitiet_nhaphang = new List<ChiTiet_NhapHang>();
            this.ngay = DateTime.Now;
            this.tongtien = 0;
            this.thanhtoan = 0;
            this.ten_nhacungcap = "";
            this.ten_nhanvien = "";
        }
        [Key]
        public int id { get; set; }
        public DateTime ngay { get; set; }
        public int tongtien { get; set; }
        public int thanhtoan { get; set; }
        public String ten_nhanvien { get; set; }
        public String ten_nhacungcap { get; set; }
        public Boolean active { get; set; }
        //external
        public virtual NhaCC nhacc { get; set; }
        public virtual NhanVien nhanvien { get; set; }
        public virtual List<ChiTiet_NhapHang> ds_chitiet_nhaphang { get; set; }

    }
    public class ChiTiet_NhapHang
    {
        [Key]
        public int id { get; set; }
        public int soluong { get; set; }
        public int dongia { get; set; }
        //external
        public virtual NhapHang nhaphang { get; set; }
        public virtual SanPham sanpham { get; set; }
    }
    public class DonHang
    {
        public DonHang()
        {
            this.ds_chitiet_donhang = new List<ChiTiet_DonHang>();
            this.ngay = DateTime.Now;
            this.diachi_nguoinhan = "";
            this.ten_nguoinhan = "";
            this.sdt_nguoinhan = "";
            this.tennv = "";
        }
        [Key]
        public int id { get; set; }
        public DateTime ngay { get; set; }
        public int tongtien { get; set; }
        public Boolean dathanhtoan { get; set; }
        public Boolean dagiaohang { get; set; }
        public String diachi_nguoinhan { get; set; }
        public String ten_nguoinhan { get; set; }
        public String sdt_nguoinhan { get; set; }
        public String tennv { get; set; }
        public Boolean active { get; set; }
        //external
        public virtual List<ChiTiet_DonHang> ds_chitiet_donhang { get; set; }
        public virtual NhanVien nguoidung { get; set; }
        public virtual KhachHang khachhang { get; set; }
    }
    public class ChiTiet_DonHang
    {
        [Key]
        public int id { get; set; }
        public int soluong { get; set; }
        public int dongia { get; set; }
        //external
        public virtual DonHang donhang { get; set; }
        public virtual SanPham sanpham { get; set; }
    }
    public class KhachHang
    {
        public KhachHang()
        {
            this.ds_donhang = new List<DonHang>();
            this.tendangnhap = "";
            this.tendaydu = "";
            this.matkhau = "";
            this.diachi = "";
            this.email = "";
            this.sdt = "";
        }
        [Key]
        public int id { get; set; }
        public String tendangnhap { get; set; }
        public String tendaydu { get; set; }
        public String matkhau { get; set; }
        public String diachi { get; set; }
        public String email { get; set; }
        public String sdt { get; set; }
        public Boolean active { get; set; }
        //external
        public virtual List<DonHang> ds_donhang { get; set; }
    }
    public class NhanVien
    {
        public NhanVien()
        {
            this.id = 0;
            this.active = true;
            // this.ds_sanpham = new List<SanPham>();
            this.ds_donhang = new List<DonHang>();
            this.ds_nhaphang = new List<NhapHang>();
            this.tendangnhap = "";
            this.tendaydu = "";
            this.email = "";
            this.matkhau = "";
        }
        [Key]
        public int id { get; set; }
        public String tendangnhap { get; set; }
        public String tendaydu { get; set; }
        public String email { get; set; }
        public String matkhau { get; set; }
        public Boolean active { get; set; }
        //external
        //public virtual List<SanPham> ds_sanpham { get; set; }
        public virtual List<DonHang> ds_donhang { get; set; }
        public virtual List<NhapHang> ds_nhaphang { get; set; }
        public virtual LoaiNhanVien loainhanvien { get; set; }
    }
    public class LoaiNhanVien
    {
        public LoaiNhanVien()
        {
            this.ds_nhanvien = new List<NhanVien>();
            this.ds_quyen = new List<Quyen>();
            this.ten = "";
        }
        [Key]
        public int id { get; set; }
        public String ten { get; set; }
        //external
        public virtual List<Quyen> ds_quyen { get; set; }
        public virtual List<NhanVien> ds_nhanvien { get; set; }
    }
    public class Quyen
    {
        public Quyen()
        {
            this.ds_loainhanvien = new List<LoaiNhanVien>();
            this.ten = "";
        }
        [Key]
        public int id { get; set; }
        public String ten { get; set; }
        //external
        public virtual List<LoaiNhanVien> ds_loainhanvien { get; set; }
    }
    public class TonKho
    {
        public TonKho()
        {
        }
        [Key]
        public int id { get; set; }
        public DateTime ngay { get; set; }
        public int soluongnhap { get; set; }
        public int soluongban { get; set; }
        //external
        public virtual SanPham sanpham { get; set; }
    }
    public class DTDDDbContext : DbContext
    {
        public DbSet<DonHang> ds_donhang { get; set; }
        public DbSet<ChiTiet_DonHang> ds_chitiet_donhang { get; set; }
        public DbSet<SanPham> ds_sanpham { get; set; }
        public DbSet<HangSX> ds_hangsx { get; set; }
        public DbSet<HinhAnh> ds_hinhanh { get; set; }
        public DbSet<KhachHang> ds_khachhang { get; set; }
        public DbSet<NhanVien> ds_nhanvien { get; set; }
        public DbSet<ChiTiet_NhapHang> ds_chitiet_nhaphang { get; set; }
        public DbSet<NhapHang> ds_nhaphang { get; set; }
        public DbSet<NhaCC> ds_nhacc { get; set; }
        public DbSet<TonKho> ds_tonkho { get; set; }
        public DbSet<LoaiNhanVien> ds_loainhanvien { get; set; }
        public DbSet<Quyen> ds_quyen { get; set; }
    }
}