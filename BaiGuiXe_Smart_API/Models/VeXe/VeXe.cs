using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaiGuiXe_Smart_API.Models.VeXe
{
    public class VeXe
    {
        [BsonId]
        public ObjectId Id
        {
            get;
            set;
        }

        [Required]
        [BsonElement("SoVe")]
        public string SoVe
        {
            get;
            set;
        }

        [Required]
        [BsonElement("IdBaiXe")]
        public ObjectId IdBaiXe
        {
            get;
            set;
        }
    }
}