using CF.Data;
using CF.Repo.commun;
using System;
using System.Linq;
namespace CF.service.commun
{

    public   class EntityService<T> : IEntityService<T> where T : BaseEntity
 
    {

       
        IRepository<T> _repository;

        public EntityService(IRepository<T> repository)
        {
       
            _repository = repository;
        }


        public virtual void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _repository.Insert(entity);
           
        }


        public virtual void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _repository.Update(entity);
           /* _unitOfWork.Commit(); */
        }

        public virtual void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _repository.Delete(entity);
           /* _unitOfWork.Commit(); */
        }

        public virtual IQueryable<T> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
    
