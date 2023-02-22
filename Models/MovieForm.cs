using System;
using System.ComponentModel.DataAnnotations;

namespace Mission06_jazz3987.Models
{
	public class MovieForm
	{
		[Key]
		[Required]
		public int MovieId { get; set; }

		[Required(ErrorMessage = "Title cannot be blank.")]
		public string Title { get; set; }

		[Required(ErrorMessage = "Year cannot be blank.")]
		public int Year { get; set; }

		[Required(ErrorMessage = "Enter a director.")]
		public string Director { get; set; }

		[Required(ErrorMessage = "Enter a rating.")]
		public string Rating { get; set; }

		public string Edited { get; set; }

		public string LentTo { get; set; }

		public string Notes { get; set; }

		// Build Foreign Key Relationship
        [Required(ErrorMessage = "Select a category.")]
        public int CategoryID { get; set; }
		public Category Category { get; set; }
    }
}

