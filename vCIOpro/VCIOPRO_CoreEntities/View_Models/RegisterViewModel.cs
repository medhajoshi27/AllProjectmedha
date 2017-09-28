using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCIOPRO_CoreEntities.View_Models
{
    public class LoginViewModel
    {
        //[Required]
        //[Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        //[Required]
        //[DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        //[Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
        public int UserId { get; set; }
        public string SubDomain { get; set; }
    }



    public class ApiRegisterViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string CompanyName { get; set; }
        public string SubDomain { get; set; }
        public int PlanId { get;set ; }
        public string BillingEmail { get; set; }
        public long Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string CardNumber { get; set; }
        public string SecurityCode { get; set; }
        public string PromoCode { get; set; }
        public string ReferalCode { get; set; }
        public System.DateTime ExpiryDate { get; set; }
    }
}
