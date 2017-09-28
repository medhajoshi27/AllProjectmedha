using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCIOPRO_Repository.Interfaces;

namespace VCIOPRO_Repository.Repositories
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private medhajoshiEntities1 _context;

        public UnitOfWork(medhajoshiEntities1 context)
        {
            _context = context;
        }

        public IGenericRepository<T> GetRepositoryInstance<T>() where T : class, new()
        {
            return new GenericRepository<T>(_context);
        }
        public DbRawSqlQuery<T> SQLQuery<T>(string sql, params object[] parameters)
        {
            return _context.Database.SqlQuery<T>(sql, parameters);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
