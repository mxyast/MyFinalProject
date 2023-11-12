using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //generic constrain IEntityRepository<T>
    //where T : class ==>Class referans tip demek
    //IEntity : IEntity olabilir yada implemente ettiği bir nesne olabilir
    //new() :newlenebilir olmalı
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Update(T entity);
        void Add(T entity);
        void Delete(T entity);

    }
}
