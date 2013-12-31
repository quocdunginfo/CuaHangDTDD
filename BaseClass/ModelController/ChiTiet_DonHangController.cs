using BaseClass.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseClass.ModelControllers
{
    public class ChiTiet_DonHangController
    {
        public DTDDDbContext _db;
        public ChiTiet_DonHangController()
        {
            this._db = new DTDDDbContext();
        }
        public ChiTiet_DonHangController(DTDDDbContext db)
        {
            this._db = db;
        }
        public ChiTiet_DonHang get_by_id(int obj_id)
        {
            var obj = this._db.ds_chitiet_donhang.FirstOrDefault(x => x.id == obj_id);
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
        public int add(ChiTiet_DonHang obj)
        {
            this._db.ds_chitiet_donhang.Add(obj);
            //commit
            this.save();
            //return ma moi nhat
            return this._db.ds_chitiet_donhang.Max(x => x.id);
        }
        public Boolean delete(ChiTiet_DonHang obj)
        {
            try
            {
                //get entity
                obj = this.get_by_id(obj.id);
                //remove
                this._db.ds_chitiet_donhang.Remove(obj);
                //commit
                return this.save();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }

        }
        
    }
}
