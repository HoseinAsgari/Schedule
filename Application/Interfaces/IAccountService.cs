using System.Threading.Tasks;
using Application.ViewModels.Account;

namespace Application.Interfaces
{
    public interface IAccountService
    {
        Task<bool> IsPasswordAndUserNameExists(LogInViewModel logInViewModel);
        Task RegisterAccount(SignInViewModel signInViewModel);
        Task<bool> IsUserExistsByUserName(string userName);
    }
}