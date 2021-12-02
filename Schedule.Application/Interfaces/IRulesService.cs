using System.Collections.Generic;
using System.Threading.Tasks;
using Schedule.Application.ViewModels.Rule;

namespace Schedule.Application.Interfaces
{
    public interface IRulesService
    {
        Task<List<ShowRulesViewModel>> GetRules(string email);
    }
}