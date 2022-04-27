using System;
using Domain.Enums;

namespace Domain.Entities
{
    public class ScheduleTask
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Index { get; set; }
        public GoalStatus IsDone { get; set; }
        public TimeSpan NeededTimeToDo { get; set; }
        public DateTime TimeDone { get; set; }

        public User User { get; set; }
        public WeeklySchedule WeeklySchedule { get; set; }
        public DailySchedule DailySchedule { get; set; }
    }
}