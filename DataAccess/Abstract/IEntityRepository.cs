using System;
using System.Linq.Expressions;
using Entites.Concrete;

namespace Business.Abstract
{
	public interface IEntityRepository<T>
	{
        //Filtreleme(ayrı ayrı metot yazmaya gerek yok.
        List<T> GetAll(Expression<Func<T, bool>> filter =null);

        //Tek bir data getirmek.
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    
    }
}

