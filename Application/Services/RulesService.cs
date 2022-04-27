using System.Threading.Tasks;
using System.Collections.Generic;
using Application.ViewModels.Rule;
using Application.Interfaces;
using Persistence.Contexts;

namespace Application.Services
{
    public class RulesService : IRulesService
    {
        ScheduleDbContext _scheduleDbContext;
        public RulesService(ScheduleDbContext scheduleDbContext)
        {
            _scheduleDbContext = scheduleDbContext;
        }

        public async Task<List<ShowRulesViewModel>> GetRulesAsync(string userName)
        {
            return null;
        }
    }
}