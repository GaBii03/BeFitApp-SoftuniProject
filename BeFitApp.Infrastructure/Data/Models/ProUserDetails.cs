using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace BeFitApp.Infrastructure.Data.Models
{
    /// <summary>
    /// This class is for the additional information about a ProUser user
    /// </summary>
	public class ProUserDetails
	{
        /// <summary>
        /// the id of the Details about ProUser user
        /// </summary>
        [Key]
		public int Id { get; set; }

        /// <summary>
        /// weight of the user in kilograms
        /// </summary>
        [Required]
        public int Weight { get; set; }

        /// <summary>
        /// height of the user in santimeters
        /// </summary>
        [Required]
        public int Height { get; set; }

        /// <summary>
        /// user age in years
        /// </summary>
        [Required]
        public int Age { get; set; }

        /// <summary>
        /// gender of the user (male/female)
        /// </summary>
        [Required]
        public Gender Gender { get; set; }

        /// <summary>
        /// activity level of the user
        /// </summary>
        [Required]
        public ActivityLevel ActivityLevel { get; set; } = null!;

        /// <summary>
        /// Contains the calculated BMR - it's the minimum level of energy required to sustain vital functions such as breathing, digestion, and circulation.
        /// </summary>
        public int BMR { get; set; }

        /// <summary>
        /// the id of the ProUser user of those details
        /// </summary>
		[Required]
		public int ProUserId { get; set; }

        /// <summary>
        /// the ProUser user of those details
        /// </summary>
        [ForeignKey(nameof(ProUserId))]
        public ProUser ProUser { get; set; } = null!;

	}
}

