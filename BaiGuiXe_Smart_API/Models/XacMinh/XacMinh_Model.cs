using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BaiGuiXe_Smart_API.Models.XacMinh
{
    public class XacMinh_Model
    {
       Connect_MongoDB<XacMinh> db;
        public XacMinh_Model()
        {
            db = new Connect_MongoDB<XacMinh>("XacMinh");
        }
        public List<XacMinh> FindAll()
        {
          
            return db.mongocollection.AsQueryable().ToList();
        }
        public XacMinh Find(string code)
        {
            
            var results = db.mongocollection.Find(x => x.Code == code).FirstOrDefault();
            return results;
        }

        public XacMinh timkiemtheoID_User(ObjectId id)
        {
            var results = db.mongocollection.Find(x => x.Id_User == id).FirstOrDefault();
            return results;
        
        }
        public int Create(XacMinh xm)
        {
           var x = Find(xm.Code); // tìm kiếm mã xác minh có tồn tại không 
           if(x!=null)
           {
               
                    return 0; // nếu đã tồn tại
                
           }
           else
            {
                // tạo mã xác minh mới
                var xm_results = timkiemtheoID_User(xm.Id_User);
                if(xm_results != null && sosanhngay(xm_results.Timer,DateTime.Now) < 3)
                {
                    return 0;
                }
                else
                {
                    db.mongocollection.InsertOne(xm);
                    return 1;
                }


            }
           
        }
        public int sosanhngay(DateTime d1, DateTime d2)
        {
            DateTime ngay1 = Convert.ToDateTime(String.Format("{0:dd/MM/yyyy}", d1.ToString()));
            DateTime ngay2 = Convert.ToDateTime(String.Format("{0:dd/MM/yyyy}", d2.ToString()));
            TimeSpan Time = ngay2 - ngay1;
            int TongSoNgay = Time.Days;
            return TongSoNgay;

        }

        public void Delete(string code)
        {
            db.mongocollection.DeleteOne(
                Builders<XacMinh>.Filter.Eq("Code", code)
                );
        }
        private static Random random = new Random();
        public string RandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqestuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, 9)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}