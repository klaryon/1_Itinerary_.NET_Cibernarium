using System;

namespace _200321_PHASE_4_City_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string City1Bcn = " ";
            string City2Mad = " ";
            string City3Val = " ";
            string City4Mal = " ";
            string City5Cad = " ";
            string City6Sant = " ";

            Console.WriteLine("Enter city name: ");
            City1Bcn = Console.ReadLine();
            Console.WriteLine("Enter city name: ");
            City2Mad = Console.ReadLine();
            Console.WriteLine("Enter city name: ");
            City3Val = Console.ReadLine();
            Console.WriteLine("Enter city name: ");
            City4Mal = Console.ReadLine();
            Console.WriteLine("Enter city name: ");
            City5Cad = Console.ReadLine();
            Console.WriteLine("Enter city name: ");
            City6Sant = Console.ReadLine();
            Console.Write("\n");

            string[] ArrayBcn = new string[City1Bcn.Length];
            string[] ArrayMad = new string[City2Mad.Length];
            string[] ArrayVal = new string[City3Val.Length];
            string[] ArrayMal = new string[City4Mal.Length];
            string[] ArrayCad = new string[City5Cad.Length];
            string[] ArraySant = new string[City6Sant.Length];

            Console.WriteLine("All cities inversed: ");
            Console.WriteLine("\n");

            for (int i = 0; i < City1Bcn.Length; i++)
            {
                ArrayBcn[i] = City1Bcn.Substring(i, 1);
            }

            Array.Reverse(ArrayBcn);

            for (int i = 0; i < ArrayBcn.Length; i++)
            {
                Console.WriteLine(ArrayBcn[i]);
            }

            Console.WriteLine("\n");

            for (int i = 0; i < City2Mad.Length; i++)
            {
                ArrayMad[i] = City2Mad.Substring(i, 1);
            }

            Array.Reverse(ArrayMad);

            for (int i = 0; i < ArrayMad.Length; i++)
            {
                Console.WriteLine(ArrayMad[i]);
            }

            Console.WriteLine("\n");

            for (int i = 0; i < City3Val.Length; i++)
            {
                ArrayVal[i] = City3Val.Substring(i, 1);
            }

            Array.Reverse(ArrayVal);

            for (int i = 0; i < ArrayVal.Length; i++)
            {
                Console.WriteLine(ArrayVal[i]);
            }

            Console.WriteLine("\n");

            for (int i = 0; i < City4Mal.Length; i++)
            {
                ArrayMal[i] = City4Mal.Substring(i, 1);
            }

            Array.Reverse(ArrayMal);

            for (int i = 0; i < ArrayMal.Length; i++)
            {
                Console.WriteLine(ArrayMal[i]);
            }

            Console.WriteLine("\n");

            for (int i = 0; i < City5Cad.Length; i++)
            {
                ArrayCad[i] = City5Cad.Substring(i, 1);
            }

            Array.Reverse(ArrayCad);

            for (int i = 0; i < ArrayCad.Length; i++)
            {
                Console.WriteLine(ArrayCad[i]);
            }

            Console.WriteLine("\n");

            for (int i = 0; i < City6Sant.Length; i++)
            {
                ArraySant[i] = City6Sant.Substring(i, 1);
            }

            Array.Reverse(ArraySant);

            for (int i = 0; i < ArraySant.Length; i++)
            {
                Console.WriteLine(ArraySant[i]);
            }

        }
    }
}

/*
 - Crear un nuevo array por cada una de las ciudades que tenemos. El tamaño de los nuevos
   arrays será igual a la longitud de cada string de ciudad. (string nombreCiutat.Length).
 - Llenar cada posición del array con una letra.
 - Mostrar por consola los arrays con los nombres invertidos (Ex: Barcelona - anolecraB).

    OTRA MANERA:

    for (int i = City1Bcn.Length - 1; i >= 0; i--)
            {
                ArrayBcn[i] = City1Bcn.Substring(i, 1);
            }

            for (int i = City1Bcn.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(ArrayBcn[i]);
            }
 */
