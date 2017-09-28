using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using VCIOPRO_Web.Models;
using VCIOPRO_Web.Providers;
using VCIOPRO_Web.Results;
using VCIOPRO_Repository.Repositories;
using VCIOPRO_Service.Interfaces;
using static VCIOPRO_Web.ApplicationUserManager;
using VCIOPRO_CoreEntities.View_Models;
using VCIOPRO_Repository;
using System.Web.Http.Cors;

namespace VCIOPRO_Web.Controllers
{
    [RoutePrefix("api/Account")]
    [EnableCors(origins: "*", headers: "*", methods: "GET PUT POST DELETE")]
    public class AccountController : ApiController
    {
        private const string LocalLoginProvider = "Local";
      
        private ApplicationUserManager _userManager;

        private medhajoshiEntities1 _ctx = new medhajoshiEntities1();
        private IRegistration _tenantDataManager;
        public IEnumerable<tblTenant> Get()
        {
            medhajoshiEntities1 db = new medhajoshiEntities1();
            return db.tblTenants;
        }
        public AccountController(IRegistration tntMgr)
        {
            _tenantDataManager = tntMgr;

        }

        public AccountController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
            

        }


      
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public ISecureDataFormat<AuthenticationTicket> AccessTokenFormat { get; private set; }

        [AllowAnonymous]
        [Route("Register")]
        public async Task<IHttpActionResult> Register(ApiRegisterViewModel model)
        {
            ResponseViewModel ResponseObj = new ResponseViewModel();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = new ApplicationUser() { UserName = model.EmailId, Email = model.EmailId };

            IdentityResult result = await UserManager.CreateAsync(user, model.Password);
            try
            {
                if (result.Succeeded == true)
                {

                    bool userAdded = _tenantDataManager.AddUser(model);
                }
            }

            catch (Exception EX)
            {
                throw EX;
            }

            return Ok();


        }



        protected override void Dispose(bool disposing)
        {
            if (disposing && _userManager != null)
            {
                _userManager.Dispose();
                _userManager = null;
            }

            base.Dispose(disposing);
        }

        #region Helpers

        private IAuthenticationManager Authentication
        {
            get { return Request.GetOwinContext().Authentication; }
        }

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                {
                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }

        private class ExternalLoginData
        {
            public string LoginProvider { get; set; }
            public string ProviderKey { get; set; }
            public string UserName { get; set; }

            #endregion
        }
    }
}
