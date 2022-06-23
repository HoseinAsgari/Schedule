using System.Threading.Tasks;
using System.Collections.Generic;
using Application.ViewModels.Goal;

namespace Application.Interfaces
{
    public interface IGoalService
    {
        Task<List<ShowGoalsVm>> GetUserGoalsAsync(bool showCanceledGoals);
        Task AddGoalAsync(AddGoalVm addGoalViewModel);
        Task GoalStartedAsync(int id);
        Task GoalCanceledAsync(int id);
        Task GoalFinishedAsync(int id);
    }
}