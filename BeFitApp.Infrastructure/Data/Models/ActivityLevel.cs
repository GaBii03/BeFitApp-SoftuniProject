using System;
using System.ComponentModel.DataAnnotations;

namespace BeFitApp.Infrastructure.Data.Models
{
    /// <summary>
    /// class for each different activity level
    /// </summary>
	public class ActivityLevel
	{
		public ActivityLevel()
        {
            ProUsers = new List<ProUser>();
		}

        /// <summary>
        /// the id of the activity level
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// level of activity
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Level { get; set; } = null!;

        /// <summary>
        /// activity index on which depends how much calories a person needs
        /// </summary>
        public double ActivityIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<ProUser> ProUsers { get; set; }
    }
}

