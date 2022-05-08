using System.Collections.Generic;

namespace Domain.Entities
{
    public class Rule
    {
        public Rule()
        {
            RuleDivorces = new List<RuleDivorce>();
        }
        
        public int Id { get; set; }
        public string Text { get; set; }
        
        public User User { get; set; }
        public int UserId { get; set; }
        public ICollection<RuleDivorce> RuleDivorces { get; set; }
    }
}