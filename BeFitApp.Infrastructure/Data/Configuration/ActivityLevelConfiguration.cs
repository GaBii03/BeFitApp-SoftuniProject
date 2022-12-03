using System;
using BeFitApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeFitApp.Infrastructure.Data.Configuration
{
	public class ActivityLevelConfiguration : IEntityTypeConfiguration<ActivityLevel>
    {
        public void Configure(EntityTypeBuilder<ActivityLevel> builder)
        {
            builder.HasData(CreateCategories());
        }

        private List<ActivityLevel> CreateCategories()
        {
            List<ActivityLevel> activityLevels = new List<ActivityLevel>()
            {
                new ActivityLevel()
                {
                    Id = 1,
                    Level = "Sedentary (little or no exercise)",
                    ActivityIndex = 1.2
                },

                new ActivityLevel()
                {
                    Id = 2,
                    Level = "Lightly active (exercise 1–3 days/week)",
                    ActivityIndex = 1.375
                },

                new ActivityLevel()
                {
                    Id = 3,
                    Level = "Moderately active (exercise 3–5 days/week)",
                    ActivityIndex = 1.55
                },

                new ActivityLevel()
                {
                    Id = 4,
                    Level = "Active (exercise 6–7 days/week)",
                    ActivityIndex = 1.725
                },

                new ActivityLevel()
                {
                    Id = 5,
                    Level = "Very active (hard exercise 6–7 days/week)",
                    ActivityIndex = 1.9
                }
            };

            return activityLevels;
        }

    }
}

