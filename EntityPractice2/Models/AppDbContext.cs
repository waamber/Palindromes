using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityPractice2.Models
{
	public class AppDbContext : DbContext
	{
		public AppDbContext() : base("EntityPractice2"){}

		public virtual DbSet<Customer> Customers { get; set; }
		public virtual DbSet<Store> Stores { get; set; }

	}
}