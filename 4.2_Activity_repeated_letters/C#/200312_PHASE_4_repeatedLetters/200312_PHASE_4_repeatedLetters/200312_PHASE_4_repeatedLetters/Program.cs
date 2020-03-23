using System;
using System.Collections.Generic;

namespace _200312_PHASE_4_repeatedLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] NameLetter = { 'c', 'l', 'a', 'r', 'i', 's', 's', 'a', }; 
            char[] SurnameLetter = { 'a', 'r', 'd', 'o', 'n' };

            List<char> NameList = new List<char>();
            List<char> SurNameList = new List<char>();
            List<char> FullNameList = new List<char>();

            for (int i = 0; i < NameLetter.Length; i++)
            {
                NameList.Add(NameLetter[i]);
            }

            for (int i = 0; i < SurnameLetter.Length; i++)
            {
                SurNameList.Add(SurnameLetter[i]);
            }

            FullNameList.AddRange(NameList);
            FullNameList.Add(' ');
            FullNameList.AddRange(SurNameList);

            foreach (var letter in FullNameList)
            {
                Console.WriteLine(letter);
            }
        }
    }
}

/*
 - Crea otra lista con tu apellido donde cada posición corresponderá a una letra.
 - Fusiona las dos listas en una sola. Además, añade una posición vacía entre la primera y la segunda.
   Es decir, partimos de la lista name y surname y al acabar  solo tendremos  una lista  que se llamará fullname. 
   Full Name: ['N','A','M','E','','S','U','R','N','A','M','E']

   OTRA FORMA:
     char[] NameLetter = { 'c', 'l', 'a', 'r', 'i', 's', 's', 'a', }; 
            char[] SurnameLetter = { 'a', 'r', 'd', 'o', 'n' };
            char[] FullNameLetter = { 'c', 'l', 'a', 'r', 'i', 's', 's', 'a', ' ', 'a', 'r', 'd', 'o', 'n' };

            List<char> FullNameLista = new List<char>();

            for (int i = 0; i < FullNameLetter.Length; i++)
            {
                FullNameLista.Add(FullNameLetter[i]);
            } 

            foreach (var letter in FullNameLista)
            {
                Console.WriteLine(letter);
            }
*/
