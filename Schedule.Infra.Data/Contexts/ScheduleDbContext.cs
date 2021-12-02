using Microsoft.EntityFrameworkCore;
using Schedule.Domain.Models;

namespace Schedule.Infra.Data.Contexts
{
    public class ScheduleDbContext : DbContext
    {
        public ScheduleDbContext(DbContextOptions<ScheduleDbContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<UserGoals> UserGoals { get; set; }
        public DbSet<UserRules> UserRules { get; set; }
        public DbSet<DefaultSchedule> DefaultSchedule { get; set; }
        public DbSet<ScheduleTask> ScheduleTask { get; set; }
    }
}