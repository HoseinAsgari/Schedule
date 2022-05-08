using System.Collections.Generic;
using System.Threading.Tasks;
using Application.ViewModels.Rule;

namespace Application.Interfaces
{
    public interface IRuleService
    {
        Task<List<ShowRulesVm>> GetRulesAsync();
        Task AddRuleAsync(AddRuleDto addRuleDto);
    }
}