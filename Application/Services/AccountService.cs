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
        readonly ScheduleDbContext _context;
        public AccountService(ScheduleDbContext context)
        {
            _context = context;
        }

        public async Task<bool> IsPasswordAndUserNameExists(LogInViewModel logInViewModel)
        {
            string hashedPassword = await HashStringHelper.EncodePasswordMd5(logInViewModel.Password);
            return await _context.Users.AnyAsync(user => user.Name == logInViewModel.UserName && user.Password == hashedPassword);
        }

        public async Task<bool> IsUserExistsByUserName(string userName)
        {
            return await _context.Users.AnyAsync(user => user.Name == userName);
        }

        public async Task RegisterAccount(SignInViewModel signInViewModel)
        {
            User user = new()
            {
                Name = signInViewModel.UserName,
                Password = signInViewModel.Password
            };

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
}