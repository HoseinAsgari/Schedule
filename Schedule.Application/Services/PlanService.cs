using Schedule.Application.Interfaces;
using Schedule.Application.ViewModels.Plan;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Schedule.Infra.Data.Contexts;
using System.Threading.Tasks;
using System.Linq;
using System;
using Schedule.Application.Helpers.CalendarHelper;
using Schedule.Domain.Models;

namespace Schedule.Application.Services
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
                Done = n.TaskDone,
                Task = n.ScheduleTaskText,
                Time = ShamsiCalendarHelper.ToShamsi(DateTime.Today.AddHours(0.5 * n.IndexOfPartDay)).Result
            }).ToList();
        }

        public async Task<List<ShowDefaultPlanViewModel>> GetDefaultPlans(string userName)
        {
            return (await GetDefaultScheduleByUserName(userName)).ScheduleTasks.Select(p => new ShowDefaultPlanViewModel()
            {
                PlanId = p.ScheduleTaskId,
                PlanName = p.ScheduleTaskText,
                TimeOfDay = TimeHelper.GetTimeFromPartOfDay(p.IndexOfPartDay)
            }).ToList();
        }



        private async Task<List<ScheduleTask>> GetScheduleTasks(string userName)
        {
            return (await GetUserByUserName(userName)).ScheduleTasks;
        }

        private async Task<DefaultSchedule> GetDefaultScheduleByUserName(string userName)
        {
            return await _scheduleDbContext.DefaultSchedule.SingleAsync(p => p.User.UserName == userName);
        }

        private async Task<User> GetUserByUserName(string UserName)
        {
            return await _scheduleDbContext.User.SingleAsync(user => user.UserName == UserName);
        }
    }
}