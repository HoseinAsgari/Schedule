using System.Threading.Tasks;
using System.Collections.Generic;
using Schedule.Application.ViewModels.Goals;

namespace Schedule.Application.Interfaces
{
    public interface IGoalService
    {
        Task<List<ShowGoalsViewModel>> GetUserGoals(string email);
    }
}