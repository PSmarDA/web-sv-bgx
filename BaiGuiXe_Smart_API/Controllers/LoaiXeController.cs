using BaiGuiXe_Smart_API.Models.LoaiXe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiGuiXe_Smart_API.Controllers
{
    public class LoaiXeController : Controller
    {
        LoaiXe_Model loaixemol = new LoaiXe_Model();

        // GET: LoaiXe
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult IndexHome()
        {
          ViewBag.xe =  loaixemol.FindTenLoai("xe"); 
          var x=  loaixemol.FindAll();
            return View(x);
        }
        
       
        // lam don gian thoi ba , tesst chi ghe vay

        //public ActionResult AddLoaiXe()
        //{

        //}
    }
}