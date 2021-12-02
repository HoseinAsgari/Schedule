using System.Threading.Tasks;
using System.Collections.Generic;
using Application.ViewModels.Goals;
using Application.Interfaces;
using Persistence.Contexts;

namespace Application.Services
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