using System.Collections;

namespace TimeLibrary
{
    public class Class1
    {
        static Dictionary<int, string> months = new Dictionary<int, string>()
        {
            {1, "Января" },
            {2, "Февраля" },
            {3, "Марта" },
            {4, "Апреля" },
            {5, "Мая" },
            {6, "Июня" },
            {7, "Июля" },
            {8, "Августа" },
            {9, "Сентября" },
            {10, "Октября" },
            {11, "Ноября" },
            {12, "Декабря" },
        };

        public static string differenceDate(DateTime start, DateTime late)
        {
            string strResult = "";
            TimeSpan result = late - start;
            strResult += "Разница в днях: " + result.TotalDays + Environment.NewLine;
            strResult += "Разница в часах: " + result.TotalHours + Environment.NewLine;
            return strResult;
        }

        public static string leapYear(DateTime year)
        {
            if (year.Year % 100 == 0 &&  year.Year % 400 == 0)
            {
                return "Високосный";
            }
            else if (year.Year % 4 == 0 && year.Year % 100 != 0)
            {
                return "Високосный";
            }
            return "Невисокосный";
        }

        public static string leapYear(int year)
        {
            if (year % 100 == 0 && year % 400 == 0)
            {
                return "Високосный";
            }
            if (year % 4 == 0 && year % 100 != 0)
            {
                return "Високосный";
            }
            return "Невисокосный";
        }

        public static string Timeofday(DateTime time)
        {
            if(time.Hour >= 0 && time.Hour < 6)
            {
                return "Ночь";
            }
            else if(time.Hour >= 6 && time.Hour < 12)
            {
                return "Утро";
            }
            else if(time.Hour >= 12 && time.Hour < 18)
            {
                return "День";
            }
            else if(time.Hour >= 18 && time.Hour < 24)
            {
                return "Вечер";
            }
            return "Ошибка";
        }

        public static string Timeofday(int time)
        {
            if (time >= 0 && time < 6)
            {
                return "Ночь";
            }
            else if (time >= 6 && time < 12)
            {
                return "Утро";
            }
            else if (time >= 12 && time < 18)
            {
                return "День";
            }
            else if (time >= 18 && time < 24)
            {
                return "Вечер";
            }
            return "Ошибка";
        }

        public static string FormatDate(DateTime date, string format)
        {
            if (format == "D")
            {
                return $"{date.Day} {months[date.Month]} {date.Year} г.";
            }
            if (format == "d")
            {
                return $"{date.Day}.{date.Month}.{date.Year}";
            }
            if (format == "G")
            {
                return $"{date.Day}.{date.Month}.{date.Year} {date.Hour}:{date.Minute}:{date.Second}";
            }
            return "Ошибка";
        }
    }
}