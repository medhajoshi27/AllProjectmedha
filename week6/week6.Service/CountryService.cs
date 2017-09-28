using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week6.Model;

namespace week6.Service
{
    public class CountryService : EntityService<Country>, ICountryService
    {
        new IContext _context;

        public CountryService(IContext context)
            : base(context)
        {
            _context = context;
            _dbset = _context.Set<Country>();
        }

        public Country GetById(int Id)
        {
            return _dbset.FirstOrDefault(x => x.Id == Id);
        }
    }
}
