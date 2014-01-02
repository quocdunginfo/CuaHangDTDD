using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseClass.Models;
using BaseClass._Library;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using BaseClass.ModelControllers;
using System.Net;
using System.Text;

namespace BaseClass.ModelControllers
{
    public class HinhAnhController : Controller
    {
        public DTDDDbContext _db;
        public HinhAnhController(DTDDDbContext db)
        {
            this._db = db;
        }
        public HinhAnhController()
        {
            this._db = new DTDDDbContext();
        }
        public HinhAnh get_by_id(int obj_id)
        {
            var obj = this._db.ds_hinhanh.FirstOrDefault(x => x.id == obj_id);
            if (obj != null) obj._set_context(this._db);
            return obj;
        }
        public Boolean is_exist(int id)
        {
            HinhAnh u = (from kt in _db.ds_hinhanh
                           where kt.id == id
                           select kt).FirstOrDefault();
            return u == null ? false : true;
        }
        public Boolean edit(HinhAnh kt)
        {
            if (this.is_exist(kt.id))
            {
                HinhAnh obj = this.get_by_id(kt.id);
                obj.duongdan = kt.duongdan;
                _db.SaveChanges();
                return true;
            }
            return false;
        } 
        public int add(HinhAnh dt)
        {
            _db.ds_hinhanh.Add(dt);
            _db.SaveChanges();
            return _db.ds_hinhanh.Max(x => x.id);
        }
        public Boolean save()
        {
            this._db.SaveChanges();
            return true;
        }
        public void clean_db()
        {
            List<HinhAnh> list = _db.ds_hinhanh.Where(ha => ha.sanpham == null).ToList();
            foreach (HinhAnh ha in list) ha.delete();
        }

        public Boolean delete_winform_use_only(HinhAnh obj)
        {
            try
            {
                string url = Setting.get_by_key("path_to_website") + "/ImageUpload/Delete?hinhanh_id=" + obj.id;
                WebClient webClient = new WebClient();
                string result = webClient.DownloadString(url);
                if (TextLibrary.ToBoolean(result.Substring(0,1)))
                {
                    _db.Entry<HinhAnh>(obj).State = System.Data.EntityState.Detached;

                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
        }
        public Boolean delete_mvc_use_only(int id, HttpServerUtilityBase server_context)
        {
            try
             {
                HinhAnh kq = this.get_by_id(id);
                if (kq == null) return false;
                //first delete file
                try
                {
                    String directory = "~/_Upload/HinhAnh/";
                    System.IO.File.Delete(server_context.MapPath(Path.Combine(directory, kq.duongdan)));
                    System.IO.File.Delete(server_context.MapPath(Path.Combine(directory, kq.duongdan_thumb)));
                    
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("qqqqqqqqqqqq"+ex.ToString());
                }
                //delete in database
                _db.ds_hinhanh.Remove(kq);
                _db.SaveChanges();
                return true;
             }
             catch (Exception ex)
             {
                 Debug.WriteLine(ex.ToString());
                 return false;
             }

        }
        public Boolean set_default(int id)
        {
            //get hinhanh obj
            HinhAnh obj = this.get_by_id(id);
            if (obj == null || obj.sanpham == null)
            {
                return false;
            }
            //get sanpham obj
            SanPhamController ctr_sanpham=new SanPhamController(this._db);
            SanPham sanpham = ctr_sanpham.get_by_id(obj.sanpham.id);
            //get all hinhanh belong to this sanpham
            List<HinhAnh> hinhanh_list = this._db.ds_hinhanh.Where(x => x.sanpham.id == sanpham.id).ToList();
            //set all to non-default
            foreach (HinhAnh item in hinhanh_list)
            {
                item.macdinh = false;
                //set to default
                if (item.id == obj.id)
                {
                    item.macdinh = true;
                }
            }
            this._db.SaveChanges();
            return true;
        }
        public HinhAnh upload_mvc_use_only(HttpServerUtilityBase server_context, HttpFileCollectionBase file_list)
        {
            Debug.WriteLine("file count: "+file_list.Count);
            //pre setting
            int max_width_height = 300;
            String relative_directory = "~/_Upload/HinhAnh/";
            //
            String server_path = "";
            String server_path_thumb = "";
            foreach (string file_name in file_list)
            {
                HttpPostedFileBase hpf = file_list[file_name];
                string _ext = Path.GetExtension(hpf.FileName);
                String random_prefix = TextLibrary.GetSHA1HashData(DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString() + file_name).Substring(0,20);
                server_path = server_context.MapPath(Path.Combine(relative_directory, random_prefix + _ext /* + Path.GetFileName(hpf.FileName)*/));

                server_path_thumb = server_context.MapPath(Path.Combine(relative_directory, "_thumb_" + random_prefix + _ext /* + Path.GetFileName(hpf.FileName)*/));
                if (hpf.ContentLength == 0)
                {
                    continue;
                }
                HinhAnh hinhanh = new HinhAnh();
                //save origin
                    hpf.SaveAs(server_path);
                    hinhanh.duongdan = random_prefix + _ext;
                //save thumb
                    Image imgOriginal = Image.FromFile(server_path);
                    Image hinhanh_thumb = ImageLibrary.ScaleBySize(imgOriginal, max_width_height);
                    imgOriginal.Dispose();
                    hinhanh_thumb.Save(server_path_thumb);
                    hinhanh_thumb.Dispose();
                    hinhanh.duongdan_thumb = "_thumb_" + random_prefix + _ext;
                //add to re
                return hinhanh;
            }
            return new HinhAnh();
        }
        public HinhAnh upload_winform_use_only(string local_file_path="")
        {
            string fileToUpload = local_file_path;
            string url = Setting.get_by_key("path_to_website") + "/ImageUpload/Index";
            using (var client = new WebClient())
            {
                byte[] result = client.UploadFile(url, "POST", fileToUpload);
                string responseAsString = Encoding.UTF8.GetString(result);
                //ngan ket qua bang cac dau |
                string[] file_names = responseAsString.Split('|');
                HinhAnh re = new HinhAnh();
                re.duongdan = file_names[0];
                re.duongdan_thumb = file_names[1];
                return re;
            }
        }
    }
}
