using ApplicationLayer.Projects.Commands.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Projects.Commands.EntityTypeConfigurations
{
    public class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.HasKey(Task => Task.Id);
            builder.HasIndex(Task => Task.Id).IsUnique();
            builder.Property(Task => Task.Name).HasMaxLength(250);
        }
    }
}
