using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeFitApp.Infrastructure.Data.Models
{
	/// <summary>
	/// a class for a day with exercises and meals of a ProUser
	/// </summary>
	public class Day
	{
		/// <summary>
		/// constructor that initialise lists with meals and exercises
		/// </summary>
		public Day()
		{
			Exercises = new List<Exercise>();
			Meals = new List<Meal>();
		}

		/// <summary>
		/// id of the day
		/// </summary>
		[Key]
		public int Id { get; set; }

		/// <summary>
		/// the date of the day
		/// </summary>
		[Required]
		public DateTime Date { get; set; }

		/// <summary>
		/// the list of all exercises that were done through the day
		/// </summary>
		public List<Exercise> Exercises { get; set; } = null!;

        /// <summary>
        /// the list of all mealss that were eaten through the day
        /// </summary>
        public List<Meal> Meals { get; set; } = null!;

		/// <summary>
		/// the id of the ProUser to which the day refers
		/// </summary>
		[Required]
		public int ProUserId { get; set; }

        /// <summary>
        /// the ProUser to which the day refers
        /// </summary>
        [ForeignKey(nameof(ProUserId))]
		public ProUser ProUser { get; set; } = null!;
	}
}

