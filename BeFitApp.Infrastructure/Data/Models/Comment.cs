using System;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BeFitApp.Infrastructure.Data.Models
{
    /// <summary>
    /// a class for a comment of a post (only loged in users can comment)
    /// </summary>
	public class Comment
	{
        /// <summary>
        /// the id of the comment
        /// </summary>
        [Key]
		public int Id { get; set; }

        /// <summary>
        /// the body of the comment
        /// </summary>
        [Required]
        [StringLength(200)]
		public string  Content { get; set; } = null!;

        /// <summary>
        /// the id of the BlogPost to which the comment refers
        /// </summary>
        [Required]
        public int BlogPostId { get; set; }

        ///// <summary>
        ///// the BlogPost to which the comment refers
        ///// </summary>
        //[ForeignKey(nameof(BlogPostId))]
        //public BlogPost BlogPost { get; set; } = null!;

        /// <summary>
        /// the id of the user who write the comment
        /// </summary>
        [Required]
        public string UserId { get; set; } = null!;

        ///// <summary>
        ///// the User who add the comment
        ///// </summary>
        //[ForeignKey(nameof(UserId))]
        //public IdentityUser User { get; set; } = null!;

        /// <summary>
        /// a boolean that helps to "delete" a comment
        /// </summary>
        public bool isDeleted { get; set; } = false;
    }
}

