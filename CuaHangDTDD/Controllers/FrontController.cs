using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CuaHangDTDD.Models;
using CuaHangDTDD._Library;

namespace CuaHangDTDD.Controllers
{
    public class FrontController : Controller
    {
        //
        // GET: /Web/
        protected HttpCookie _timkiem_sanpham;
        [NonAction]
        protected void _khoitao_cookie()
        {
            _timkiem_sanpham = new HttpCookie("front_timkiem_sanpham");
            _timkiem_sanpham.Expires = DateTime.Now.AddDays(1);
            this._timkiem_sanpham["ten"] = "";
            this._timkiem_sanpham["masp"] = "";
            this._timkiem_sanpham["mota"] = "";
            this._timkiem_sanpham["gia_from"] = "-1";
            this._timkiem_sanpham["gia_to"] = "-1";
            this._timkiem_sanpham["hangsx_ten"] = "";
            this._timkiem_sanpham["max_item_per_page"] = "9";
        }
        public ActionResult Index2()
        {
            return RedirectToAction("Index","FrontHome");
        }
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            ViewBag.Title = "Cửa hàng DTDD";
            //tim kiem
            //build timkiem_nhanvien
            if (Request.Cookies.Get("front_timkiem_sanpham") == null)
            {
                //chưa set cookies trước => tiến hành set cookies
                this._khoitao_cookie();
                Response.Cookies.Add(CookieLibrary.Base64Encode(this._timkiem_sanpham));
            }
            else
            {
                try
                {
                    this._timkiem_sanpham = CookieLibrary.Base64Decode(Request.Cookies.Get("timkiem_sanpham"));
                }
                catch (Exception ex)
                {
                    this._khoitao_cookie();
                    Response.Cookies.Add(CookieLibrary.Base64Encode(this._timkiem_sanpham));
                }
            }
            ViewBag.timkiem_sanpham = this._timkiem_sanpham;
        }

    }
}
