using System;

namespace _200312_PHASE_1_repeatedLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] Name = { 'c', 'l', 'a', 'r', 'i', 's', 's', 'a', };
            for (int i = 0; i < Name.Length; i++)
            {
                Console.WriteLine(Name[i]);
            }
        }
    }
}

/* 
 - Crea un array de caracteres (char[]) con tu nombre donde cada posición corresponderá a una letra.
 - Haz un bucle que recorra el array y muestre por consola cada una de las letras. 
*/
