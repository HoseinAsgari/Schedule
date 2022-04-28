using System.Threading.Tasks;
using System.Collections.Generic;
using Application.ViewModels.Goal;

namespace Application.Interfaces
{
    public interface IGoalService
    {
        Task<List<ShowGoalsVm>> GetUserGoalsAsync(string userName);
        Task AddGoalAsync(string userName, AddGoalVm addGoalViewModel);
    }
}