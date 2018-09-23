using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiGuiXe_Smart_API.Models.BaiXe;

namespace BaiGuiXe_Smart_API.Areas.QuanTriVien.Controllers
{
    public class QuanLyController : Controller
    {
        BaiXe_Model baixe_model = new BaiXe_Model();
        // GET: QuanTriVien/QuanLy
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult QLBaiXe()
        {
            var session = (BaiGuiXe_Smart_API.Models.UserSession.UserSession)Session["loginsession"];
            if(session != null)
            {
                var bxlist = baixe_model.FindChuSoHuu(session.Id);
                return View(bxlist);
            }
            else
            {
                return View();
            }
        }
    }
}