using System;
using System.Linq;

namespace _200401_PHASE_3_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[] { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            var numQuery =
            from num in arrayNumbers
            where num > 5
            select num;

            var numQuery2 =
            from num in arrayNumbers
            where num < 5
            select num;
            
            foreach (int num in numQuery) 
            {
                Console.WriteLine(num); // prints numbers bigger than 5 in arrayNumbers.
            }

            Console.Write("\n");

            foreach (int num in numQuery2) 
            {
                Console.WriteLine(num); // prints numbers lower than 5 in arrayNumbers.
            }
        }
    }
}

/*
 	Fent una consulta linq guardeu en un array quins numero son mes grans que 5 i en un altre array quins son mes petits. (1,5 punts)
    Mostreu per console els dos arrays. (1 punt)
*/