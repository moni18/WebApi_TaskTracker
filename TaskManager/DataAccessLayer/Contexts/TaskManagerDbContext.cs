using ApplicationLayer.Projects.Commands.Entity;
using ApplicationLayer.Projects.Commands.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;
using System;

namespace ApplicationLayer.Projects.Commands.Contexts
{
    public class TaskManagerDbContext: DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
        
        public TaskManagerDbContext(DbContextOptions<TaskManagerDbContext> options) :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            new ProjectConfiguration().Configure(builder.Entity<Project>());
            new TaskConfiguration().Configure(builder.Entity<Task>());
        }
    }
}
