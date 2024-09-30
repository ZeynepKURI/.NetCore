using System;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entites.Concrete;

namespace Business.Concrete
{
	public class ProductManager : IProductService
    {
		IProductDal _ProductDal;
		
		public ProductManager(IProductDal productDal)
		{
			_ProductDal = productDal;
		}


		public List<Product> GetAll()
		{
			return _ProductDal.GetAll();
		}

        List<Product> IProductService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

