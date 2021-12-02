using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Persistence.Contexts
{
    public class ScheduleDbContext : DbContext
    {
        public ScheduleDbContext(DbContextOptions<ScheduleDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<DefaultSchedule> DefaultSchedules { get; set; }
        public DbSet<ScheduleTask> ScheduleTasks { get; set; }
    }
}