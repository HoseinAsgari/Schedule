using Application.Interfaces;
using Application.ViewModels.Plan;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using System.Threading.Tasks;
using System.Linq;
using System;
using Application.Helpers.CalendarHelper;
using Application.Helpers.IdentityHelper;
using Domain.Entities;
using Domain.Enums;

namespace Application.Services
{
    public class PlanService : IPlanService
    {
        private readonly ScheduleDbContext _scheduleDbContext;
        private readonly IUserIdentityService _userIdentityService;
        public PlanService(ScheduleDbContext scheduleDbContext, IUserIdentityService userIdentityService)
        {
            _scheduleDbContext = scheduleDbContext;
            _userIdentityService = userIdentityService;
        }

        public async Task<List<ShowPlanVm>> GetPlansAsync()
        {
            var scheduleTasks = await GetScheduleTasksAsync();
            var today = DateTime.Today;

            var model = scheduleTasks.Select(n => 
                new ShowPlanVm()
                {
                    Done = n.IsDone == GoalStatus.Done,
                    Task = n.Text,
                    Time = today.AddHours(0.5 * n.Index).ToShamsi()
                }
            ).ToList();

            return model;
        }

        public async Task<List<ShowWeeklyPlanVm>> GetWeeklyPlanAsync()
        {
            var user = await GetWeeklyScheduleByUserNameAsync();

            var model = user.ScheduleTasks.Select(p => new ShowWeeklyPlanVm()
            {
                PlanId = p.Id,
                PlanName = p.Text,
                TimeOfDay = TimeHelper.GetTimeFromPartOfDay(p.Index)
            }).ToList();
            
            return model;
        }



        private async Task<List<ScheduleTask>> GetScheduleTasksAsync()
        {
            var user = await GetUserByUserNameAsync();
            var scheduleTasks = user.ScheduleTasks.ToList();
            
            return scheduleTasks;
        }

        private async Task<WeeklySchedule> GetWeeklyScheduleByUserNameAsync()
        {
            var userName = await _userIdentityService.GetUserName();
            var weeklySchedule = await _scheduleDbContext.WeeklySchedules
                .SingleAsync(p => p.User.Name == userName);

            return weeklySchedule;
        }

        private async Task<User> GetUserByUserNameAsync()
        {
            var userName = await _userIdentityService.GetUserName();
            var user = await _scheduleDbContext.Users.SingleAsync(user => user.Name == userName);

            return user;
        }
    }
}