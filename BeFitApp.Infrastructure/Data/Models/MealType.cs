using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BeFitApp.Infrastructure.Data.Models
{
    /// <summary>
    /// enum with the posible types of meals
    /// </summary>
	public enum MealType
	{
        [Display(Name = "Breakfast Meal")]
        Breakfast = 1,
        [Display(Name = "Lunch Meal")]
        Lunch = 2,
        [Display(Name = "Dinner Meal")]
        Dinner = 3,
        [Display(Name = "Snack Meal")]
        Snack = 4
	}
}

