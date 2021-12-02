using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Schedule.Application.Helpers.SecurityHelper;
using Schedule.Application.Interfaces;
using Schedule.Application.ViewModels.Account;
using Schedule.Domain.Models;
using Schedule.Infra.Data.Contexts;

namespace Schedule.Application.Services
{
    public class AccountService : IAccountService
    {
        ScheduleDbContext _context;
        public AccountService(ScheduleDbContext context)
        {
            _context = context;
        }

        public async Task<bool> IsPasswordAndUserNameExists(LogInViewModel logInViewModel)
        {
            string hashedPassword = await HashStringHelper.EncodePasswordMd5(logInViewModel.Password);
            return await _context.User.AnyAsync(user => user.UserName == logInViewModel.UserName && user.UserPassword == hashedPassword);
        }

        public async Task<bool> IsUserExistsByUserName(string userName)
        {
            return await _context.User.AnyAsync(user => user.UserName == userName);
        }

        public async Task RegisterAccount(SignInViewModel signInViewModel)
        {
            User user = new()
            {
                UserName = signInViewModel.UserName,
                UserPassword = signInViewModel.Password
            };

            DefaultSchedule userDefaultSchedule = new()
            {
                User = user
            };

            await _context.User.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
}