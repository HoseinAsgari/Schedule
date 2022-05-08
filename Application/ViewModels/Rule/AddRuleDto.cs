using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels.Rule;

public class AddRuleDto
{
    [MaxLength(100, ErrorMessage = "بیشترین تعداد کاراکتر {0} میتواند {1} باشد.")]
    [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
    public string Text { get; set; }
}