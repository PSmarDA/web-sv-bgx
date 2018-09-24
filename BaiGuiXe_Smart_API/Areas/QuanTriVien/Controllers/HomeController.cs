using BaiGuiXe_Smart_API.Models;
using BaiGuiXe_Smart_API.Models.UserSession;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiGuiXe_Smart_API.Areas.QuanTriVien.Controllers
{
    public class HomeController : BaseController
    {
        // GET: QuanTriVien/Home
        UserModel use_Mod = new UserModel();
        // GET: QuanTriVien/Home
        public ActionResult Index()
        {
            return View();
        }
        
    }
} 
    