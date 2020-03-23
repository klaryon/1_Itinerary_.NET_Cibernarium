using System;

namespace _200321_PHASE_2_City_Names
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

            string[] ArrayCities = new string[AllCities];

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

            ArrayCities[0] = City1Bcn;
            ArrayCities[1] = City2Mad;
            ArrayCities[2] = City3Val;
            ArrayCities[3] = City4Mal;
            ArrayCities[4] = City5Cad;
            ArrayCities[5] = City6Sant;

            Console.WriteLine("All cities in alphabetical order: ");

            Array.Sort(ArrayCities);

            for (int i = 0; i < AllCities; i++)
            {
                Console.WriteLine(ArrayCities[i]);
            }
        }
    }
}

/*
 - Una vez tenemos los nombres guardados en variables tenemos que pasar la información a un array (arrayCiudades).
 - Mostrar por consola el nombre de las ciudades ordenadas alfabéticamente.
 */