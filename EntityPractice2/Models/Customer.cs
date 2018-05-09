using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityPractice2.Models
{
	public class Customer
	{
		public virtual string FirstName { get; set; }
		public virtual string LastName { get; set; }
		public virtual int CustomerId { get; set; }
		public virtual int StoreId { get; set; }
	}
}