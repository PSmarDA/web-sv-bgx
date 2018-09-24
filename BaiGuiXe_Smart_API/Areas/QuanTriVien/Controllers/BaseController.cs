using BaiGuiXe_Smart_API.Models.UserSession;
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
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = (UserSession)Session["loginsession"];

            if (session == null || session.LoaiTaiKhoan != 1)
            {
                filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(new { Controller = "Login", Action = "Index" }));
            }

            base.OnActionExecuting(filterContext);
        }
    }
}