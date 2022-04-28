using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Application.Helpers.SecurityHelper;
using Application.Interfaces;
using Application.ViewModels.Account;
using Domain.Entities;
using Persistence.Contexts;

namespace Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly ScheduleDbContext _context;
        public AccountService(ScheduleDbContext context)
        {
            _context = context;
        }

        public async Task<bool> IsPasswordAndUserNameExists(LogInVm logInViewModel)
        {
            var hashedPassword = HashStringHelper.EncodePasswordMd5(logInViewModel.Password);
            var userExist = await _context.Users.AnyAsync(user => user.Name == logInViewModel.UserName && user.Password == hashedPassword);
            return userExist;
        }

        public async Task<bool> IsUserExistsByUserName(string userName)
        {
            var userExist = await _context.Users.AnyAsync(user => user.Name == userName);
            return userExist;
        }

        public async Task RegisterAccount(SignInVm signInViewModel)
        {
            var hashedPassword = HashStringHelper.EncodePasswordMd5(signInViewModel.Password);
            User user = new()
            {
                Name = signInViewModel.UserName,
                Password = hashedPassword
            };

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
}