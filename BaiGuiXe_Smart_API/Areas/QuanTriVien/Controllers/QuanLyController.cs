using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiGuiXe_Smart_API.Models.BaiXe;
using BaiGuiXe_Smart_API.Models.LoaiXe;

namespace BaiGuiXe_Smart_API.Areas.QuanTriVien.Controllers
{
    public class QuanLyController : Controller
    {
       
        // GET: QuanTriVien/QuanLy
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult QLBaiXe()
        {
<<<<<<< HEAD
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
=======
            BaiXe_Model baixe_model = new BaiXe_Model();
            var bxlist = baixe_model.FindAll();

            return View(bxlist);
>>>>>>> 65e09f647cf13c960aea28d0e4a56de10d7701c4
        }
        public ActionResult QLLoaiXe()
        {
            LoaiXe_Model lx_model = new LoaiXe_Model();
            var lxlist = lx_model.FindAll();
            return View(lx_model);
        }
    }
}