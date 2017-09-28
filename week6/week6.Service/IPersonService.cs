using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week6.Model;

namespace week6.Service
{
    public interface IPersonService : IEntityService<Person>
    {
        Person GetById(long Id);
    }
}
