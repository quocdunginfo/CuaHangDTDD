using BaseClass.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using BaseClass._Library;

namespace BaseClass.ModelControllers
{
    public class MauSacController
    {
        public DTDDDbContext _db;
        public MauSacController()
        {
            this._db = new DTDDDbContext();
        }
        public MauSacController(DTDDDbContext db)
        {
            this._db = db;
        }
        public MauSac get_by_id(int obj_id)
        {
            var obj = this._db.ds_mausac.FirstOrDefault(x => x.id == obj_id);
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
        public int add(MauSac obj)
        {
            this._db.ds_mausac.Add(obj);
            //commit
            this.save();
            //return ma moi nhat
            return this._db.ds_mausac.Max(x => x.id);
        }
        public Boolean delete(MauSac obj)
        {
            //get entity
            obj = this.get_by_id(obj.id);
            //remove
            this._db.ds_mausac.Remove(obj);
            //commit
            return this.save();
        }
        public int timkiem_count(String id = "", String ten = "", String active = "")
        {
            return timkiem(id, ten, active).Count;
        }
        public List<MauSac> timkiem(String id = "", String giatri = "",String active = "", String order_by="id", Boolean order_desc=true, int start_point=0, int count=-1)
        {
            List<MauSac> obj_list = new List<MauSac>();
            //find by LIKE element
            obj_list = this._db.ds_mausac.Where(x => x.giatri.Contains(giatri)
                ).ToList();
            //filter by id                
            if (!id.Equals(""))
            {
                int id_i = TextLibrary.ToInt(id);
                obj_list = obj_list.Where(x => x.id == id_i).ToList();
            }
            
            //Filter again by by active
                if (!active.Equals(""))
                {
                    Boolean active_b = TextLibrary.ToBoolean(active);
                    obj_list = obj_list.Where(x => x.active==active_b).ToList();
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

        public List<string> validate(MauSac obj)
        {
            List<String> re = new List<string>();
            if (obj.giatri.Equals(""))
            {
                re.Add("giatri_fail");
            }
            return re;
        }
    }
}