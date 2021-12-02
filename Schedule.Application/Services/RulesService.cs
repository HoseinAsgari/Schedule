using System.Threading.Tasks;
using System.Collections.Generic;
using Schedule.Application.ViewModels.Rule;
using Schedule.Application.Interfaces;
using Schedule.Infra.Data.Contexts;

namespace Schedule.Application.Services
{
    public class RulesService : IRulesService
    {
        ScheduleDbContext _scheduleDbContext;
        public RulesService(ScheduleDbContext scheduleDbContext)
        {
            _scheduleDbContext = scheduleDbContext;
        }

        public async Task<List<ShowRulesViewModel>> GetRules(string email)
        {
            return null;
        }
    }
}