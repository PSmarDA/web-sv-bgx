using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BaiGuiXe_Smart_API.Models.BaiXe
{
    public class BaiXe_Model
    {
        Connect_MongoDB<BaiXe> db;
        public BaiXe_Model()
        {
            db = new Connect_MongoDB<BaiXe>("BaiXe");
        }

        public List<BaiXe> FindAll()
        {
            return db.mongocollection.AsQueryable().ToList();
        }


        public void Create(BaiXe bx)
        {
            db.mongocollection.InsertOne(bx);
        }

        //Update collection
        public void Update(BaiXe bx)
        {
            db.mongocollection.UpdateOne(
                Builders<BaiXe>.Filter.Eq("_id", bx.id),
                Builders<BaiXe>.Update
                .Set("DiaChi", bx.DiaChi)
                .Set("SucChua", bx.SucChua)
                .Set("ChuSoHuu", bx.ChuSoHuu)
                );
        }

        //Xoa
        public void Delete(ObjectId id)
        {
            db.mongocollection.DeleteOne(
                Builders<BaiXe>.Filter.Eq("id", id)
                );
        }
    }
}
