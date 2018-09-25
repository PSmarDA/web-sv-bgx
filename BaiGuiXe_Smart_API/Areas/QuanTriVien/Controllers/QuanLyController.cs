using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiGuiXe_Smart_API.Models.BaiXe;
using BaiGuiXe_Smart_API.Models.LoaiXe;
using MongoDB.Bson;

namespace BaiGuiXe_Smart_API.Areas.QuanTriVien.Controllers
{
    public class QuanLyController : BaseController
    {
       
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
                BaiXe_Model baixe_model = new BaiXe_Model();
                var bxlist = baixe_model.FindChuSoHuu(session.Id);
                return View(bxlist);
            }
            else
            {
                return View();
            }
        }
        public ActionResult QLLoaiXe()
        {
            var session = (BaiGuiXe_Smart_API.Models.UserSession.UserSession)Session["loginsession"];
            LoaiXe_Model lx_model = new LoaiXe_Model();
            var lxlist = lx_model.FindChuSoHuu(session.Id);
            return View(lxlist);
        }
        
        public int Themloaixe(string tenloai, string gia,ObjectId csh)
        {
          if(tenloai != "" || gia != "" || csh != null)
            {
                LoaiXe_Model lx_model = new LoaiXe_Model();
                LoaiXe lx = new LoaiXe();
                lx.ChuSoHuu = csh;
                try
                {
                    lx.GiaTien = Convert.ToInt32(gia);
                }
                catch
                {
                    return -2; // nếu người dùng nhập giá không phải là số;
                }
                lx.TenLoai = tenloai;
                try
                {
                    lx_model.Create(lx);
                    return 1; // thêm loại xe thành công
                }
                catch
                {
                    return 0; // thêm thất bại
                }
                

            }
          else
            {
                return -1; // giá trị truyền vào bị rỗng

            }
        }

    }
}