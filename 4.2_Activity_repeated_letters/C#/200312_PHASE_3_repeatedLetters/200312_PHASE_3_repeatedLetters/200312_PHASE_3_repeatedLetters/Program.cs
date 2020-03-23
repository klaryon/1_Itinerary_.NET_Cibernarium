using System;
using System.Collections.Generic;

namespace _200312_PHASE_3_repeatedLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] RepeatLetter = { 'c', 'l', 'a', 'r', 'i', 's', 's', 'a', };

            List<char> NombreLista = new List<char>();

            for (int i = 0; i < RepeatLetter.Length; i++)
            {
                NombreLista.Add(RepeatLetter[i]);
            }

            Dictionary<char, int> NameDicc = new Dictionary<char, int>();

            foreach (var item in NombreLista)
            {

                if(!NameDicc.ContainsKey(item))
                {
                    NameDicc.Add(item, 1);
                }
                else
                {
                    NameDicc[item]++;
                }
            }

            foreach (var item in NameDicc)
            {
                Console.WriteLine(item);
            }
        }
    }
}

/* 
 Almacena en un Dictionary tanto las letras de la lista como el número  de veces que aparecen y muestra toda la información
*/