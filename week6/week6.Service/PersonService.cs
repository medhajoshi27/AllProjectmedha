using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week6.Model;

namespace week6.Service
{
    public class PersonService : EntityService<Person>, IPersonService
    {
        new IContext _context;
        public PersonService(IContext context)
            : base(context)
        {
            _context = context;
            _dbset = _context.Set<Person>();
        }

        public override IEnumerable<Person> GetAll()
        {
            return _context.Persons.Include(x => x.Country).ToList();
        }

        public Person GetById(long Id)
        {
            return _dbset.FirstOrDefault(x => x.Id == Id);
        }

    }
}
