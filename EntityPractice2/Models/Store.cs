using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityPractice2.Models
{
	public class Store
	{
		public virtual string Department { get; set; }
		public virtual int StoreId { get; set; }
	}
}