﻿using System;
using Entites.Abstract;

namespace Entites.Concrete
{
	
		public class Customer:IEntity
		{

		public  string CustomerId{ get; set; }

        public string CustomerName { get; set; }

        public string CompanyName{ get; set; }

        public string City { get; set; }

    }
	
}

