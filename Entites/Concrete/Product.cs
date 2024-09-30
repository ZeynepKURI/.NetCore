using System;
namespace Entites.Concrete
{

	//public diğer katmanların ulaşmasını sağlar.
	//internal default yapar.


	public class Product
	{
		public int ProductId { get; set; }

		public int CategoyId { get; set; }

		public string ProductName { get; set; }

		public short UnitsInStock { get; set; }

		public decimal UnitPrice { get; set; }

	}
}

