using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeFitApp.Infrastructure.Data.Models
{
	/// <summary>
	/// a class for an exercise a ProUser does
	/// </summary>
	public class Exercise
	{
		/// <summary>
		/// id of the exercise
		/// </summary>
		[Key]
		public int Id { get; set; }

		/// <summary>
		/// the name of the exercise
		/// </summary>
		[Required]
		[StringLength(100)]
		public string Name { get; set; } = null!;

		/// <summary>
		/// the calories that were burned during the exercise
		/// </summary>
		[Required]
		public int CaloriesBurned { get; set; }

		/// <summary>
		/// the id of the day this exercise was done
		/// </summary>
		[Required]
		public int DayId { get; set; }

		/// <summary>
		/// the day this exercise was done
		/// </summary>
		[ForeignKey(nameof(DayId))]
		public Day Day { get; set; } = null!;

        /// <summary>
        /// a boolean that helps to "delete" an exercise
        /// </summary>
        public bool IsDeleted { get; set; } = false;
	}
}

