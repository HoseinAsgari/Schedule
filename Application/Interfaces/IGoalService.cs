using System.Threading.Tasks;
using System.Collections.Generic;
using Application.ViewModels.Goals;

namespace Application.Interfaces
{
    public interface IGoalService
    {
        Task<List<ShowGoalsViewModel>> GetUserGoals(string email);
    }
}