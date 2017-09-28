using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vCIOPRO_Service.Interfaces;

namespace vCIOPRO_Service.Services
{
    public class Registration : IRegistration
    {
        private UnitOfWork unitOfWork { get; set; }

        public Registration(UnitOfWork _UnitOfWork)
        {
            unitOfWork = _UnitOfWork;
        }

        public bool AddUser(APiRegisterViewModel model)
        {
            vcEntities context = new vcEntities();
            bool flag = false;

            using (var dbContextTransaction = context.Database.BeginTransaction())
            {
                try
                {
                    Guid UniqueTenantId = System.Guid.NewGuid();
                    SignUP TntDtl = new SignUP()
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        EmailId = model.EmailId,
                        Password = model.Password

                    };

                    unitOfWork.GetRepositoryInstance<SignUP>().Insert(TntDtl);

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
