
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)

        {

            ProductManager programManager = new ProductManager(new EfProductDal());
            foreach (var product in programManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

  
        }
    }
}




