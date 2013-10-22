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

    public class NhapHang
    {
        public NhapHang()
        {
            this.ds_chitiet_nhaphang = new List<ChiTiet_NhapHang>();
            this.ngay = DateTime.Now;
            this.tongtien = 0;
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
        //KHACHHANG
        public String kh_ten { get; set; }
        public String kh_diachi { get; set; }
        public String kh_email { get; set; }
        public String kh_sdt { get; set; }
        //external
        public virtual List<ChiTiet_DonHang> ds_chitiet_donhang { get; set; }
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
    
    public class TonKho
    {
        public TonKho()
        {
        }
        [Key]
        public int id { get; set; }
        public int soluong { get; set; }
        public DateTime ngay { get; set; }
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
        public DbSet<ChiTiet_NhapHang> ds_chitiet_nhaphang { get; set; }
        public DbSet<NhapHang> ds_nhaphang { get; set; }
        public DbSet<TonKho> ds_tonkho { get; set; }
    }
}