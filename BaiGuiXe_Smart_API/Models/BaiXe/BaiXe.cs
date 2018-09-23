using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BaiGuiXe_Smart_API.Models.BaiXe
{
    public class BaiXe
    {
        [BsonId]
        public ObjectId id
        {
            get;
            set;
        }

        [Required]
        [BsonElement("DiaChi")]
        public string DiaChi
        {
            get;
            set;
        }

        [Required]
        [BsonElement("SucChua")]
        public int SucChua
        {
            get;
            set;
        }

        [Required]
        [BsonElement("ChuSoHuu")]
        public ObjectId ChuSoHuu
        {
            get;
            set;
        }
    }
}
