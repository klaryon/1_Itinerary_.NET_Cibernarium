using System;
using System.Linq;

namespace _200401_PHASE_1_Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayNumbers = new int[] { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            var numQuery =
            from num in arrayNumbers
            where (num % 2) == 0
            select num;

            foreach (int num in numQuery)
            {
                Console.WriteLine(num); // prints even numbers in arrayNumbers. 
            }
        }
    }
}

/* 
 	Creeu un array amb els números donats al principi de la práctica.
	Fent servir consultes linq guardeu en un array tots els números parells. 
	Mostreu l’array de números parells per consola. 
*/
