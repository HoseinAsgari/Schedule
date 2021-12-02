using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Schedule.Domain.Models
{
    public class DefaultSchedule
    {
        [Key]
        public int DefaultScheduleId { get; set; }
        
        public User User { get; set; }
        public List<ScheduleTask> ScheduleTasks { get; set; }
    }
}