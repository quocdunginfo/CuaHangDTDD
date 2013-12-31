using BaseClass.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using BaseClass._Library;

namespace BaseClass.ModelControllers
{
    public class SettingController
    {
        public DTDDDbContext _db;
        public SettingController()
        {
            this._db = new DTDDDbContext();
        }
        public SettingController(DTDDDbContext db)
        {
            this._db = db;
        }
        public Setting get_by_id(int obj_id)
        {
            var obj = this._db.ds_setting.FirstOrDefault(x => x.id == obj_id);
            if (obj != null) obj._set_context(this._db);
            return obj;
        }
        public static Setting get_by_key(string key="")
        {
            return new DTDDDbContext().ds_setting.FirstOrDefault(x => x.key.Equals(key));
        }

        public Boolean is_exist(int obj_id)
        {
            return this.get_by_id(obj_id)== null ? false : true;
        }

        public int add(Setting st)
        {
            _db.ds_setting.Add(st);
            save();
            return _db.ds_setting.Max(x => x.id);
        }

        public Boolean save()
        {
            this._db.SaveChanges();
            return true;
        }
    }
}