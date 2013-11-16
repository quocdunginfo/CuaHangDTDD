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
using BaseClass.ModelController;

namespace CuaHangDTDD.ModelController
{
    public class HinhAnhController : Controller
    {
        //
        // GET: /HinhAnh/
        private DTDDDbContext db;
        public HinhAnhController(DTDDDbContext db)
        {
            this.db = db;
        }
        public HinhAnhController()
        {
            this.db = new DTDDDbContext();
        }
        public HinhAnh get_by_id(int id)
        {
            return db.ds_hinhanh.FirstOrDefault(x => x.id == id);
        }
        public Boolean is_exist(int id)
        {
            HinhAnh u = (from kt in db.ds_hinhanh
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
                db.SaveChanges();
                return true;
            }
            return false;
        } 
        public int add(HinhAnh dt)
        {
            db.ds_hinhanh.Add(dt);
            db.SaveChanges();
            return db.ds_hinhanh.Max(x => x.id);
        }
        public Boolean delete(int id, HttpServerUtilityBase server_context)
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
                Debug.WriteLine(ex.ToString());
            }
            //delete in database
            db.ds_hinhanh.Remove(kq);
            db.SaveChanges();
            return true;
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
            SanPhamController ctr_sanpham=new SanPhamController(this.db);
            SanPham sanpham = ctr_sanpham.get_by_id(obj.sanpham.id);
            //get all hinhanh belong to this sanpham
            List<HinhAnh> hinhanh_list = this.db.ds_hinhanh.Where(x => x.sanpham.id == sanpham.id).ToList();
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
            this.db.SaveChanges();
            return true;
        }
        public List<HinhAnh> upload(HttpServerUtilityBase server_context, HttpFileCollectionBase file_list)
        {
            Debug.WriteLine("file count: "+file_list.Count);
            List<HinhAnh> re=new List<HinhAnh>();
            //pre setting
            int max_width_height = 300;
            String relative_directory = "~/_Upload/HinhAnh/";
            //
            String server_path = "";
            String server_path_thumb = "";
            foreach (string file_name in file_list)
            {
                Debug.WriteLine("file name: " + file_name);
                HttpPostedFileBase hpf = file_list[file_name];
                String random_prefix = TextLibrary.GetSHA1HashData(DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString()).Substring(0,5);
                server_path = server_context.MapPath(Path.Combine(relative_directory, random_prefix + Path.GetFileName(hpf.FileName)));

                server_path_thumb = server_context.MapPath(Path.Combine(relative_directory, "_thumb_" + random_prefix + Path.GetFileName(hpf.FileName)));
                if (hpf.ContentLength == 0)
                {
                    continue;
                }
                HinhAnh hinhanh = new HinhAnh();
                //save origin
                    hpf.SaveAs(server_path);
                    hinhanh.duongdan = random_prefix+hpf.FileName;
                //save thumb
                    Image imgOriginal = Image.FromFile(server_path);
                    Image hinhanh_thumb = ImageLibrary.ScaleBySize(imgOriginal, max_width_height);
                    imgOriginal.Dispose();
                    hinhanh_thumb.Save(server_path_thumb);
                    hinhanh_thumb.Dispose();
                    hinhanh.duongdan_thumb = "_thumb_" + random_prefix+hpf.FileName;
                //add to re
                    re.Add(hinhanh);
                Debug.WriteLine("uploaded: " + server_path);
                Debug.WriteLine("uploaded: " + server_path_thumb);
            }
            return re;
        }
    }
}
