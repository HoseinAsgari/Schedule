using System.Threading.Tasks;
using Application.ViewModels.Plan;
using System.Collections.Generic;
using System.Threading;

namespace Application.Interfaces
{
    public interface IPlanService
    {
        Task<List<ShowPlanVm>> GetPlansAsync(string userName);
        Task<List<ShowWeeklyPlanVm>> GetWeeklyPlansAsync(string userName);
    }
}