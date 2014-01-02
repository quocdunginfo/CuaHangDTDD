using BaseClass._Library;
using BaseClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Data.Entity.Infrastructure;
using System.Data;
using System.Data.Objects;

namespace BaseClass.ModelControllers
{
    public class SanPhamController
    {
        public DTDDDbContext _db;
        public SanPhamController()
        {
            this._db = new DTDDDbContext();
        }
        public SanPhamController(DTDDDbContext db)
        {
            this._db = db;
        }
        public Boolean save()
        {
            this._db.SaveChanges();
            return true;
        }
        public SanPham get_by_id(int obj_id)
        {
            var obj= this._db.ds_sanpham.FirstOrDefault(x => x.id == obj_id);
            if (obj != null) obj._set_context(this._db);
            return obj;
        }
        public SanPham get_by_masp(String masp)
        {
            return this._db.ds_sanpham.FirstOrDefault(x => x.masp.ToUpper().Equals(masp.ToUpper()));
        }

        public Boolean is_exist(int obj_id)
        {
            SanPham obj = get_by_id(obj_id);
            return obj == null ? false : true;
        }
        public Boolean is_exist_masp(String masp)
        {
            SanPham obj = get_by_masp(masp);
            return obj == null ? false : true;
        }
        public int add(SanPham obj)
        {
            //call add
            this._db.ds_sanpham.Add(obj);
            save();
            return this._db.ds_sanpham.Max(x => x.id);
        }
        public Boolean delete(SanPham obj)
        {
            try
            {
                //reload again to prevent error
                obj = get_by_id(obj.id);

                // remove relations
                while (obj.ds_sanpham_chitiet.Count > 0)
                {
                    SanPham_ChiTiet spct = obj.ds_sanpham_chitiet[0];
                    spct._set_context(obj._ctr._db);
                    spct.delete();
                }

                while (obj.ds_hinhanh.Count > 0)
                {
                    HinhAnh ha = obj.ds_hinhanh[0];
                    ha._set_context(obj._ctr._db);
                    ha.delete();
                }

                this._db.ds_sanpham.Remove(obj);
                //commit
                return save();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }

        }
        public int timkiem_count(String id = "", String masp = "", String ten = "", String mota = "", int gia_from = 0, int gia_to = 0, HangSX hangsx = null, String active = "")
        {
            return timkiem(id, masp, ten, mota, gia_from, gia_to, hangsx ,active).Count;
        }
        public List<SanPham> timkiem(String id = "", String masp = "", String ten = "", String mota = "", int gia_from = 0, int gia_to = 0, HangSX hangsx = null, String active = "", String order_by = "id", Boolean order_desc = true, int start_point = 0, int count = -1)
        {
            List<SanPham> obj_list = new List<SanPham>();
            //find by LIKE element
            obj_list = this._db.ds_sanpham.Where(x =>
                x.masp.Contains(masp)
                && x.ten.Contains(ten)
                && x.mota.Contains(mota)
                ).ToList();

            //filter by id
            if (!id.Equals(""))
            {
                int id_i = TextLibrary.ToInt(id);
                obj_list = obj_list.Where(x => x.id == id_i).ToList();
            }
            //Filter by gia
            if (gia_from>0 || gia_to>0)
            {
                obj_list = obj_list.Where(x => x.gia >= gia_from && x.gia<=gia_to).ToList();
            }
            //filter by HangSX List
            if (hangsx != null)
            {
                obj_list = obj_list.Where(x => x.hangsx.id == hangsx.id).ToList();
            }
            
            //Filter again by by active
            if (!active.Equals(""))
            {
                Boolean active_b = TextLibrary.ToBoolean(active);
                obj_list = obj_list.Where(x => x.active == active_b).ToList();
            }

            //order
            if (order_by.Equals("id"))
            {
                if (order_desc)
                {
                    obj_list = obj_list.OrderByDescending(x => x.id).ToList();
                }
                else
                {
                    obj_list = obj_list.OrderBy(x => x.id).ToList();
                }
            }
            else if (order_by.Equals("gia"))
            {
                if (order_desc)
                {
                    obj_list = obj_list.OrderByDescending(x => x.gia).ToList();
                }
                else
                {
                    obj_list = obj_list.OrderBy(x => x.gia).ToList();
                }
            }

            //limit
            if (count >= 0)
            {
                obj_list = obj_list.Skip(start_point).Take(count).ToList();
            }
            //FINAL return
            return obj_list;
        }
        public Boolean can_use_masp(int obj_id, String masp)
        {
            SanPham u = (from obj in this._db.ds_sanpham
                          where obj.masp.ToUpper().Equals(masp.ToUpper())
                          && obj.id != obj_id
                          select obj).FirstOrDefault();
            return u == null ? true : false;
        }
        public List<String> validate(SanPham obj)
        {
            //
            List<String> re = new List<string>();
            //check
            if (!can_use_masp(obj.id, obj.masp))
            {
                re.Add("masp_exist_fail");
            }
            return re;
        }
        public void reload(SanPham sp)
        {
            List<HinhAnh> Added_HA = new List<HinhAnh>();
            List<HinhAnh> Deleted_HA = _db
                .ChangeTracker.Entries<HinhAnh>()
                .Where(en => en.Entity.sanpham == null && en.Entity.source_picture_from_web)
                .Select(t => t.Entity).ToList<HinhAnh>();

            List<SanPham_ChiTiet> Added_SPCT = new List<SanPham_ChiTiet>();
            List<SanPham_ChiTiet> Deleted_SPCT = _db
                .ChangeTracker.Entries<SanPham_ChiTiet>()
                .Where(en => en.Entity.sanpham == null && en.Entity.id > 0).Select(t => t.Entity)
                .ToList<SanPham_ChiTiet>();

            List<MauSac> Added_MauSac = _db.ChangeTracker.Entries<MauSac>().Where(ms => ms.State == EntityState.Added).Select(t => t.Entity).ToList();

            foreach (HinhAnh ha in sp.ds_hinhanh)
            {
                if (!ha.source_picture_from_web)
                {
                    Added_HA.Add(ha);
                }
                else
                {
                    //reload modified entity
                    _db.Entry<HinhAnh>(ha).Reload();
                }
            }

            foreach (SanPham_ChiTiet spct in sp.ds_sanpham_chitiet)
            {
                if (spct.id == 0)
                {
                    Added_SPCT.Add(spct);
                }
                else
                {
                    //reload modified entity
                    _db.Entry<SanPham_ChiTiet>(spct).Reload();
                }
            }

            //remove added entity
            foreach (HinhAnh ha in Added_HA)
            {
                _db.Entry<HinhAnh>(ha).State = EntityState.Detached;
                sp.ds_hinhanh.Remove(ha);
            }

            foreach (SanPham_ChiTiet spct in Added_SPCT)
            {
                _db.Entry<SanPham_ChiTiet>(spct).State = EntityState.Detached;
                sp.ds_sanpham_chitiet.Remove(spct);
            }

            foreach (MauSac ms in Added_MauSac) _db.Entry<MauSac>(ms).State = EntityState.Detached;

            //reload deleted entity
            foreach (HinhAnh ha in Deleted_HA) _db.Entry<HinhAnh>(ha).Reload();
            foreach (SanPham_ChiTiet spct in Deleted_SPCT) _db.Entry<SanPham_ChiTiet>(spct).Reload();
            
        }
    }
}