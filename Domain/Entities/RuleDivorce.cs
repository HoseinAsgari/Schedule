using System;

namespace Domain.Entities;

public class RuleDivorce
{
    public int Id { get; set; }
    public DateTime DateAdded { get; set; }
    public string DescriptReasons { get; set; }
    public string HowSolveItForNextTime { get; set; }
    
    public Rule Rule { get; set; }
}