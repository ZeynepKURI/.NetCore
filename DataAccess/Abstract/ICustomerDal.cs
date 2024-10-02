using System;
using Business.Abstract;
using Entites.Concrete;

namespace DataAccess.Abstract
{
	public interface ICustomerDal:IEntityRepository<Customer>
	{
	}
}

