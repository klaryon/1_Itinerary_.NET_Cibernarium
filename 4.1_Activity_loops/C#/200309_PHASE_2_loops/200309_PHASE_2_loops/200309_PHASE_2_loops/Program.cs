using System;

namespace _200309_PHASE_2_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            var YearBirth = 1986;
            var LeapYear = 1948;
            var EachLeapYear = 4;
            var TotalLeapYear = (int)((YearBirth - LeapYear) / EachLeapYear);

            Console.WriteLine($"Total amount of leap years between 1948 and my birth year: {TotalLeapYear} years");
        }
    }
}
