using Schedule.Application.Interfaces;
using Schedule.Application.Services;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Schedule.Infra.IoC
{
    public static class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IPlanService, PlanService>();
            serviceCollection.AddScoped<IRulesService, RulesService>();
            serviceCollection.AddScoped<IGoalService, GoalService>();
            serviceCollection.AddScoped<IAccountService, AccountService>();
        }
    }
}
