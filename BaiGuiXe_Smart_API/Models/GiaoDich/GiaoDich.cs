using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaiGuiXe_Smart_API.Models.GiaoDich
{
    public class GiaoDich
    {
        [BsonId]
        public ObjectId id
        {
            get;
            set;
        }

    }
}