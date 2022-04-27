using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Persistence.Contexts
{
    public class ScheduleDbContext : DbContext
    {
        public ScheduleDbContext(DbContextOptions<ScheduleDbContext> options) : base(options)
        {

        }

        public DbSet<DailySchedule> DailySchedules { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Note> Note { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<RuleDivorce> RuleDivorces { get; set; }
        public DbSet<ScheduleTask> ScheduleTasks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WeeklySchedule> WeeklySchedules { get; set; }
    }
}