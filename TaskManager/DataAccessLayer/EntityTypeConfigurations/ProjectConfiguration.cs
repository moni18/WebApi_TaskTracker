using ApplicationLayer.Projects.Commands.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Projects.Commands.EntityTypeConfigurations
{
    public class ProjectConfiguration:IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(Project => Project.Id);
            builder.HasIndex(Project => Project.Id).IsUnique();
            builder.Property(Project => Project.Name).HasMaxLength(250);
        }
    }
}
