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

namespace Application.Services
{
    public class PlanService : IPlanService
    {
        ScheduleDbContext _scheduleDbContext;
        public PlanService(ScheduleDbContext scheduleDbContext)
        {
            _scheduleDbContext = scheduleDbContext;
        }

        public async Task<List<ShowPlanViewModel>> GetPlans(string userName)
        {
            return (await GetScheduleTasks(userName)).Select(n => new ShowPlanViewModel()
            {
                Done = n.IsDone,
                Task = n.Text,
                Time = ShamsiCalendarHelper.ToShamsi(DateTime.Today.AddHours(0.5 * n.IndexOfPartDay)).Result
            }).ToList();
        }

        public async Task<List<ShowDefaultPlanViewModel>> GetDefaultPlans(string userName)
        {
            return (await GetDefaultScheduleByUserName(userName)).ScheduleTasks.Select(p => new ShowDefaultPlanViewModel()
            {
                PlanId = p.Id,
                PlanName = p.Text,
                TimeOfDay = TimeHelper.GetTimeFromPartOfDay(p.IndexOfPartDay)
            }).ToList();
        }



        private async Task<List<ScheduleTask>> GetScheduleTasks(string userName)
        {
            return (await GetUserByUserName(userName)).ScheduleTasks;
        }

        private async Task<DefaultSchedule> GetDefaultScheduleByUserName(string userName)
        {
            return await _scheduleDbContext.DefaultSchedules.SingleAsync(p => p.User.Name == userName);
        }

        private async Task<User> GetUserByUserName(string UserName)
        {
            return await _scheduleDbContext.Users.SingleAsync(user => user.Name == UserName);
        }
    }
}