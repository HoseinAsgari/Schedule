using System.Collections.Generic;
using System.Threading.Tasks;
using Application.ViewModels.Rule;

namespace Application.Interfaces
{
    public interface IRulesService
    {
        Task<List<ShowRulesVm>> GetRulesAsync(string userName);
    }
}