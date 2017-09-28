using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace assignment1.Models
{
        public class WorkerContext : DbContext
        {
            public WorkerContext() : base("name=dbWorkerEntries")
            {

            }
            public DbSet<Worker> Workers { get; set; }
            public DbSet<State> States { get; set; }
            public DbSet<Country> Countries { get; set; }
        }
}