using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCIOPRO_CoreEntities.View_Models;
using VCIOPRO_Service.Services;

namespace VCIOPRO_Service.Interfaces
{
    public interface IRegistration
    {
        bool AddUser(ApiRegisterViewModel model);


    }
}
