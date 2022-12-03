using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeFitApp.Infrastructure.Data.Models
{
    /// <summary>
	/// a class for a meal a ProUser eats
	/// </summary>
	public class Meal
	{
        /// <summary>
        /// the id of the meal
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// the type of the meal (breakfast/lunch/dinner/snack)
        /// </summary>
        [Required]
        public MealType MealType { get; set; }

        /// <summary>
        /// the name of the meal
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// optional details for the meal - posibility to specify ingredents and calories
        /// </summary>
        public string Details { get; set; } = null!;

        /// <summary>
        /// all consumed calories of the meal
        /// </summary>
        [Required]
        public int Calories { get; set; }

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
        /// a boolean that helps to "delete" a meal
        /// </summary>
        public bool IsDeleted { get; set; } = false;
    }
}

