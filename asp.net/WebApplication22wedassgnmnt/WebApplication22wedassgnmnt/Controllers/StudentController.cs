using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication22wedassgnmnt.DTO;
using WebApplication22wedassgnmnt.Models;

namespace WebApplication22wedassgnmnt.Controllers
{
    public class StudentController : ApiController
    {
        private StudContext db;
        public StudentController()
        {
            db = new StudContext();
        }

        public IEnumerable<StudentDto> GetMembers()
        {
            return db.studvm.ToList().Select(Mapper.Map<StudentVM, StudentDto>);


        }
        public StudentDto GetMember(int id)
        {
            var std = db.studvm.SingleOrDefault(c => c.StudId == id);
            if (std == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return Mapper.Map<StudentVM, StudentDto>(std);

        }
        [System.Web.Http.HttpPost]
        //  public MemberDto CreateMember(MemberDto memberDto)
        public IHttpActionResult CreateMember(StudentDto stdDto)
        {
            if (!ModelState.IsValid)
                // throw new HttpResponseException(HttpStatusCode.BadRequest);
                return BadRequest();
            var std = Mapper.Map<StudentDto, StudentVM>(stdDto);
            db.studvm.Add(std);
            db.SaveChanges();
            stdDto.StudId = std.StudId;
            return Created(new Uri(Request.RequestUri + "/" + std.StudId), stdDto);
            //      return memberDto();
        }
        [System.Web.Http.HttpPut]
        public void UpdateMember(int id, StudentDto memberDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var stdInDb = db.Students1.SingleOrDefault(c => c.StudId == id);
            if (stdInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(memberDto, stdInDb);
            //memberInDb.MemName = member.MemName;
            //memberInDb.MemEmail = member.MemEmail;
            //memberInDb.MemAddress = member.MemAddress;
            db.SaveChanges();


        }
        [System.Web.Http.HttpDelete]
        public void DeleteMember(int id)
        {
            var stdInDb = db.studvm.SingleOrDefault(c => c.StudId == id);
            if (stdInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            db.studvm.Remove(stdInDb);
            db.SaveChanges();
        }

    }
}
