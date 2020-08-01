using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;

namespace WebApplication1.Models
{
    public class MyContext : DbContext
    {
        public MyContext (DbContextOptions<MyContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }

		public DbSet<Product> Product { get; set; }

	}
}
