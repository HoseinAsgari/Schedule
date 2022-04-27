using System.Collections.Generic;

namespace Domain.Entities
{
    public class WeeklySchedule
    {
        public WeeklySchedule()
        {
            ScheduleTasks = new List<ScheduleTask>();
        }
        
        public int Id { get; set; }
        
        public User User { get; set; }
        public ICollection<ScheduleTask> ScheduleTasks { get; set; }
    }
}