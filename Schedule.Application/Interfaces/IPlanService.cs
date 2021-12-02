using System.Threading.Tasks;
using Schedule.Application.ViewModels.Plan;
using System.Collections.Generic;

namespace Schedule.Application.Interfaces
{
    public interface IPlanService
    {
        Task<List<ShowPlanViewModel>> GetPlans(string userName);
        Task<List<ShowDefaultPlanViewModel>> GetDefaultPlans(string userName);
    }
}