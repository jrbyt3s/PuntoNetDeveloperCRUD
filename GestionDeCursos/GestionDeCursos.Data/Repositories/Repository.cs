using GestionDeCursos.Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCursos.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationDbContext Context; // This is a Property of the class

        public Repository(ApplicationDbContext contextParam)
        {
            Context = contextParam;
        }

        public Task Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Get(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
