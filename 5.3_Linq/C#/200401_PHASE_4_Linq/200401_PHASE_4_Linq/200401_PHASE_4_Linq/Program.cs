using System;
using System.Linq;

namespace _200401_PHASE_4_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayNames = new string[] { "David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol" };

            var starOName = arrayNames.Where(arrayNames => arrayNames.StartsWith("O"));

            foreach (string name in starOName)
            {
                Console.WriteLine(name); // prints all names that start with an "O".
            }

            Console.WriteLine('\n');

            var countSixArray = arrayNames.Where(arrayNames => arrayNames.Length >= 6);

            foreach (string name in countSixArray)
            {
                Console.WriteLine(name); // prints all names that have more than 6 letters.
            }

            Console.WriteLine('\n');

            var sortedArray = arrayNames.OrderByDescending(x => x);

            foreach (string name in sortedArray)
            {
                Console.WriteLine(name); // prints all names in descending order. 
            }
        }
    }
}

/*
    En aquesta fase farem servir un array amb noms: (David, Sergio, Maria, Laura, Oscar, Julia, Oriol)
    Creeu un array amb els noms de l’enunciat.
    Fent servir consultes linq mostreu per consola els noms que comencin amb la lletra “O”. 
    Fent servir consultes linq mostreu per consola quins noms tenen més de 6 lletres. 
    Fent servir consultes linq mostreu per consola els noms de l’array ordenats de manera descendent.        
*/