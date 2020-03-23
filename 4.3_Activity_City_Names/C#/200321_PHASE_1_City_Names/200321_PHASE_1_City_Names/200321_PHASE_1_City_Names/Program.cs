using System;

namespace _200321_PHASE_1_City_Names
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

            Console.WriteLine("Ciudad 1: " + City1Bcn);
            Console.WriteLine("Ciudad 2: " + City2Mad);
            Console.WriteLine("Ciudad 3: " + City3Val);
            Console.WriteLine("Ciudad 4: " + City4Mal);
            Console.WriteLine("Ciudad 5: " + City5Cad);
            Console.WriteLine("Ciudad 6: " + City6Sant);
        }
    }
}

/*
 - Crea seis strings vacios.
 - Pide por consola que se introduzcan los nombres.
 - Introduce los siguientes nombres de ciudades (Barcelona, Madrid, Valencia, Malaga, Cadiz, Santander) por teclado.
 - Muestra por consola el nombre de las 6 ciudades. 
 */