using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication21webapi.DTO;
using WebApplication21webapi.Models;

namespace WebApplication21webapi.Controllers
{
    public class HomeController : ApiController
    {
        private EmpContext db;
        public HomeController()
        {
            db = new EmpContext();
        }
        public IEnumerable<EmpDto> GetMembers()
        {
            return db.Emps.ToList().Select(Mapper.Map<Emp, EmpDto>);
        }
        public EmpDto GetMember(int id)
        {
            var emp = db.Emps.SingleOrDefault(c => c.Id == id);
            if (emp == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return Mapper.Map<Emp, EmpDto>(emp);

        }
        [HttpPost]
        //  public MemberDto CreateMember(MemberDto memberDto)
        public IHttpActionResult CreateMember(EmpDto empdto)
        {
            if (!ModelState.IsValid)
                // throw new HttpResponseException(HttpStatusCode.BadRequest);
                return BadRequest();
            var emp = Mapper.Map<EmpDto, Emp>(empdto);
            db.Emps.Add(emp);
            db.SaveChanges();
            empdto.Id = emp.Id;
            return Created(new Uri(Request.RequestUri + "/" + emp.Id), empdto);
            //      return memberDto();
        }
        [HttpPut]
        public void UpdateMember(int id, EmpDto empdto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var empinDb = db.Emps.SingleOrDefault(c => c.Id == id);
            if (empinDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(empdto, empinDb);
      
            db.SaveChanges();


        }
        [HttpDelete]
        public void DeleteMember(int id)
        {
            var empInDb = db.Emps.SingleOrDefault(c => c.Id == id);
            if (empInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            db.Emps.Remove(empInDb);
            db.SaveChanges();
        }
    }
}

