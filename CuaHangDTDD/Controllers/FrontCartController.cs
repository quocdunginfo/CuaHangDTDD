using BaseClass._Library;
using BaseClass.ModelControllers;
using BaseClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CuaHangDTDD.Controllers
{
    public class FrontCartController : FrontController
    {
        public ActionResult Index()
        {
            ViewBag.giohang = this._giohang;
            List<string> validate = this._giohang.validate();
            ViewBag.state = TempData["state"] == null ? validate : (List<string>)TempData["state"];
            return View();
        }
        [HttpPost]
        public ActionResult Submit()
        {
            //prepare
            List<string> validate;
            //get post value
            int chitietsp_id = TextLibrary.ToInt(Request["giohang_chitietsp_id"]);
            int chitietsp_soluong = TextLibrary.ToInt(Request["giohang_chitietsp_soluong"]);
            //do action and validate
            validate = this._giohang._update_cart(chitietsp_id, chitietsp_soluong);
            //set temp data
            TempData["state"] = validate;
            //save cart to session
            this._save_cart_to_session();
            //redirect
            return RedirectToAction("Index", "FrontCart");
        }
        [HttpPost]
        public ActionResult Remove()
        {
            //get post value
            int chitietsp_id = TextLibrary.ToInt(Request["giohang_chitietsp_id"]);
            //do action
            this._giohang._remove_from_cart(chitietsp_id);
            //save cart to session
            this._save_cart_to_session();
            //redirect
            return RedirectToAction("Index", "FrontCart");
        }
        /*
         * Hiện thông form nhập thông tin KH
         */
        [HttpGet]
        public ActionResult CheckOut()
        {
            ViewBag.giohang = this._giohang;
            List<string> validate = this._giohang.validate();
            if(validate.Contains("rong_fail"))
            {
                //đơn hàng rỗng không được phép thanh toán
                TempData["state"] = validate;
                return RedirectToAction("Index","FrontCart");
            }
            ViewBag.state = TempData["state"] == null ? new List<string>() : (List<string>)TempData["state"];
            return View();
        }
        [HttpPost]
        public ActionResult CheckOut_Submit()
        {
            //prepare material
            List<String> validate;
            //get post value
            this._giohang.kh_ten = TextLibrary.ToString(Request["ten"]);
            this._giohang.kh_diachi = TextLibrary.ToString(Request["diachi"]);
            this._giohang.kh_email = TextLibrary.ToString(Request["email"]);
            this._giohang.kh_sdt = TextLibrary.ToString(Request["sdt"]);
            //validate
            validate = this._giohang.validate();
            //check stable
            if (validate.Count == 0)
            {
                //ready
                this._giohang.add();
                //redirect
                return RedirectToAction("Finish","FrontCart");
            }
            TempData["state"] = validate;
            return RedirectToAction("CheckOut","FrontCart");
        }
        [HttpGet]
        public ActionResult Finish()
        {
            //xóa đơn hàng khỏi session
            this._giohang = new DonHang();
            this._save_cart_to_session();
            //cập nhật giohang cho View ngay lập tức
            ViewBag.giohang = this._giohang;
            return View();
        }
    }
}
