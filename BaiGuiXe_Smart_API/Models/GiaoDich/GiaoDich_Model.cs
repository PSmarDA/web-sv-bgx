using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiGuiXe_Smart_API.Models.GiaoDich
{
    public class GiaoDich_Model
    {
        Connect_MongoDB<GiaoDich> db;
        public GiaoDich_Model()
        {
            db = new Connect_MongoDB<GiaoDich>("GiaoDich");
        }

        public List<GiaoDich> FindAll()
        {
            return db.mongocollection.AsQueryable().ToList();
        }


    }
}