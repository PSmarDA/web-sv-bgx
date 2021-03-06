﻿using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiGuiXe_Smart_API.Models.LoaiXe
{
    public class LoaiXe_Model
    {
        Connect_MongoDB<LoaiXe> db;
        public LoaiXe_Model()
        {
            db = new Connect_MongoDB<LoaiXe>("LoaiXe");
        }


        //Tim kiem tat ca trong collection
        public List<LoaiXe> FindAll()
        {
            return db.mongocollection.AsQueryable().ToList();
        }

        public List<LoaiXe> FindChuSoHuu(ObjectId csh)
        {
            return db.mongocollection.Find(x => x.ChuSoHuu == csh).ToList();
        }


        public LoaiXe FindId(ObjectId id)
        {

            var results = db.mongocollection.Find(x => x.Id == id).FirstOrDefault();
            return results;

        }
        /*
         * xemay , Xe may , XE MAY
         * xe may
         * */
         
        public List<LoaiXe> FindTenLoai(string tenloai)
        {
            //var b = db.mongocollection.Indexes.CreateOne(Builders<LoaiXe>.IndexKeys.Text(x => x.TenLoai));
            var filter = Builders<LoaiXe>.Filter.Text(tenloai);
            var result = db.mongocollection.FindSync(filter); 
            db.mongocollection.FindSync(filter); 
            //var listten = db.mongocollection.Find(Builders<LoaiXe>.Filter.Text(tenloai)).ToList();
            
            return result.ToList();
        }

        public LoaiXe FindGiaTien(int giatien)
        {
            var results = db.mongocollection.Find(x => x.GiaTien == giatien).FirstOrDefault();
            return results;
        }

        //Them loai xe
        public void Create(LoaiXe xe)
        {
            db.mongocollection.InsertOne(xe);
        }

        //Update collection
        public void Update(LoaiXe xe)
        {
            db.mongocollection.UpdateOne(
                Builders<LoaiXe>.Filter.Eq("_id", xe.Id),
                Builders<LoaiXe>.Update
                .Set("TenLoai", xe.TenLoai)
                .Set("GiaTien", xe.GiaTien)
                .Set("ChuSoHuu", xe.ChuSoHuu)
                );
        }

        //Xoa
        public void Delete(ObjectId id)
        {
            db.mongocollection.DeleteOne(
                Builders<LoaiXe>.Filter.Eq("_id", id)
                );
        }

    }
}