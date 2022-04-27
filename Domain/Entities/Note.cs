using System;

namespace Domain.Entities;

public class Note
{
    public int Id { get; set; }
    public DateTime DateAdded { get; set; }
    public string Title { get; set; }
    public bool Deleted { get; set; }
    public DateTime ForTime { get; set; }

    public User User { get; set; }
}