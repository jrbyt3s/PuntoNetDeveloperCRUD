using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCursos.Data.Repositories
{
    //Generico: Tipo <TEntity>
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();

        Task<TEntity> Get( int? id );

        Task Add(TEntity entity);

        void Remove(TEntity entity);
    }
}
