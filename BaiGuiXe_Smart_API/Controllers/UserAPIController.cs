using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BaiGuiXe_Smart_API.Models;

namespace BaiGuiXe_Smart_API.Controllers
{
    //[Route("api/User")]
    public class UserAPIController : ApiController
    {
        public UserModel db;
        public UserAPIController()
        {
            db = new UserModel();
        }

        [HttpGet]
        public User Get(string email)
        {
            var use = db.Find(email);
            return use;
        }

      [HttpGet]
        public IHttpActionResult Getemail([FromBody] string email)
        {
            var users = db.Find(email);
            //if (users == null)
            //{
            //    return NotFound();
            //}
            return Ok(new { results = users });
        }



    }
}
