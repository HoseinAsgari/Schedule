using Application.Interfaces;
using Application.ViewModels.Plan;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using System.Threading.Tasks;
using System.Linq;
using System;
using Application.Helpers.CalendarHelper;
using Domain.Entities;
using Domain.Enums;

namespace Application.Services
{
    public class PlanService : IPlanService
    {
        ScheduleDbContext _scheduleDbContext;
        public PlanService(ScheduleDbContext scheduleDbContext)
        {
            _scheduleDbContext = scheduleDbContext;
        }

        public async Task<List<ShowPlanViewModel>> GetPlansAsync(string userName)
        {
            var scheduleTasks = await GetScheduleTasksAsync(userName);
            var today = DateTime.Today;

            var model = scheduleTasks.Select(n => 
                new ShowPlanViewModel()
                {
                    Done = n.IsDone == GoalStatus.Done,
                    Task = n.Text,
                    Time = ShamsiCalendarHelper.ToShamsi(today.AddHours(0.5 * n.Index))
                }
            ).ToList();

            return model;
        }

        public async Task<List<ShowWeeklyPlanViewModel>> GetWeeklyPlansAsync(string userName)
        {
            var user = await GetWeeklyScheduleByUserNameAsync(userName);

            var model = user.ScheduleTasks.Select(p => new ShowWeeklyPlanViewModel()
            {
                PlanId = p.Id,
                PlanName = p.Text,
                TimeOfDay = TimeHelper.GetTimeFromPartOfDay(p.Index)
            }).ToList();
            
            return model;
        }



        private async Task<List<ScheduleTask>> GetScheduleTasksAsync(string userName)
        {
            var user = await GetUserByUserNameAsync(userName);
            var scheduleTasks = user.ScheduleTasks.ToList();
            
            return scheduleTasks;
        }

        private async Task<WeeklySchedule> GetWeeklyScheduleByUserNameAsync(string userName)
        {
            var weeklySchedule = await _scheduleDbContext.WeeklySchedules
                .SingleAsync(p => p.User.Name == userName);

            return weeklySchedule;
        }

        private async Task<User> GetUserByUserNameAsync(string UserName)
        {
            var user = await _scheduleDbContext.Users.SingleAsync(user => user.Name == UserName);

            return user;
        }
    }
}