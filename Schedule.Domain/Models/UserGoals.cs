using System.ComponentModel.DataAnnotations;

namespace Schedule.Domain.Models
{
    public class UserGoals
    {
        [Key]
        public int GoalId { get; set; }
        public string GoalText { get; set; }
        public bool IsDone { get; set; }
        
        public User User { get; set; }
    }
}