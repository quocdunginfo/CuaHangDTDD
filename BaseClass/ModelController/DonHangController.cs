using BaseClass.Models;
using System;
using System.Collections.Generic;
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
            return _db.ds_donhang.FirstOrDefault(x => x.id == obj_id);
        }
        public Boolean is_exist(int obj_id)
        {
            return this.get_by_id(obj_id)== null ? false : true;
        }
        public Boolean save()
        {
            this.save();
            return true;
        }
        public int add(DonHang obj)
        {
            this._db.ds_donhang.Add(obj);
            //commit
            this.save();
            //return ma moi nhat
            return this._db.ds_donhang.Max(x => x.id);
        }
        public Boolean delete(DonHang obj)
        {
            //get entity
            obj = this.get_by_id(obj.id);
            //remove
            this._db.ds_donhang.Remove(obj);
            //commit
            return this.save();
        }
        
    }
}
