using System.ComponentModel.DataAnnotations;

namespace Schedule.Domain.Models
{
    public class UserRules
    {
        [Key]
        public int UserRuleId { get; set; }
        public string UserRuleText { get; set; }
        
        public User User { get; set; }
        
    }
}