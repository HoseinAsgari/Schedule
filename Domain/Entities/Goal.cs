namespace Domain.Entities
{
    public class Goal
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsDone { get; set; }
        
        public User User { get; set; }
    }
}