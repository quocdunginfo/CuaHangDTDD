using BaseClass.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseClass.ModelControllers
{
    public class NhapHangController 
    {
        public DTDDDbContext _db;
        public NhapHangController()
        {
            this._db = new DTDDDbContext();
        }
        public NhapHangController(DTDDDbContext db)
        {
            this._db = db;
        }
        public NhapHang get_by_id(int obj_id)
        {
            var obj = this._db.ds_nhaphang.FirstOrDefault(x => x.id == obj_id);
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
        public int add(NhapHang obj)
        {
            this._db.ds_nhaphang.Add(obj);
            //commit
            this.save();
            //return ma moi nhat
            return this._db.ds_nhaphang.Max(x => x.id);
        }
        public Boolean delete(NhapHang obj)
        {
            try
            {
                //get entity
                obj = this.get_by_id(obj.id);
                //remove relation
                foreach (ChiTiet_NhapHang ctnh in obj.ds_chitiet_nhaphang) ctnh.delete();

                //remove
                this._db.ds_nhaphang.Remove(obj);
                //commit
                return this.save();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
            
        }
        public void reload(NhapHang nh)
        {
            List<ChiTiet_NhapHang> Added = new List<ChiTiet_NhapHang>();
            List<ChiTiet_NhapHang> Deleted = _db
                .ChangeTracker.Entries<ChiTiet_NhapHang>()
                .Where(ctnh => ctnh.Entity.nhaphang == null)
                .Select(ct => ct.Entity).ToList<ChiTiet_NhapHang>();

            foreach (ChiTiet_NhapHang ctnh in Added) nh.ds_chitiet_nhaphang.Remove(ctnh);
            foreach (ChiTiet_NhapHang ctnh in Deleted) _db.Entry<ChiTiet_NhapHang>(ctnh).Reload();
        }

        public List<NhapHang> get_list()
        {
            return _db.ds_nhaphang.ToList();
        }
    }
}
