using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
	public class Customer
	{
		[Key]
		public int Id { get; set; }
		[MaxLength(100)]
		public string FirstName { get; set; }

		[MaxLength(100)]
		[MinLength(2)]
		public string LastName { get; set; }
		public string Address { get; set; }
		[Phone]
		public string PhoneNumber { get; set; }
		[EmailAddress]
		public string Email { get; set; }


	}
}
