using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels.Account
{
    public class LogInViewModel
    {
        [Display(Name = "نام کاربری"), Required(ErrorMessage = "{0} را پر کنید"), MaxLength(150, ErrorMessage = "{0} حداکثر میتواند {1} کاراکتر داشته باشد")]
        public string UserName { get; set; }

        [Display(Name = "رمز عبور"), Required(ErrorMessage = "{0} را پر کنید"), MaxLength(15, ErrorMessage = "{0} حداکثر میتواند {1} کاراکتر داشته باشد"), MinLength(8, ErrorMessage = "{0} حداقل باید {1} کاراکتر داشته باشد"), DataType(DataType.Password, ErrorMessage = "{0}ی معتبر وارد کنید")]
        public string Password { get; set; }
        
        [Display(Name = "مرا به خاطر بسپار")]
        public bool RememberMe { get; set; }
    }
}
