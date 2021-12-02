using System.Threading.Tasks;
using Schedule.Application.ViewModels.Account;

namespace Schedule.Application.Interfaces
{
    public interface IAccountService
    {
        Task<bool> IsPasswordAndUserNameExists(LogInViewModel logInViewModel);
        Task RegisterAccount(SignInViewModel signInViewModel);
        Task<bool> IsUserExistsByUserName(string userName);
    }
}