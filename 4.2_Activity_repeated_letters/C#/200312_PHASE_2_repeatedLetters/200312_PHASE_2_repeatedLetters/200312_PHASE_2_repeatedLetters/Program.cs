using System;
using System.Collections.Generic;

namespace _200312_PHASE_2_repeatedLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] NameLetter = { 'c', 'l', 'a', 'r', 'i', 's', 's', 'a', }; 
            List<char> NameList = new List<char>();

            for (int i = 0; i < NameLetter.Length; i++)
            {
                NameList.Add(NameLetter[i]);
            }

            foreach (var i in NameList)
            {
                switch(i)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine($"Letter {i} is a Vowel");
                        break;

                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        Console.WriteLine($"Letter {i} is a number, and people's name don't have numbers!");
                        break;

                    default:
                        Console.WriteLine($"Letter {i} is a Consonant");
                        break;
                }
            }
        }
    }
}

/*
 - Cambia el array por una (List).
 - En el bucle, si la letra es una vocal imprime por consola: 'VOCAL'. Sino, imprime 'CONSONANTE'. 
 - Si encuentras un número, muestra por consola: 'Los nombres de personas no contienen números!.'. 
 */