﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Mission06_jazz3987.Models
{
	public class MovieForm
	{
		[Key]
		[Required]
		public int MovieId { get; set; }

		[Required]
		public string Title { get; set; }

		[Required]
		public int Year { get; set; }

		[Required]
		public string Director { get; set; }

		[Required]
		public string Rating { get; set; }

		public string Edited { get; set; }

		public string LentTo { get; set; }

		public string Notes { get; set; }

		// Build Foreign Key Relationship
        [Required]
        public int CategoryID { get; set; }
		public Category Category { get; set; }
    }
}

