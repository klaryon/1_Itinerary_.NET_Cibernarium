using System;
using System.Collections.Generic;

namespace _200323_PHASE_2_Restaurant
{
    class Program
    {
        const int allMenus = 5;

        static void Main(string[] args)
        {
            var euro500 = 500;
            var euro200 = 200;
            var euro100 = 100;
            var euro50 = 50;
            var euro20 = 20;
            var euro10 = 10;
            var euro5 = 5;
            var euro2 = 2;
            var euro1 = 1;
            var totalPrice = 0;
            var contador = 1;
            var contador2 = 1; 
            var contador3 = 1;

            //Enter menu + menu price and saves them in each corresponding array.

            string[] arrayMenu = new string[allMenus];
            double[] arrayPriceMenu = new double[allMenus];

            for (int i = 0; i < allMenus; i++)
            {
                Console.WriteLine($"Enter menu {contador++} :");
                arrayMenu[i] = (Console.ReadLine()).ToLower();

                Console.WriteLine($"Enter price menu {contador2++} :");
                var priceMenu = Console.ReadLine();
                arrayPriceMenu[i] = double.Parse(priceMenu.Replace(".",","));
            }

            Console.Write("\n");

            //Prints menu + menu price in euros.

            for (int i = 0; i < allMenus; i++)
            {
                Console.WriteLine($"Menu {contador3++}: {arrayMenu[i]} = {arrayPriceMenu[i]} euros");
            }

            Console.Write("\n");

            //Asks which menu to order and saves it to a new List. It also asks if you want to keep ordering or not. 

            List<string> menuEatList = new List<string>();

            int newOrder = 1;

            while (newOrder == 1)
            {
                Console.WriteLine("Write the menu's name you want to eat: ");
                var menuNameEat = Console.ReadLine();
                menuEatList.Add(menuNameEat.ToLower());

                Console.WriteLine("Do you want to continue ordering? write 1 if yes or 2 if not: ");
                newOrder = int.Parse(Console.ReadLine());
            }
        }
    }
}

/*
 - Con un bucle  for llenaremos  los dos arrays  anteriormente creados. Añadiremos el nombre del plato y despues el precio.
 - Una vez llenos los dos arrays tenemos que mostrarlos y preguntar que se quiere para comer, guardaremos la información en 
   una List usando bucle while.
 - Tendremos que preguntar si se quiere seguir pidiendo comida. Podeis usar  el sistema (1:Si, 2:No), por tanto tendréis
   que crear otra variable int para guardar esa información.
 */
