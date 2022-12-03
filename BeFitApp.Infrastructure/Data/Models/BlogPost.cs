using System;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeFitApp.Infrastructure.Data.Models
{
    /// <summary>
    /// a class for a BlogPost that every loged in user can post
    /// </summary>
	public class BlogPost
	{
        /// <summary>
        /// constructor of the BlogPost model that initialise new list with comments for the current post
        /// </summary>
        public BlogPost()
        {
            Comments = new List<Comment>();
        }

        /// <summary>
        /// the id of the post
        /// </summary>
        [Key]
		public int Id { get; set; }

        /// <summary>
        /// the title of the post
        /// </summary>
        [Required]
        [StringLength(100)]
		public string Title { get; set; } = null!;

        /// <summary>
        /// the body of the post
        /// </summary>
        [Required]
        [StringLength(1000)]
        public string Content { get; set; } = null!;

        /// <summary>
        /// a list with all comments of a post
        /// </summary>
		public List<Comment> Comments { get; set; }

        /// <summary>
        /// count of total likes of a post
        /// </summary>
		public int LikesCount { get; set; } = 0;

        /// <summary>
        /// the id of the User who post this BlogPost
        /// </summary>
        [Required]
        public string UserId { get; set; } = null!;

        /// <summary>
        /// the User who post this BlogPost
        /// </summary>
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        /// <summary>
        /// a boolean that helps to "delete" a BlogPost 
        /// </summary>
        public bool isDeleted { get; set; } = false;

    }
}

