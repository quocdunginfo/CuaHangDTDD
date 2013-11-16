using BaseClass._Library;
using BaseClass.ModelController;
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
        //
        // GET: /FrontCart/

        public ActionResult Index()
        {
            ViewBag.giohang = this._giohang;
            return View();
        }
        [HttpPost]
        public ActionResult Submit()
        {
            int chitietsp_id = TextLibrary.ToInt(Request["giohang_chitietsp_id"]);
            int chitietsp_soluong = TextLibrary.ToInt(Request["giohang_chitietsp_soluong"]);
            this._giohang._update_cart(chitietsp_id,chitietsp_soluong);
            //save to session
            this._save_cart_to_session();
            return RedirectToAction("Index", "FrontCart");
        }
        [HttpPost]
        public ActionResult Remove()
        {
            int chitietsp_id = TextLibrary.ToInt(Request["giohang_chitietsp_id"]);
            this._giohang._remove_from_cart(chitietsp_id);
            //save to session
            this._save_cart_to_session();
            return RedirectToAction("Index", "FrontCart");
        }
        

    }
}
