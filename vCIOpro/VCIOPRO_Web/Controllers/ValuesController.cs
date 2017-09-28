using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using VCIOPRO_CoreEntities.Domain;
using VCIOPRO_Repository;
using VCIOPRO_Repository.Repositories;

namespace VCIOPRO_Web.Controllers
{
  
    [EnableCors(origins: "*", headers: "*", methods: "GET PUT POST DELETE")]
    public class ValuesController : ApiController
    {

        public medhajoshiEntities1 db = new medhajoshiEntities1();

        // GET api/values
        //    [Authorize]
        [Route("api/values")]
        public IEnumerable<tblTenant> Get()
        {
            medhajoshiEntities1 db = new medhajoshiEntities1();
            return db.tblTenants;
        }
     //   [Authorize]
        /*public IEnumerable<tblBillingInfo> Get1()
        {
            medhajoshiEntities1 db = new medhajoshiEntities1();
            return db.tblBillingInfoes;
        }
     //   [Authorize]
        public IEnumerable<tblCreditInfo> Get2()
        {
            medhajoshiEntities1 db = new medhajoshiEntities1();
            return db.tblCreditInfoes;
        }*/
        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            return Ok(db.tblStates);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
