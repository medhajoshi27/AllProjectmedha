using System;
using VCIOPRO_CoreEntities.Domain;
using VCIOPRO_CoreEntities.View_Models;
using VCIOPRO_Repository;
using VCIOPRO_Repository.Repositories;
using VCIOPRO_Service.Interfaces;

namespace VCIOPRO_Service.Services
{
    public class Registration : IRegistration
    {
        private UnitOfWork unitOfWork { get; set; }

        public Registration(UnitOfWork _UnitOfWork)
        {
            unitOfWork = _UnitOfWork;
        }

        public bool AddUser(ApiRegisterViewModel model)
        {
            medhajoshiEntities1 context = new medhajoshiEntities1();
            bool flag = false;

            using (var dbContextTransaction = context.Database.BeginTransaction())
            {
                try
                {
                    Guid UniqueTenantId = System.Guid.NewGuid();
                    tblTenant TntDtl = new tblTenant()
                    {
                    //    TId=model.TId,
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        EmailId = model.EmailId,
                        Password = model.Password,
                        ConfirmPassword=model.ConfirmPassword,
                        CompanyName=model.CompanyName,
                        SubDomain=model.SubDomain,
                        PlanId = model.PlanId
                    };
   unitOfWork.GetRepositoryInstance<tblTenant>().Insert(TntDtl);
                    unitOfWork.Save();

                    tblBillingInfo TntDt2 = new tblBillingInfo()
                    {
                       // BillingId=model.BillingId,
                        BillingEmail = model.BillingEmail,
                        Phone = model.Phone,
                        Address1 = model.Address1,
                        Address2 = model.Address2,
                        CountryId = model.CountryId,
                        StateId = model.StateId,
                        City = model.City,
                        ZipCode = model.ZipCode
                    };
                    unitOfWork.GetRepositoryInstance<tblBillingInfo>().Insert(TntDt2);
                    unitOfWork.Save();

                     tblCreditInfo TntDt3 = new tblCreditInfo()
                    {
                       // CreditId=model.CreditId,
                        CardNumber = model.CardNumber,
                        SecurityCode = model.SecurityCode,
                        PromoCode = model.PromoCode,
                        ReferalCode = model.ReferalCode,
                        ExpiryDate = model.ExpiryDate
                    };
                    unitOfWork.GetRepositoryInstance<tblCreditInfo>().Insert(TntDt3);
                    unitOfWork.Save();
                    dbContextTransaction.Commit();
                    flag = true;
                }

                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    throw ex;
                }
            }
            return true;
        }



    }
}
