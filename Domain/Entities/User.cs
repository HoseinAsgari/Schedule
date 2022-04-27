using System.Collections.Generic;

namespace Domain.Entities
{
    public class User
    {
        public User()
        {
            Rules = new List<Rule>();
            ScheduleTasks = new List<ScheduleTask>();
            Goals = new List<Goal>();
            WeeklySchedules = new List<WeeklySchedule>();
            DailySchedules = new List<DailySchedule>();
            Notes = new List<Note>();
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public ICollection<Rule> Rules { get; set; }
        public ICollection<ScheduleTask> ScheduleTasks { get; set; }
        public ICollection<Goal> Goals { get; set; }
        public ICollection<WeeklySchedule> WeeklySchedules { get; set; }
        public ICollection<DailySchedule> DailySchedules { get; set; }
        public ICollection<Note> Notes { get; set; }
    }
}