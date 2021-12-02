using System;

namespace Application.Helpers.CalendarHelper
{
    public static class TimeHelper
    {
        public static string GetTimeFromPartOfDay(int partOfDay)
        {
            return new DateTime().AddMinutes(30 * partOfDay).ToShortTimeString();
        }
    }
}