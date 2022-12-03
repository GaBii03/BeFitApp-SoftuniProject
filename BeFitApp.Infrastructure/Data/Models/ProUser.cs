using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeFitApp.Infrastructure.Data.Models
{
	/// <summary>
	/// Class for the user who become the boss of their health (user who start tracking theirs excercises and food)
	/// </summary>
	public class ProUser
	{
        /// <summary>
        /// the id of the ProUser user
        /// </summary>
		[Key]
		public int Id { get; set; }

        /// <summary>
        /// the phone number of the ProUser user
        /// </summary>
        [Required]
        [StringLength(15)]
        public string PhoneNumber { get; set; } = null!;

        /// <summary>
        /// the id of the User who become ProUser
        /// </summary>
        [Required]
        public string UserId { get; set; } = null!;

        /// <summary>
        /// the User who become ProUser
        /// </summary>
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        /// <summary>
        /// a boolean that helps to "delete" a ProUser
        /// </summary>
        public bool isDeleted { get; set; } = false;
    }
}

