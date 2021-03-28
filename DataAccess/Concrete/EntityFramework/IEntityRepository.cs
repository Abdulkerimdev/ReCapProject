using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public interface IEntityRepository<T>where T:class, IEntity, new ()
    {
        List<T> GetAll();

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
