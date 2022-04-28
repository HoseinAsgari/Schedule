using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Application.Helpers.CalendarHelper;
using Application.ViewModels.Goal;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Application.Services;

public class GoalService : IGoalService
{
    private readonly ScheduleDbContext _scheduleDbContext;
    public GoalService(ScheduleDbContext scheduleDbContext)
    {
        _scheduleDbContext = scheduleDbContext;
    }

    public async Task<List<ShowGoalsVm>> GetUserGoalsAsync(string userName)
    {
        var user = await GetUserByUserNameAsync(userName);
        var model = await _scheduleDbContext.Goals
            .Where(goal => goal.User == user && goal.DateCategory != DateCategory.Daily)
            .Select(goal => new ShowGoalsVm
                {
                    Id = goal.Id,
                    Title = goal.Title,
                    DateAdded = goal.DateAdded.ToShamsi(),
                    GoalStatus = GoalStatusToPersian(goal.GoalStatus)
                })
            .ToListAsync();
        return model;
    }

    private static string GoalStatusToPersian(GoalStatus goalStatus)
    {
        return goalStatus switch
        {
            GoalStatus.Canceled => "لغو شده",
            GoalStatus.NotStarted => "شروع نشده",
            GoalStatus.Done => "انچام شده",
            GoalStatus.IsDoing => "در حال انچام",
            _ => throw new Exception("goal status no exist")
        };
    }

    public async Task AddGoalAsync(string userName, AddGoalVm addGoalViewModel)
    {
        var user = await GetUserByUserNameAsync(userName);
        var goal = new Goal
        {
            Title = addGoalViewModel.Title,
            User = user,
            DateAdded = DateTime.Now,
            GoalStatus = GoalStatus.NotStarted,
            DateCategory = PersianToCategory(addGoalViewModel.Category)
        };
        await _scheduleDbContext.Goals.AddAsync(goal);
        await _scheduleDbContext.SaveChangesAsync();
    }
    
    private DateCategory PersianToCategory(string persianCategory)
    {
        return persianCategory switch
        {
            "روزانه" => DateCategory.Daily,
            "هفتگی" => DateCategory.Weekly,
            "ماهانه" => DateCategory.Monthly,
            "فصلی" => DateCategory.Seasonly,
            "سالانه" => DateCategory.Yearly,
            "بلند مدت" => DateCategory.Decadly,
            "" => throw new NullReferenceException($"Category is empty. Category: {persianCategory}"),
            _ => throw new NullReferenceException($"Category is empty. Category: {persianCategory}")
        };
    }

    private async Task<User> GetUserByUserNameAsync(string userName)
    {
        var user = await _scheduleDbContext.Users.SingleAsync(user => user.Name == userName);
        return user;
    }
}