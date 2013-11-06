using CuaHangDTDD._Library;
using CuaHangDTDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using CuaHangDTDD.Models;
using CuaHangDTDD._Library;

namespace CuaHangDTDD.ModelController
{
    public class SanPhamController
    {
        public DTDDDbContext _db = new DTDDDbContext();
        public SanPhamController()
        {

        }
        public SanPhamController(DTDDDbContext db)
        {
            this._db = db;
        }
        
        public SanPham get_by_id(int obj_id)
        {
            return _db.ds_sanpham.FirstOrDefault(x => x.id == obj_id);
        }
        public SanPham get_by_masp(String masp)
        {
            return _db.ds_sanpham.FirstOrDefault(x => x.masp.ToUpper().Equals(masp.ToUpper()));
        }

        public Boolean is_exist(int obj_id)
        {
            SanPham obj = this.get_by_id(obj_id);
            return obj == null ? false : true;
        }
        public Boolean is_exist_masp(String masp)
        {
            SanPham obj = this.get_by_masp(masp);
            return obj == null ? false : true;
        }
        public int add(SanPham obj)
        {
            //call add
            this._db.ds_sanpham.Add(obj);
            //commit
            this._db.SaveChanges();
            //return ma moi nhat
            return this._db.ds_sanpham.Max(x => x.id);
        }
        public Boolean delete(int obj_id)
        {
            //get entity
            SanPham obj = this.get_by_id(obj_id);
            //check null
            if (obj == null) return false;
            //remove
            this._db.ds_sanpham.Remove(obj);
            //commit
            this._db.SaveChanges();
            return true;
        }
        public int timkiem_count(String id = "", String masp = "", String ten = "", String mota = "", int gia_from = -1, int gia_to = -1, List<HangSX> hangsx_list = null, String active = "")
        {
            return timkiem(id, masp, ten, mota, gia_from, gia_to, hangsx_list,active).Count;
        }
        public List<SanPham> timkiem(String id = "", String masp = "", String ten = "", String mota = "", int gia_from = -1, int gia_to = -1, List<HangSX> hangsx_list = null, String active = "", String order_by = "id", Boolean order_desc = true, int start_point = 0, int count = -1)
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
            if (gia_from>-1 && gia_to>-1)
            {
                obj_list = obj_list.Where(x => x.gia >= gia_from && x.gia<=gia_to).ToList();
            }
            //filter by HangSX List
            if (hangsx_list != null)
            {
                //build list id
                List<int> hangsx_id_list = new List<int>();
                hangsx_id_list= hangsx_list.Select(x => x.id).ToList();
                //query
                obj_list = obj_list.Where(x => hangsx_id_list.Contains(x.hangsx.id)).ToList();
            }
            
            //Filter again by by active
            if (!active.Equals(""))
            {
                Boolean active_b = TextLibrary.ToBoolean(active);
                obj_list = obj_list.Where(x => x.active == active_b).ToList();
            }

            //order
            if (order_desc)
            {
                obj_list = obj_list.OrderByDescending(x => x.id).ToList();
            }
            else
            {
                obj_list = obj_list.OrderBy(x => x.id).ToList();
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
            SanPham u = (from obj in _db.ds_sanpham
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
            if (!this.can_use_masp(obj.id, obj.masp))
            {
                re.Add("masp_exist_fail");
            }
            return re;
        }
    }
}