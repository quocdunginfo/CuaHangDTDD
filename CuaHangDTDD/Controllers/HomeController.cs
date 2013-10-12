using CuaHangDTDD.Controllers.ModelController;
using CuaHangDTDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CuaHangDTDD.Controllers
{
    public class HomeController : WebController
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            NhanVienController ctr = new NhanVienController();
            ViewBag.NhanVien_List = ctr._db.ds_nhanvien.ToList();
            if (ctr.login("admin", "admin"))
            {
                ViewBag.Message = "dang nhap thanh cong!";
            }
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
