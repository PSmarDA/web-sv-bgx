using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiGuiXe_Smart_API.Models.VeXe
{
    public class VeXe_Model
    {
        Connect_MongoDB<VeXe> db;
        public VeXe_Model()
        {
            db = new Connect_MongoDB<VeXe>("VeXe");
        }

        public List<VeXe> FindAll()
        {
            return db.mongocollection.AsQueryable().ToList();
        }

        public List<VeXe> FindChuSoHuu(ObjectId csh)
        {
            return db.mongocollection.Find(x => x.IdBaiXe == csh).ToList();
        }


        public void Create(VeXe vx)
        {
            db.mongocollection.InsertOne(vx);
        }

        //Update collection
        public void Update(VeXe vx)
        {
            db.mongocollection.UpdateOne(
                Builders<VeXe>.Filter.Eq("_id", vx.Id),
                Builders<VeXe>.Update
                .Set("SoVe", vx.SoVe)
                .Set("IdBaiXe", vx.IdBaiXe)
                );
        }

        //Xoa
        public void Delete(ObjectId id)
        {
            db.mongocollection.DeleteOne(
                Builders<VeXe>.Filter.Eq("id", id)
                );
        }

    }
}