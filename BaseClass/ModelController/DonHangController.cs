using BaseClass._Library;
using BaseClass.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseClass.ModelControllers
{
    public class DonHangController
    {
        public DTDDDbContext _db;
        public DonHangController()
        {
            this._db = new DTDDDbContext();
        }
        public DonHangController(DTDDDbContext db)
        {
            this._db = db;
        }
        public DonHang get_by_id(int obj_id)
        {
            var obj = this._db.ds_donhang.FirstOrDefault(x => x.id == obj_id);
            if (obj != null) obj._set_context(this._db);
            return obj;
        }
        public Boolean is_exist(int obj_id)
        {
            return this.get_by_id(obj_id)== null ? false : true;
        }
        public Boolean save()
        {
            this._db.SaveChanges();
            return true;
        }
        public int add(DonHang obj)
        {
            //tinh toán tong tiền
                int sum = 0;
                foreach (var item in obj.ds_chitiet_donhang)
                {
                    item.dongia = item.sanpham_chitiet.sanpham.gia;//for sure
                    sum += item.dongia * item.soluong;
                    //cập nhật tồn kho trên sản phẩm
                        item.sanpham_chitiet.tonkho -= item.soluong;
                        if (item.sanpham_chitiet.tonkho < 0)
                        {
                            item.sanpham_chitiet.tonkho = 0;
                        }
                        //thêm log tồn kho
                            TonKho tk = new TonKho();
                            tk.ngay = obj.ngay;
                            tk.soluong = item.sanpham_chitiet.tonkho;
                            item.sanpham_chitiet.ds_tonkho.Add(tk);
                }
                obj.tongtien = sum;
            //call add
            this._db.ds_donhang.Add(obj);
            //commit
            this.save();
            //return ma moi nhat
            return this._db.ds_donhang.Max(x => x.id);
        }
        public Boolean delete(DonHang obj)
        {
            try
            {
                //get entity
                obj = this.get_by_id(obj.id);

                if (obj.dagiaohang) return false;
                //remove relations
                while (obj.ds_chitiet_donhang.Count > 0)
                {
                    ChiTiet_DonHang ctdh = obj.ds_chitiet_donhang[0];
                    ctdh._set_context(_db);
                    // set lai so luong va ton kho
                    ctdh.sanpham_chitiet.update_tonkho(ctdh.sanpham_chitiet.tonkho + ctdh.soluong, DateTime.Now); 

                    ctdh.delete();
                }

                //remove
                this._db.ds_donhang.Remove(obj);
                //commit
                return this.save();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
            
        }

        public List<string> validate(DonHang obj)
        {
            List<string> re = new List<string>();
            if (obj.ds_chitiet_donhang.Count == 0)
            {
                re.Add("rong_fail");
            }
            if (obj.kh_diachi.Equals(""))
            {
                re.Add("kh_diachi_fail");
            }
            if (obj.kh_ten.Equals(""))
            {
                re.Add("kh_ten_fail");
            }
            if (obj.kh_email.Equals("") || !ValidateLibrary.is_valid_email(obj.kh_email))
            {
                re.Add("kh_email_fail");
            }
            if (obj.kh_sdt.Equals(""))
            {
                re.Add("kh_sdt_fail");
            }
            //xét tồn kho
            foreach (var item in obj.ds_chitiet_donhang)
            {
                if (item.sanpham_chitiet.tonkho < item.soluong || item.soluong<=0)
                {
                    re.Add(item.sanpham_chitiet.id+"_soluong_fail");
                }
            }
            return re;
        }
        public List<DonHang> get_list()
        {
            return _db.ds_donhang.ToList();
        }
        public List<ChiTiet_DonHang> Lay_ThongTin_BanHang(List<DateTime> thoigian)
        {
            List<ChiTiet_DonHang> list = new List<ChiTiet_DonHang>();

            foreach (DonHang dh in get_list())
            {
                if (!dh.dagiaohang) continue;
                if (thoigian.Where(tg => tg.Year == dh.ngay.Year && tg.Month == dh.ngay.Month && tg.Day == dh.ngay.Day).FirstOrDefault() == null) continue;

                foreach (ChiTiet_DonHang ctdh in dh.ds_chitiet_donhang)
                {
                    ChiTiet_DonHang ctdh_in_list = list.Where(l => l.sanpham_chitiet.id == ctdh.sanpham_chitiet.id).FirstOrDefault();
                    if (ctdh_in_list == null) list.Add(ctdh._clone());
                    else
                    {
                        ctdh_in_list.soluong += ctdh.soluong;
                        ctdh_in_list.thanhtien += ctdh.soluong * ctdh.dongia;
                    }
                }
            }

            return list;
        }

        public void reload(DonHang dh)
        {
            
            foreach (ChiTiet_DonHang ctdh in dh.ds_chitiet_donhang)
            {
                try
                {
                    _db.Entry<SanPham_ChiTiet>(ctdh.sanpham_chitiet).Reload();
                }
                catch (Exception) { continue; }
            }
        }
    }
}
