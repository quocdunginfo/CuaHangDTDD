using BaseClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseClass.ModelControllers
{
    public class ChiTiet_NhapHangController
    {
        public DTDDDbContext _db;
        public ChiTiet_NhapHangController()
        {
            this._db = new DTDDDbContext();
        }
        public ChiTiet_NhapHangController(DTDDDbContext db)
        {
            this._db = db;
        }
        public ChiTiet_NhapHang get_by_id(int obj_id)
        {
            return _db.ds_chitiet_nhaphang.FirstOrDefault(x => x.id == obj_id);
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
        public int add(ChiTiet_NhapHang obj)
        {
            this._db.ds_chitiet_nhaphang.Add(obj);
            //commit
            this.save();
            //return ma moi nhat
            return this._db.ds_chitiet_nhaphang.Max(x => x.id);
        }
        public Boolean delete(ChiTiet_NhapHang obj)
        {
            //get entity
            obj = this.get_by_id(obj.id);
            //remove
            this._db.ds_chitiet_nhaphang.Remove(obj);
            //commit
            return this.save();
        }
        
    }
}
