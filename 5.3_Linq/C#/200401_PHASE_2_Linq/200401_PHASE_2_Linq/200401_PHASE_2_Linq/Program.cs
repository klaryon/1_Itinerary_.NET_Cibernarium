using System;
using System.Linq;

namespace _200401_PHASE_2_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[] { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            var minNum = arrayNumbers.Min();
            var maxNum = arrayNumbers.Max();
            var avgNum = arrayNumbers.Average();

            Console.WriteLine(minNum); // prints minimum number of arrayNumbers.
            Console.WriteLine(maxNum); // prints maximum number of arrayNumbers.
            Console.WriteLine(avgNum); // prints average number of arrayNumbers.

        }
    }
}

/* 
 	Calculeu a partir de l’array anterior la nota mitjana, la máxima i la mínima. 
	Mostreu per consola els resultats.
    Video: https://www.youtube.com/watch?v=JNeFB_2YHrc
*/
