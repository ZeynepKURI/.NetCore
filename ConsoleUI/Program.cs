
using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)

        {

            ProductManager programManager = new ProductManager(new InMemoryProductDal());
            foreach (var product in programManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

  
        }
    }
}




