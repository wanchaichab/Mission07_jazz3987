using System;
using System.ComponentModel.DataAnnotations;

namespace Mission06_jazz3987.Models
{
	public class Category
	{
		[Key]
		[Required]
		public int CategoryID { get; set; }
		public string CategoryName { get; set; }
	}
}

