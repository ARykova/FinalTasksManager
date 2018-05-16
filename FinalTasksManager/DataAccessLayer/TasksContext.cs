using Microsoft.EntityFrameworkCore;
using FinalTasksManager.Models;

namespace FinalTasksManager
{
    public class TasksContext : DbContext
    {
        public TasksContext(DbContextOptions<TasksContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                .HasOne(p => p.Lock)
                .WithOne(pl => pl.Project)
                .HasForeignKey<ProjectLock>(pl => pl.ProjectId);
        }
    }
}
