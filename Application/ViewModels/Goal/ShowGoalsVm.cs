using Domain.Enums;

namespace Application.ViewModels.Goal;

public class ShowGoalsVm
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string DateAdded { get; set; }
    public string GoalStatus { get; set; }
}