using BaseClass.Models;
using System;
using System.Collections.Generic;
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
            //get entity
            obj = this.get_by_id(obj.id);
            //remove
            this._db.ds_nhaphang.Remove(obj);
            //commit
            return this.save();
        }
    }
}
