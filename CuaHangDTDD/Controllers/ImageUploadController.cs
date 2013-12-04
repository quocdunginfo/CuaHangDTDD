using BaseClass._Library;
using BaseClass.ModelControllers;
using BaseClass.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CuaHangDTDD.Controllers
{
    public class ImageUploadController : Controller
    {
        [HttpPost]
        public ActionResult Index()
        {
            HinhAnhController ctr = new HinhAnhController();
            HinhAnh re = ctr.upload_mvc_use_only(Server, Request.Files);
            ViewBag.Message = re.duongdan + "|" + re.duongdan_thumb;
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int hinhanh_id=0)
        {
            HinhAnhController ctr=new HinhAnhController();
            HinhAnh obj = ctr.get_by_id(hinhanh_id);
            if (obj == null)
            {
                ViewBag.Message = "0";
                return View("Index");
            }
            obj.delete_mvc_use_only(Server);
            ViewBag.Message = "1";
            return View("Index");
        }

    }
}
