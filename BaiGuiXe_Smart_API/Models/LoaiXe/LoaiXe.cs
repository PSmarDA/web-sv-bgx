using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaiGuiXe_Smart_API.Models.LoaiXe
{
    public class LoaiXe
    {
        [BsonId]
        public ObjectId Id
        {
            get;
            set;
        }

        [Required]
        [BsonElement("TenLoai")]
        public string TenLoai
        {
            get;
            set;
        }

        [Required]
        [BsonElement("GiaTien")]
        public int GiaTien
        {
            get;
            set;
        }
    }
}