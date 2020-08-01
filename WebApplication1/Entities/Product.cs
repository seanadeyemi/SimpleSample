using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
	public class Product
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public int Quantity { get; set; }
		public int Size { get; set; }

		public decimal Cost { get; set; }

		public DateTime Expiry { get; set; }

	}
}
