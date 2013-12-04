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
    public class FrontController : Controller
    {
        /*Để các trang Front kế thừa*/
        protected HttpCookie _timkiem_sanpham;
        protected DonHang _giohang;
        public FrontController()
        {
            this._giohang = new DonHang();
            this._khoitao_timkiem_cookie();
        }
        
        [NonAction]
        protected void _khoitao_timkiem_cookie()
        {
            _timkiem_sanpham = new HttpCookie("timkiem_sanpham");
            _timkiem_sanpham.Expires = DateTime.Now.AddDays(1);
            this._timkiem_sanpham["ten"] = "";
            this._timkiem_sanpham["gia_from"] = "0";
            this._timkiem_sanpham["gia_to"] = "0";
            this._timkiem_sanpham["hangsx_id"] = "0";
            this._timkiem_sanpham["order_by"] = "id";
            this._timkiem_sanpham["order_desc"] = "1";
            this._timkiem_sanpham["max_item_per_page"] = "5";
        }
        [NonAction]
        protected void _luu_timkiem_cookie()
        {
            Response.Cookies.Add(CookieLibrary.Base64Encode(this._timkiem_sanpham));
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
            if (Request.Cookies.Get("timkiem_sanpham") == null)
            {
                //chưa set cookies trước => tiến hành set cookies
                this._khoitao_timkiem_cookie();
                Response.Cookies.Add(CookieLibrary.Base64Encode(this._timkiem_sanpham));
            }
            else
            {
                try
                {
                    this._timkiem_sanpham = CookieLibrary.Base64Decode(Request.Cookies.Get("timkiem_sanpham"));
                }
                catch (Exception)
                {
                    this._khoitao_timkiem_cookie();
                    Response.Cookies.Add(CookieLibrary.Base64Encode(this._timkiem_sanpham));
                }
            }
            ViewBag.timkiem_sanpham = this._timkiem_sanpham;
            HangSXController ctr = new HangSXController();
            ViewBag.HangSX_List = ctr.timkiem("", "", "1");
            //CART section
                try
                {
                    if (Session["giohang"] != null)
                    {
                        this._giohang = (DonHang)Session["giohang"];
                    }
                    else
                    {
                        this._giohang = new DonHang();
                    }
                }
                catch (Exception)
                {
                    this._giohang = new DonHang();
                }
                //set session obj
                this._save_cart_to_session();
                ViewBag.giohang = this._giohang;
        }
        [NonAction]
        protected Boolean _save_cart_to_session()
        {
            Session["giohang"] = this._giohang;
            return true;
        }
    }
}
