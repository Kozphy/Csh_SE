using System;

namespace ConsoleApp2.practice.datetime_p
{
    public class datetime_start
    {
        public static void Start()
        {

            DateTime dateTime = new DateTime(2018, 10, 31);
            Console.WriteLine($"My birthday is {dateTime}");

            // write today on screen
            Console.WriteLine(DateTime.Today);
            // write current time on screen
            Console.WriteLine(DateTime.Now);

            DateTime tomorrow = GetTomorrow();
            System.Console.WriteLine($"Tomorrow will be the {tomorrow}");
            System.Console.WriteLine($"Today is {DateTime.Today.DayOfWeek}");

            System.Console.WriteLine($"{GetFirstDayOfYear(1999)}");

            GetDaysInMonth(2022,2);
            GetDaysInMonth(2021,2);
            GetDaysInMonth(2020,2);

            DateTime now = DateTime.Now;
            System.Console.WriteLine("Minute: {0}", now.Minute);

            System.Console.WriteLine($"{now.Hour} o'clock {now.Minute} minutes and {now.Second} seconds");

            System.Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            string? input = Console.ReadLine();

            DateTime datetime;
            if(DateTime.TryParse(input, out datetime))
            {
                System.Console.WriteLine(datetime);
                TimeSpan daysPassed = now.Subtract(datetime);
                System.Console.WriteLine($"Days passed since: {daysPassed.Days}");
            }
            else
            {
                System.Console.WriteLine("Wrong input");
            }
        }

        static void GetDaysInMonth(int year, int month)
        {
            int days = DateTime.DaysInMonth(year,month);
            System.Console.WriteLine($"Days in {year}/{month} is {days}");
        }
        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year,1,1);
        }
    }


}
