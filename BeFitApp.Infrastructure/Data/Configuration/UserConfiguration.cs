using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeFitApp.Infrastructure.Data.Configuration
{
	public class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<IdentityUser> CreateUsers()
        {
            var users = new List<IdentityUser>();
            var hasher = new PasswordHasher<IdentityUser>();

            var user = new IdentityUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "user@mail.com",
                NormalizedUserName = "USER@MAIL.COM",
                Email = "user@mail.com",
                NormalizedEmail = "USER@MAIL.COM"
            };

            user.PasswordHash =
                 hasher.HashPassword(user, "User123");

            users.Add(user);

            user = new IdentityUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "prouser@mail.com",
                NormalizedUserName = "PROUSER@MAIL.COM",
                Email = "prouser@mail.com",
                NormalizedEmail = "PROUSER@MAIL.COM"
            };

            user.PasswordHash =
            hasher.HashPassword(user, "Prouser123");
            users.Add(user);

            return users;
        }

    }
}


