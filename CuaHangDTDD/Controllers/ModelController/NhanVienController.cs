using CuaHangDTDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CuaHangDTDD._Library;
using System.Diagnostics;

namespace CuaHangDTDD.Controllers.ModelController
{
    public class NhanVienController
    {
        public DTDDDbContext _db = new DTDDDbContext();
        public Boolean login(String username, String raw_password)
        {
            if (username == null || raw_password == null) return false;
            //hash input password
            String h_password = TextLibrary.GetSHA1HashData(raw_password);
            //get password from db
            var db_pass = (from u in this._db.ds_nhanvien
                            where u.tendangnhap == username
                            && u.active == true
                            select u.matkhau).FirstOrDefault();
            //check error
            if (db_pass == null) return false;
            //validate and return
            Debug.WriteLine(h_password + db_pass);
            return h_password.Equals(db_pass.ToString()) ? true : false;
        }
        public NhanVien get_by_username(String username)
        {
            if (username == null) return null;
            return _db.ds_nhanvien.FirstOrDefault(x => x.tendangnhap == username);
        }
        public NhanVien get_by_id(int obj_id)
        {
            return _db.ds_nhanvien.FirstOrDefault(x => x.id == obj_id);
        }
        public Boolean change_password(int obj_id, String old_raw_pass, String new_raw_pass)
        {
            //check
            if (!this.is_exist(obj_id) || old_raw_pass == null || new_raw_pass == null) return false;
            //get obj
            NhanVien obj = this.get_by_id(obj_id);
            //check old pass
            if (TextLibrary.GetSHA1HashData(old_raw_pass) == obj.matkhau)
            {
                //hash password
                obj.matkhau = TextLibrary.GetSHA1HashData(new_raw_pass);
                //commit
                this._db.SaveChanges();
                return true;
            }
            return false;
        }
        public Boolean set_password(int obj_id, String new_raw_or_hash_pass)
        {
            //check not exist or null
            if (!this.is_exist(obj_id) || new_raw_or_hash_pass == null) return false;
            //get obj
            NhanVien obj = this.get_by_id(obj_id);
            if (obj.matkhau.Equals(new_raw_or_hash_pass))
            {
                //neu nhu new_raw_pass da dc hash thi bo qua//!!!!!!!!!!!!!!!!!!!!be careful
                return true;
            }
            //hash password
            obj.matkhau = TextLibrary.GetSHA1HashData(new_raw_or_hash_pass);
            //commit
            this._db.SaveChanges();
            return true;
        }
        public NhanVien get_by_id_hash_password(int obj_id, String hash_password)
        {
            if (hash_password == null) return null;
            NhanVien re = (from user in _db.ds_nhanvien
                            where user.id == obj_id
                            && user.matkhau == hash_password
                            && user.active == true
                            select user).FirstOrDefault();
            return re;
        }
        public Boolean is_exist(int id)
        {
            NhanVien u = (from user in _db.ds_nhanvien
                            where user.id == id
                            select user).FirstOrDefault();
            return u == null ? false : true;
        }
        public int add(NhanVien obj)
        {
            //hash password first
            obj.matkhau = TextLibrary.GetSHA1HashData(obj.matkhau);
            //call add
            this._db.ds_nhanvien.Add(obj);
            //commit
            this._db.SaveChanges();
            //return ma moi nhat
            return this._db.ds_nhanvien.Max(x => x.id);
        }
        public Boolean delete(int id)
        {
            NhanVien obj = this._db.ds_nhanvien.Where(x => x.id == id).FirstOrDefault();
            if (obj == null) return false;
            this._db.ds_nhanvien.Remove(obj);
            this._db.SaveChanges();
            return true;
        }
        public List<NhanVien> timkiem(String id = "", String tendangnhap = "", String tendaydu = "", String email = "", String active = "", String group_name = "")
        {
            List<NhanVien> obj_list = new List<NhanVien>();
            if (!id.Equals(""))
            {
                //find by id
                int id_i = TextLibrary.ToInt(id);
                obj_list = this._db.ds_nhanvien.Where(x => x.id == id_i).ToList();
                if (obj_list == null)
                {
                    obj_list = new List<NhanVien>();
                }
                return obj_list;
            }
            //find by LIKE elament
            obj_list = this._db.ds_nhanvien.Where(x => x.tendangnhap.Contains(tendangnhap)
                && x.tendaydu.Contains(tendaydu)
                && x.email.Contains(email)).ToList();
            if (obj_list == null)
            {
                obj_list = new List<NhanVien>();
            }
            //Filter again by by active
            if (!active.Equals(""))
            {
                Boolean active_b = active.Equals("1") ? true : false;
                obj_list = obj_list.Where(x => x.active == active_b).ToList();
            }
            if (obj_list == null)
            {
                obj_list = new List<NhanVien>();
            }
            //Filter again by by group_name
            if (!group_name.Equals(""))
            {
                obj_list = obj_list.Where(x => x.loainhanvien.ten.ToUpper().Contains(group_name.ToUpper())).ToList();
            }
            if (obj_list == null)
            {
                obj_list = new List<NhanVien>();
            }
            //FINAL return
            return obj_list;
        }
    }
}