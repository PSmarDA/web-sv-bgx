using BaiGuiXe_Smart_API.Models;
using BaiGuiXe_Smart_API.Models.UserSession;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiGuiXe_Smart_API.Areas.QuanTriVien.Controllers
{
    public class HomeController : Controller
    {
        // GET: QuanTriVien/Home
        UserModel use_Mod = new UserModel();
        // GET: QuanTriVien/Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(FormCollection f)
        {
            if (f["txt_use"] != null && f["txt_pass"] != null)
            {
                MaHoa mh = new MaHoa();
                var pass = mh.md5(f["txt_pass"]);
                var flag = use_Mod.login(f["txt_use"], pass);
                if (flag != null)
                {
                    if (flag.LoaiTaiKhoan == 1)
                    {
                        var usesession = new UserSession();
                        usesession.Id = flag.Id.ToString();
                        usesession.Ten = flag.Ten;
                        usesession.Email = flag.Email;
                        usesession.LoaiTaiKhoan = flag.LoaiTaiKhoan;
                        usesession.XacThucEmail = flag.XacThucEmail;
                        SessionHelper.SetSession(usesession);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Tài khoản của bạn không có quyền truy cập !");
                        return View();
                    }

                }
                else
                {
                    ModelState.AddModelError("", "Tài khoản và mật khẩu không chính xác !");
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("", "Tài khoản và mật khẩu không được bỏ trống !");
                return View();
            }


        }
    }
} 
    