using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiGuiXe_Smart_API.Models.UserSession
{
    [Serializable]
    public class UserSession
    {
        public ObjectId Id { set; get; }
        public string Ten { set; get; }
        public string Email { set; get; }
        public bool XacThucEmail { set; get; }
        public int LoaiTaiKhoan { set; get; }
    }
}