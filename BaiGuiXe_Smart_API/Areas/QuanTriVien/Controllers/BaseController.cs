using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiGuiXe_Smart_API.Areas.QuanTriVien.Controllers
{
    public class BaseController : Controller
    {
        // GET: QuanTriVien/Base
        public ActionResult Index()
        {
            return View();
        }
    }
}