using TimeLibrary;

namespace TimeLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2000, 9, 18);
            DateTime date2 = new DateTime(2010, 9, 18);
            Console.WriteLine(TimeLibrary.Class1.differenceDate(date1, date2));

            Console.WriteLine(Class1.leapYear(new DateTime(2000, 12, 30)));
            Console.WriteLine(Class1.leapYear(new DateTime(1900, 12, 30)));

            Console.WriteLine(Class1.leapYear(2000));
            Console.WriteLine(Class1.leapYear(1900));

            Console.WriteLine(Class1.Timeofday(new DateTime(1900, 12, 31, 0, 0, 0))); //Ночь
            Console.WriteLine(Class1.Timeofday(new DateTime(1900, 12, 31, 2, 0, 0))); //Ночь
            Console.WriteLine(Class1.Timeofday(new DateTime(1900, 12, 31, 6, 0, 0))); //Утро
            Console.WriteLine(Class1.Timeofday(new DateTime(1900, 12, 31, 7, 0, 0))); //Утро
            Console.WriteLine(Class1.Timeofday(new DateTime(1900, 12, 31, 12, 0, 0))); //День
            Console.WriteLine(Class1.Timeofday(new DateTime(1900, 12, 31, 17, 0, 0))); //День
            Console.WriteLine(Class1.Timeofday(new DateTime(1900, 12, 31, 18, 0, 0))); //Вечер
            Console.WriteLine(Class1.Timeofday(new DateTime(1900, 12, 31))); //Ночь

            Console.WriteLine(Class1.FormatDate(new DateTime(), ""));
            Console.WriteLine(Class1.FormatDate(new DateTime(2000, 12, 31), ""));
            Console.WriteLine(Class1.FormatDate(new DateTime(2000, 12, 31), "D"));
            Console.WriteLine(Class1.FormatDate(new DateTime(2000, 12, 31), "d"));
            Console.WriteLine(Class1.FormatDate(new DateTime(2000, 12, 31), "G"));
        }
    }
}