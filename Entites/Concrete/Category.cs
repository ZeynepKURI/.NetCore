using System;
using Entites.Abstract;

namespace Entites.Concrete
{

	//Çıplak class kalmasın
	public class Category:IEntity
	{
		public int CategoryId { get; set; }

		public string CategoryName { get; set; }
	}
}

