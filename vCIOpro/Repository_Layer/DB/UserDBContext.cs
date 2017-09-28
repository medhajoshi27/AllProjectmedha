using CoreEntities.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Layer.DB
{
  public class UserDBContext :DbContext
    {
        public UserDBContext() : base("name=MyConnectionString")
        {

        }
        public DbSet<UserM> Members { get; set; }
    }
}

