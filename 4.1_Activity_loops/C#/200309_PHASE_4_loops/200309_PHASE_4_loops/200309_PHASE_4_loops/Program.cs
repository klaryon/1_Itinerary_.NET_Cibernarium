using System;

namespace _200309_PHASE_4_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            var NombreCompleto = "Clarissa Maria Ardon";
            var DayBirth = "4/9/1986";
            var YearBirth = 1986;
            var mod400 = 400;
            var mod4 = 4;
            var mod100 = 100;
            var ResultLeap = "My year of birth IS a leap year!";
            var ResultNotLeap = "My year of birth is NOT a leap year :(";

            Console.WriteLine($"My name is {NombreCompleto}");
            Console.WriteLine($"I was born: {DayBirth}");

            if ((YearBirth % mod400 == 0) || ((YearBirth % mod4 == 0) && (YearBirth % mod100 != 0)))
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
