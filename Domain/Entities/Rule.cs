namespace Domain.Entities
{
    public class Rule
    {
        public int Id { get; set; }
        public string Text { get; set; }
        
        public User User { get; set; }
        
    }
}