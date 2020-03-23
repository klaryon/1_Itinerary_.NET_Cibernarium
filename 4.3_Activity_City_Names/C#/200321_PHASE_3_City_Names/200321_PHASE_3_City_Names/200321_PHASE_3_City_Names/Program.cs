using System;

namespace _200321_PHASE_3_City_Names
{
    class Program
    {
        const int AllCities = 6;

        static void Main(string[] args)
        {
            string City1Bcn = " ";
            string City2Mad = " ";
            string City3Val = " ";
            string City4Mal = " ";
            string City5Cad = " ";
            string City6Sant = " ";

            string[] ArrayCitiesModified = new string[AllCities];

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

            ArrayCitiesModified[0] = City1Bcn.Replace('a', '4');
            ArrayCitiesModified[1] = City2Mad.Replace('a', '4');
            ArrayCitiesModified[2] = City3Val.Replace('a', '4');
            ArrayCitiesModified[3] = City4Mal.Replace('a', '4');
            ArrayCitiesModified[4] = City5Cad.Replace('a', '4');
            ArrayCitiesModified[5] = City6Sant.Replace('a', '4');

            Console.WriteLine("All cities in alphabetical order: ");

            Array.Sort(ArrayCitiesModified);

            for (int i = 0; i < AllCities; i++)
            {
                Console.WriteLine(ArrayCitiesModified[i]);
            }
        }
    }
}
    
/*
 - Cambiar las vocales "a" de los nombres de las ciudades por el número 4 y guardar los nombres
    modificados en un nuevo array (ArrayCiudadesModificadas).
 - Mostrar por consola el array modificado y ordenado. 
 */