
using System.Collections.Generic;
using CF.Data;
using System.Linq;

namespace CF.service.commun
{
    public  interface IEntityService<T> : IService  where T : BaseEntity
     
    {  
        void Create(T entity);
        void Delete(T entity);
        /*  IEnumerable<T> GetAll(); */
        IQueryable<T> GetAll();
        void Update(T entity);
   
    }
}
