using Application.Interfaces;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IPlanService, PlanService>();
            services.AddScoped<IRuleService, RuleService>();
            services.AddScoped<IGoalService, GoalService>();
            services.AddScoped<IAccountService, AccountService>();
        }
    }
}