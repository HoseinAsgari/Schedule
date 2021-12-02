using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Schedule.Domain.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }

        public List<UserRules> UserRules { get; set; }
        public List<ScheduleTask> ScheduleTasks { get; set; }
        public List<UserGoals> UserGoals { get; set; }
        public List<DefaultSchedule> DefaultSchedules { get; set; }
    }
}