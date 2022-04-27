using System;
using System.Globalization;
using System.Threading.Tasks;

namespace Application.Helpers.CalendarHelper
{
    public static class ShamsiCalendarHelper
    {
        public static string ToShamsi(this DateTime date)
        {
            var persianCalendar = new PersianCalendar();
            return persianCalendar.GetYear(date) + "/"
                + persianCalendar.GetMonth(date).ToString("00") + "/"
                + persianCalendar.GetDayOfMonth(date).ToString("00");

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

        public static string ToShamsiWithTime(this DateTime date)
        {
            string shamsiDate = date.ToShamsi();
            shamsiDate += "  " + date.Hour.ToString("00") + ":" + date.Minute.ToString("00");
            return shamsiDate;
        }
    }
}
