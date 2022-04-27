using System.Collections.Generic;

namespace Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public List<Rule> Rules { get; set; }
        public List<ScheduleTask> ScheduleTasks { get; set; }
        public List<Goal> Goals { get; set; }
        public List<WeeklySchedule> WeeklySchedules { get; set; }
        public List<DailySchedule> DailySchedules { get; set; }
        public List<Note> Notes { get; set; }
    }
}