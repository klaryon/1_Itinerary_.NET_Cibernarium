using System;

namespace _200309_PHASE_1_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            var Nombre = "Clarissa";
            var LastName1 = "Ardon";
            var LastName2 = "Carballo";
            var Day = 4;
            var Month = 9;
            var Year = 1986;

            Console.WriteLine($"My name is {Nombre} {LastName1} {LastName2}");
            Console.WriteLine($"I was born: {Day}/{Month}/{Year}");

            /*
            Console.WriteLine(nombre + " " + lastname1 + " " + lastname2);
            Console.WriteLine(day + "/" + month + "/" + year);
            */
        }
    }
}
