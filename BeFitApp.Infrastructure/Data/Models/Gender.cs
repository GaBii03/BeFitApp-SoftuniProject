using System;
using System.ComponentModel.DataAnnotations;

namespace BeFitApp.Infrastructure.Data.Models
{
    /// <summary>
    /// this is enum for different genders
    /// </summary>
	public enum Gender
	{
        [Display(Name = "Female")]
        Female = 1,
        [Display(Name = "Male")]
        Male = 2,
    }
}

