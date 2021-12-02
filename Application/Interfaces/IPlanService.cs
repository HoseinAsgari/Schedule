using System.Threading.Tasks;
using Application.ViewModels.Plan;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IPlanService
    {
        Task<List<ShowPlanViewModel>> GetPlans(string userName);
        Task<List<ShowDefaultPlanViewModel>> GetDefaultPlans(string userName);
    }
}