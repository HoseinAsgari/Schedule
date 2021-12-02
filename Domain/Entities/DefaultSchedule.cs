using System.Collections.Generic;

namespace Domain.Entities
{
    public class DefaultSchedule
    {
        public int Id { get; set; }
        
        public User User { get; set; }
        public List<ScheduleTask> ScheduleTasks { get; set; }
    }
}