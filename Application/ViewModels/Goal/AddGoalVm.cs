using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels.Goal;

public class AddGoalVm
{
    [Required(ErrorMessage = "تیتر نباید خالی باشد"), MinLength(1, ErrorMessage = "تیتر نباید خالی باشد")]
    public string Title { get; set; }
    [Required(ErrorMessage = "طول مدت نباید خالی باشد"), MinLength(1, ErrorMessage = "طول مدت نباید خالی باشد")]
    public string Category { get; set; }
}