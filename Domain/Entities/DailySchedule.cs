using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class DailySchedule
{
    public int Id { get; set; }
    public DateTime LastModifiedTime { get; set; }

    public User User { get; set; }
    public List<ScheduleTask> ScheduleTasks { get; set; }
}