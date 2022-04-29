using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Application.Helpers.IdentityHelper;
using Application.ViewModels.Rule;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Application.Services
{
    public class RuleService : IRuleService
    {
        private readonly ScheduleDbContext _scheduleDbContext;
        private readonly IUserIdentityService _userIdentityService;

        public RuleService(ScheduleDbContext scheduleDbContext, IUserIdentityService userIdentityService)
        {
            _scheduleDbContext = scheduleDbContext;
            _userIdentityService = userIdentityService;
        }

        public async Task<List<ShowRulesVm>> GetRulesAsync()
        {
            var user = await GetUserAsync();

            var model = await _scheduleDbContext.Rules
                .Where(rule => rule.User == user)
                .Select(rule => new ShowRulesVm
                {
                    Id = rule.Id,
                    Title = rule.Text,
                    DivorcesCount = rule.RuleDivorces.Count
                })
                .ToListAsync();
            
            return model;
        }

        private async Task<User> GetUserAsync()
        {
            var userName = await _userIdentityService.GetUserName();
            var user = await _scheduleDbContext.Users.SingleAsync(user => user.Name == userName);
            return user;
        }
    }
}