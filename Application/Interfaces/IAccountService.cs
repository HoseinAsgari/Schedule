using System.Threading.Tasks;
using Application.ViewModels.Account;

namespace Application.Interfaces
{
    public interface IAccountService
    {
        Task<bool> IsPasswordAndUserNameExists(LogInVm logInViewModel);
        Task RegisterAccount(SignInVm signInViewModel);
        Task<bool> IsUserExistsByUserName(string userName);
    }
}