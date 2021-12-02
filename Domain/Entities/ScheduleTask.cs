namespace Domain.Entities
{
    public class ScheduleTask
    {
        public int Id { get; set; }
        public int IndexOfPartDay { get; set; }
        public string Text { get; set; }
        public bool IsDone { get; set; }

        public User User { get; set; }
        public DefaultSchedule DefaultSchedule { get; set; }
    }
}