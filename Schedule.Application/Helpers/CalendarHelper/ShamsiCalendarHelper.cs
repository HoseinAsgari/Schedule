using System;
using System.Globalization;
using System.Threading.Tasks;

namespace Schedule.Application.Helpers.CalendarHelper
{
    public static class ShamsiCalendarHelper
    {
        public static Task<string> ToShamsi(DateTime date)
        {
            return Task.Run(() =>
            {
                var persianCalendar = new PersianCalendar();
                return persianCalendar.GetYear(date) + "/" + persianCalendar.GetMonth(date).ToString("00") + "/" + persianCalendar.GetDayOfMonth(date).ToString("00");
            });
        }

        public static Task<string> MiladiMonthNumToShamsiMonthName(this int miladiMonthNumber)
        {
            return Task.Run(() =>
            {
                return miladiMonthNumber switch
                {
                    1 => "دی",
                    2 => "بهمن",
                    3 => "اسفند",
                    4 => "فروردین",
                    5 => "اردیبهشت",
                    6 => "خرداد",
                    7 => "تیر",
                    8 => "مرداد",
                    9 => "شهریور",
                    10 => "مهر",
                    11 => "آبان",
                    12 => "آذر",
                    _ => null,
                };
            });
        }

        public static async Task<string> ToShamsiWithTime(this DateTime date)
        {
            string shamsiDate = await ToShamsi(date);
            return await Task.Run(() =>
            {
                shamsiDate += "  " + date.Hour.ToString("00") + ":" + date.Minute.ToString("00");
                return shamsiDate;
            });
        }
    }
}
