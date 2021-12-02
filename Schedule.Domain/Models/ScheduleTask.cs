using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Schedule.Domain.Models
{
    public class ScheduleTask
    {
        [Key]
        public int ScheduleTaskId { get; set; }
        public int IndexOfPartDay { get; set; }
        public string ScheduleTaskText { get; set; }
        public bool TaskDone { get; set; }

        public User User { get; set; }
        public DefaultSchedule DefaultSchedule { get; set; }
    }
}