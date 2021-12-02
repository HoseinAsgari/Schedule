using System.Threading.Tasks;
using System.Collections.Generic;
using Schedule.Application.ViewModels.Goals;
using Schedule.Application.Interfaces;
using Schedule.Infra.Data.Contexts;

namespace Schedule.Application.Services
{
    public class GoalService : IGoalService
    {
        ScheduleDbContext _scheduleDbContext;
        public GoalService(ScheduleDbContext scheduleDbContext)
        {
            _scheduleDbContext = scheduleDbContext;
        }

        public async Task<List<ShowGoalsViewModel>> GetUserGoals(string email)
        {
            return null;
        }
    }
}