using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels.Account
{
    public class ChangePasswordVm
    {
        [Display(Name = "رمز عبور جدید"), Required(ErrorMessage = "{0} را پر کنید"), MaxLength(15, ErrorMessage = "{0} حداکثر میتواند {1} کاراکتر داشته باشد"), MinLength(8, ErrorMessage = "{0} حداقل باید {1} کاراکتر داشته باشد"), DataType(DataType.Password, ErrorMessage = "{0}ی معتبر وارد کنید")]
        public string NewPassword { get; set; }

        [Display(Name = "تکرار رمز عبور جدید"), Compare(nameof(NewPassword), ErrorMessage = "{0} با {1} همخوانی ندارد"), DataType(DataType.Password)]
        public string RePassword { get; set; }
    }
}
