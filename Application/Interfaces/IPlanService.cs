using System.Threading.Tasks;
using Application.ViewModels.Plan;
using System.Collections.Generic;
using System.Threading;

namespace Application.Interfaces
{
    public interface IPlanService
    {
        Task<List<ShowPlanViewModel>> GetPlansAsync(string userName);
        Task<List<ShowWeeklyPlanViewModel>> GetWeeklyPlansAsync(string userName);
    }
}