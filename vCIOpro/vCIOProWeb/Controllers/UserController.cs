using AutoMapper;
using CoreEntities.Model;
using Repository_Layer.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace vCIOProWeb.Controllers
{
    public class UserController : ApiController
    {
        private UserDBContext db;
        public UserController()
        {
            db = new UserDBContext();
        }


        public UserM GetMember(int id)
        {
            var user = db.Members.SingleOrDefault(c => c.Id == id);
            if (user == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return user;

        }

        #region--Create Member--
        [HttpPost]
        //  public MemberDto CreateMember(MemberDto memberDto)
        public IHttpActionResult CreateMember(UserM User)
        {
            if (!ModelState.IsValid)
                // throw new HttpResponseException(HttpStatusCode.BadRequest);
                return BadRequest();
            db.Members.Add(User);
            db.SaveChanges();
            return Created(new Uri(Request.RequestUri + "/" + User.Id), User);
            
        }

        #endregion

        #region--HttpPut---
        [HttpPut]
        public void UpdateMember(int id, UserM user)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var memberInDb = db.Members.SingleOrDefault(c => c.Id == id);
            if (memberInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(user, memberInDb);
            memberInDb.Name = user.Name;
            memberInDb.Email = user.Email;
            memberInDb.Address = user.Address;
            db.SaveChanges();


        }
        #endregion
    }
}
