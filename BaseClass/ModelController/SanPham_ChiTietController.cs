using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseClass._Library;
using BaseClass.Models;
using System.Diagnostics;

namespace BaseClass.ModelControllers
{
    public class SanPham_ChiTietController : Controller
    {
        public DTDDDbContext _db;
        public SanPham_ChiTietController(DTDDDbContext _db)
        {
            this._db = _db;
        }
        public SanPham_ChiTietController()
        {
            this._db = new DTDDDbContext();
        }
        public SanPham_ChiTiet get_by_id(int obj_id)
        {
            var obj = this._db.ds_sanpham_chitiet.FirstOrDefault(x => x.id == obj_id);
            if (obj != null) obj._set_context(this._db);
            return obj;
        }
        public Boolean is_exist(int id)
        {
           SanPham_ChiTiet u = (from spt in _db.ds_sanpham_chitiet
                             where spt.id == id
                             select spt).FirstOrDefault();
            return u == null ? false : true;
        }
        public int add(SanPham_ChiTiet obj)
        {
            this._db.ds_sanpham_chitiet.Add(obj);
            this.save();
            //return ma moi nhat
            return this._db.ds_sanpham_chitiet.Max(x => x.id);
        }
        public Boolean save()
        {
            this._db.SaveChanges();
            return true;
        }
        public Boolean delete(SanPham_ChiTiet obj)
        {
            try
            {
                obj = get_by_id(obj.id);
                this._db.ds_sanpham_chitiet.Remove(obj);
                return this.save();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }

        }
        public List<SanPham_ChiTiet> timkiem(String id = "", String mausac_id = "", String active = "",String id_sp="")
        {
            List<SanPham_ChiTiet> list=_db.ds_sanpham_chitiet.ToList();
            if (!id.Equals(""))
            {
                //find by id
                int id_i = TextLibrary.ToInt(id);
                list =_db.ds_sanpham_chitiet.Where(x => x.id == id_i).ToList();
                if (list == null)
                {
                    list = new List<SanPham_ChiTiet>();
                }
                return list;
            }
            if(!id_sp.Equals(""))
            {
                int spid=TextLibrary.ToInt(id_sp);
                list=list.Where(x=>x.sanpham.id==spid).ToList();
                if(list==null)
                {
                    list=new List<SanPham_ChiTiet>();
                }
            }
            if(!mausac_id.Equals(""))
            {
                int id_mau=TextLibrary.ToInt(mausac_id);
                list=list.Where(x=>x.mausac.id==id_mau).ToList();
                if(list==null)
                {
                    list=new List<SanPham_ChiTiet>();
                }
            }
            //Filter again by by active
            if (!active.Equals(""))
            {
                Boolean active_b = TextLibrary.ToBoolean(active);
                list = list.Where(x => x.active == active_b).ToList();
                if (list == null)
                {
                    list = new List<SanPham_ChiTiet>();
                }
            }
            //FINAL return
            return list;
        
    }
        public void clean_db()
        {
            List<SanPham_ChiTiet> list = _db.ds_sanpham_chitiet.Where(spct => spct.sanpham == null || spct.mausac == null).ToList();
            foreach (SanPham_ChiTiet spct in list) spct.delete();
        }
        public List<int> Lay_SoLuong_TonKho(List<SanPham_ChiTiet> dssp, List<DateTime> dsngay)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < dssp.Count; i++)
            {
                SanPham_ChiTiet spct = get_by_id(dssp[i].id);
                dssp[i] = spct;
                foreach (DateTime ngay in dsngay)
                {
                    list.Add(spct.lay_tonkho_theo_ngay(ngay));
                }
            }

            return list;
        }
    }
}
