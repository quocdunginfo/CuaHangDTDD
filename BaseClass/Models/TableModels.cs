using BaseClass._Library;
using BaseClass.ModelControllers;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace BaseClass.Models
{
    public class HinhAnh
    {
        public HinhAnh(DTDDDbContext context)
        {
            this._ctr = new HinhAnhController(context);
            this._Init();
        }
        public HinhAnh()
        {
            this._ctr = new HinhAnhController();
            this._Init();
        }
        private HinhAnhController _ctr;
        private void _Init()
        {
            this.id = 0;
            this.duongdan = "";
            this.duongdan_thumb = "";
            this.macdinh = false;
        }
        public void _set_context(DTDDDbContext context)
        {
            this._ctr._db = context;
        }
        public int id { get; set; }
        public String duongdan { get; set; }//đường dẫn tương đối
        public String duongdan_thumb { get; set; }//đường dẫn tương đối
        public Boolean macdinh { get; set; }//đường dẫn tương đối
        //external
        public virtual SanPham sanpham { get; set; }

        public string _get_full_duongdan(string path_to_website = null)
        {
            if (path_to_website == null)
            {
                path_to_website = Setting.get_by_key("path_to_website");
            }
            string host = path_to_website + "/_Upload/HinhAnh/";
            return host + this.duongdan;
        }
        public string _get_full_duongdan_thumb(string path_to_website = null)
        {
            if (path_to_website == null)
            {
                path_to_website = Setting.get_by_key("path_to_website");
            }
            string host = path_to_website + "/_Upload/HinhAnh/";
            return host + this.duongdan_thumb;
        }
        public HinhAnh _upload_to_host_winform_use_only(string local_file_path="")
        {
            return this._ctr.upload_winform_use_only(local_file_path);
        }
        public HinhAnh _upload_to_host_mvc_use_only(HttpServerUtilityBase server_context, HttpFileCollectionBase file_list)
        {
            return this._ctr.upload_mvc_use_only(server_context, file_list);
        }
        public Boolean delete_winform_use_only()
        {
            return this._ctr.delete_winform_use_only(this);
        }
        public Boolean delete_mvc_use_only(HttpServerUtilityBase server_context)
        {
            return this._ctr.delete_mvc_use_only(this.id, server_context);
        }
    }
    public class SanPham_ChiTiet
    {
        public SanPham_ChiTiet()
        {
            this._ctr = new SanPham_ChiTietController();
            this._Init();
        }
        public SanPham_ChiTiet(DTDDDbContext context)
        {
            this._ctr = new SanPham_ChiTietController(context);
            this._Init();
        }
        private void _Init()
        {
            this.ds_tonkho = new List<TonKho>();
            this.id = 0;
            this.active = true;
            this.tonkho = 0;
        }
        public void _set_context(DTDDDbContext context)
        {
            this._ctr._db = context;
        }
        [Key]
        public int id { get; set; }
        public Boolean active { get; set; }
        public int tonkho { get; set; }
        //external
        public virtual MauSac mausac { get; set; }
        public virtual SanPham sanpham { get; set; }
        public virtual List<TonKho> ds_tonkho { get; set; }
        //CRUD method
        private SanPham_ChiTietController _ctr;
        public Boolean update()
        {
            return _ctr.save();
        }
        public Boolean delete()
        {
            return _ctr.delete(this);
        }
        public int add()
        {
            return _ctr.add(this);
        }
    }
    public class MauSac
    {
        public MauSac()
        {
            this._ctr = new MauSacController();
            this._Init();
        }
        public MauSac(DTDDDbContext context)
        {
            this._ctr = new MauSacController(context);
            this._Init();
        }
        private void _Init()
        {
            this.id = 0;
            this.giatri = "";
            this.active = true;
            this.ds_sanpham_chitiet = new List<SanPham_ChiTiet>();
        }
        public void _set_context(DTDDDbContext context)
        {
            this._ctr._db = context;
        }
        [Key]
        public int id { get; set; }
        public string giatri { get; set; }
        public Boolean active { get; set; }
        //external
        public virtual List<SanPham_ChiTiet> ds_sanpham_chitiet { get; set; }
        //CRUD method
        private MauSacController _ctr;
        public Boolean update()
        {
            return _ctr.save();
        }
        public Boolean delete()
        {
            return _ctr.delete(this);
        }
        public int add()
        {
            return _ctr.add(this);
        }

    }
    public class SanPham
    {
        public SanPham(DTDDDbContext context)
        {
            _ctr = new SanPhamController(context);
            this._Init();
        }
        public SanPham()
        {
            _ctr = new SanPhamController();
            this._Init();
        }
        public void _set_context(DTDDDbContext context)
        {
            this._ctr._db = context;
        }
        private void _Init()
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
            catch (Exception)
            {
                return this.mota + "...";
            }
        }
        //CRUD method
        private SanPhamController _ctr;
        public Boolean update()
        {
            return _ctr.save();
        }
        public Boolean delete()
        {
            return _ctr.delete(this);
        }
        public int add()
        {
            return _ctr.add(this);
        }
    }
    
    public class HangSX
    {
        public HangSX(DTDDDbContext context)
        {
            this._ctr = new HangSXController(context);
            this._Init();
        }
        public HangSX()
        {
            this._ctr = new HangSXController();
            this._Init();
        }
        private void _Init()
        {
            this.ds_sanpham = new List<SanPham>();
            this.id = 0;
            this.ten = "";
            this.active = true;
        }
        public void _set_context(DTDDDbContext context)
        {
            this._ctr._db = context;
        }
        [Key]
        public int id { get; set; }
        public String ten { get; set; }
        public Boolean active { get; set; }
        //external
        public virtual List<SanPham> ds_sanpham { get; set; }
        //method
        public override string ToString()
        {
            return this.ten;
        }
        //CRUD method
        private HangSXController _ctr;
        public Boolean update()
        {
            return _ctr.save();
        }
        public Boolean delete()
        {
            return _ctr.delete(this);
        }
        public int add()
        {
            return _ctr.add(this);
        }
    }

    public class NhapHang
    {
        public NhapHang(DTDDDbContext context)
        {
            this._ctr = new NhapHangController(context);
            this._Init();
        }
        public NhapHang()
        {
            this._ctr = new NhapHangController();
            this._Init();
        }
        private void _Init()
        {
            this.ds_chitiet_nhaphang = new List<ChiTiet_NhapHang>();
            this.id = 0;
            this.ngay = DateTime.Now;
            this.tongtien = 0;
            this.active = true;
        }
        public void _set_context(DTDDDbContext context)
        {
            this._ctr._db = context;
        }
        [Key]
        public int id { get; set; }
        public DateTime ngay { get; set; }
        public int tongtien { get; set; }
        public Boolean active { get; set; }
        //external
        public virtual List<ChiTiet_NhapHang> ds_chitiet_nhaphang { get; set; }
        //CRUD method
        private NhapHangController _ctr;
        public Boolean update()
        {
            return _ctr.save();
        }
        public Boolean delete()
        {
            return _ctr.delete(this);
        }
        public int add()
        {
            return _ctr.add(this);
        }
    }
    public class ChiTiet_NhapHang
    {
        public ChiTiet_NhapHang(DTDDDbContext context)
        {
            this._ctr = new ChiTiet_NhapHangController(context);
            this._Init();
        }
        public ChiTiet_NhapHang()
        {
            this._ctr = new ChiTiet_NhapHangController();
            this._Init();
        }
        private void _Init()
        {
            this.id = 0;
            this.soluong = 0;
            this.dongia = 0;
        }
        public void _set_context(DTDDDbContext context)
        {
            this._ctr._db = context;
        }
        [Key]
        public int id { get; set; }
        public int soluong { get; set; }
        public int dongia { get; set; }
        //external
        public virtual NhapHang nhaphang { get; set; }
        public virtual SanPham_ChiTiet sanpham_chitiet { get; set; }
        //CRUD method
        private ChiTiet_NhapHangController _ctr;
        public Boolean update()
        {
            return _ctr.save();
        }
        public Boolean delete()
        {
            return _ctr.delete(this);
        }
        public int add()
        {
            return _ctr.add(this);
        }
    }
    public class DonHang
    {
        public DonHang(DTDDDbContext context)
        {
            this._ctr = new DonHangController(context);
            this._Init();
        }
        public DonHang()
        {
            this._ctr = new DonHangController();
            this._Init();
        }
        private void _Init()
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
        public void _set_context(DTDDDbContext context)
        {
            this._ctr._db = context;
        }
        private DonHang _Clone()
        {
            DonHang obj = new DonHang();
            obj.id = this.id;
            obj.kh_diachi = this.kh_diachi;
            obj.kh_email = this.kh_email;
            obj.kh_sdt = this.kh_sdt;
            obj.kh_ten = this.kh_ten;
            obj.ngay = this.ngay;
            obj.tongtien = this.tongtien;
            obj.active = this.active;
            obj.dagiaohang = this.dagiaohang;

            ChiTiet_DonHang tmp;
            SanPham_ChiTietController ctr_ = new SanPham_ChiTietController(this._ctr._db);
            foreach (var item in this.ds_chitiet_donhang)
            {
                tmp = new ChiTiet_DonHang();
                tmp.dongia = item.dongia;
                tmp.id = item.id;
                tmp.soluong = item.soluong;
                tmp.sanpham_chitiet = ctr_.get_by_id(item.sanpham_chitiet.id);
                obj.ds_chitiet_donhang.Add(tmp);
            }
            return obj;
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
        private int __get_tongtien()
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
            if (this.__get_tongtien() != this.tongtien)
            {
                return TextLibrary.ToCommaStringNumber(this.__get_tongtien());
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
        public List<string> _update_cart(int chitietsp_id = 0, int chitietsp_soluong = 0)
        {
            List<string> validate = new List<string>();
            ChiTiet_DonHang obj = this.ds_chitiet_donhang.Where(x => x.sanpham_chitiet.id == chitietsp_id).FirstOrDefault();
            if (obj == null)
            {
                validate.Add("no_exist_fail");
                return validate;
            }
            SanPham_ChiTietController ctr = new SanPham_ChiTietController();
            SanPham_ChiTiet in_system = ctr.get_by_id(chitietsp_id);
            if (in_system.tonkho < chitietsp_soluong || chitietsp_soluong<=0)
            {
                validate.Add(chitietsp_id+ "_soluong_fail");
                this.ds_chitiet_donhang.Where(x => x.sanpham_chitiet.id == chitietsp_id).FirstOrDefault().soluong = in_system.tonkho;
                return validate;
            }
            obj.soluong = chitietsp_soluong;
            return validate;
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
        public List<string> validate()
        {
            return _ctr.validate(this);
        }
        //CRUD method
        private DonHangController _ctr;
        public Boolean update()
        {
            return _ctr.save();
        }
        public Boolean delete()
        {
            return _ctr.delete(this);
        }
        public int add()
        {
            return this.id = _ctr.add(this._Clone());
        }
    }
    public class ChiTiet_DonHang
    {
        public ChiTiet_DonHang(DTDDDbContext context)
        {
            this._ctr = new ChiTiet_DonHangController(context);
            this._Init();
        }
        public ChiTiet_DonHang()
        {
            this._ctr = new ChiTiet_DonHangController();
            this._Init();
        }
        private void _Init()
        {
            this.id = 0;
            this.soluong = 0;
            this.dongia = 0;
        }
        public void _set_context(DTDDDbContext context)
        {
            this._ctr._db = context;
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
        //CRUD method
        private ChiTiet_DonHangController _ctr;
        public Boolean update()
        {
            return _ctr.save();
        }
        public Boolean delete()
        {
            return _ctr.delete(this);
        }
        public int add()
        {
            return _ctr.add(this);
        }
    }
    
    public class TonKho
    {
        public TonKho(DTDDDbContext context)
        {
            this._ctr = new TonKhoController(context);
            this._Init();
        }
        public TonKho()
        {
            this._ctr = new TonKhoController();
            this._Init();
        }
        private void _Init()
        {
            this.id = 0;
            this.soluong = 0;
            this.ngay = DateTime.Now;
        }
        public void _set_context(DTDDDbContext context)
        {
            this._ctr._db = context;
        }
        [Key]
        public int id { get; set; }
        public int soluong { get; set; }
        public DateTime ngay { get; set; }
        //external
        public virtual SanPham_ChiTiet sanpham_chitiet { get; set; }
        //CRUD method
        private TonKhoController _ctr;
        public Boolean update()
        {
            return _ctr.save();
        }
        public Boolean delete()
        {
            return _ctr.delete(this);
        }
        public int add()
        {
            return _ctr.add(this);
        }
    }
    public class Setting
    {
        [Key]
        public int id { get; set; }
        public string key { get; set; }
        public string value { get; set; }
        public Setting(DTDDDbContext context)
        {
            this._ctr = new SettingController(context);
            this._Init();
        }
        public Setting()
        {
            this._ctr = new SettingController();
            this._Init();
        }
        public void _Init()
        {
            this.id = 0;
            this.key = "";
            this.value = "";
        }
        public void _set_context(DTDDDbContext context)
        {
            this._ctr._db = context;
        }
        private SettingController _ctr;
        public static string get_by_key(string key="")
        {
            return SettingController.get_by_key(key).value;
        }
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
        public DbSet<MauSac> ds_mausac { get; set; }
        public DbSet<Setting> ds_setting { get; set; }
    }
}