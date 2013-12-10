using BaseClass.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseClass.ModelControllers
{
    public class TonKhoController
    {
        public DTDDDbContext _db;
        public TonKhoController()
        {
            this._db = new DTDDDbContext();
        }
        public TonKhoController(DTDDDbContext db)
        {
            this._db = db;
        }
        public TonKho get_by_id(int obj_id)
        {
            var obj = this._db.ds_tonkho.FirstOrDefault(x => x.id == obj_id);
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
        public int add(TonKho obj)
        {
            this._db.ds_tonkho.Add(obj);
            //commit
            this.save();
            //return ma moi nhat
            return this._db.ds_tonkho.Max(x => x.id);
        }
        public Boolean delete(TonKho obj)
        {
            try
            {
                //get entity
                obj = this.get_by_id(obj.id);
                //remove
                this._db.ds_tonkho.Remove(obj);
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
