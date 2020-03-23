using System;

namespace _200309_PHASE_3_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            var YearBirth = 1986;
            var LeapYear = 1948;
            var Mod400 = 400;
            var Mod4 = 4;
            var Mod100 = 100;
            var CheckLeapYear = false;
            var ResultLeap = "My year of birth IS a leap year!";
            var ResultNotLeap = "My year of birth is NOT a leap year :(";

            for (var Year = LeapYear; Year <= YearBirth; Year++)
            {
                if ((Year % Mod400 == 0) || ((Year % Mod4 == 0) && (Year % Mod100 != 0)))
                {
                    Console.WriteLine(Year);
                    if (YearBirth == Year)
                    {
                        CheckLeapYear = true;
                    }
                }
            }

            if (CheckLeapYear == true)
            {
                Console.WriteLine(ResultLeap);
            }
            else
            {
                Console.WriteLine(ResultNotLeap);
            }
        }
    }
}
