using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public interface IEntityRepository<T>where T:class, IEntity, new ()
    {
        List<T> GetAll(Expression<Func<T, bool>>filter=null);
        List<T> GetByID(Expression<Func<T, bool>> filter);
        //T GetById(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
