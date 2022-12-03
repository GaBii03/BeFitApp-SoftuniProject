using System.Threading.Tasks.Dataflow;
using BeFitApp.Infrastructure.Data.Configuration;
using BeFitApp.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BeFitApp.Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new UserConfiguration());
        builder.ApplyConfiguration(new ActivityLevelConfiguration());

        base.OnModelCreating(builder);
    }

    public DbSet<ProUser> ProUsers  { get; set; } = null!;
    public DbSet<ProUserDetails> ProUsersDetails { get; set; } = null!;
    public DbSet<Meal> Meals { get; set; } = null!;
    public DbSet<Exercise> Exercises { get; set; } = null!;
    public DbSet<Day> Days { get; set; } = null!;
    public DbSet<Comment> Comments { get; set; } = null!;
    public DbSet<BlogPost> BlogPosts { get; set; } = null!;
    public DbSet<ActivityLevel> ActivityLevels { get; set; } = null!;

}

