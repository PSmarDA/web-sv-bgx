using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            return View();
        }
    }
}