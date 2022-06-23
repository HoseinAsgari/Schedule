using System;
using Domain.Enums;

namespace Domain.Entities
{
    public class Goal
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public GoalStatus GoalStatus { get; set; }
        public DateTime DateAdded { get; set; }
        public DateCategory DateCategory { get; set; }
        
        public User User { get; set; }
        public int UserId { get; set; }
    }
}