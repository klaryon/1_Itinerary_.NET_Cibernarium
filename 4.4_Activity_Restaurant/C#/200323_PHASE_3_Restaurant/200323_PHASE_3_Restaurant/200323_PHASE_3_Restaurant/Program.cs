using System;
using System.Collections.Generic;

namespace _200323_PHASE_3_Restaurant
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
            double totalPrice = 0;
            var contador = 1;
            var contador2 = 1;
            var contador3 = 1;

            //Enter menu + menu price (accepts only integers) and saves them in each corresponding array.

            string[] arrayMenu = new string[allMenus];
            double[] arrayPriceMenu = new double[allMenus];

            for (int i = 0; i < allMenus; i++)
            {
                Console.WriteLine($"Enter menu {contador++} :");
                arrayMenu[i] = (Console.ReadLine()).ToLower();

                Console.WriteLine($"Enter price menu {contador2++} :");
                var priceMenu = Console.ReadLine();
                arrayPriceMenu[i] = double.Parse(priceMenu.Replace(".", ",")); 
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

                Console.WriteLine("Do you want to continue to order? write 1 if yes or 2 if not: ");
                newOrder = int.Parse(Console.ReadLine());
            }

            //Compares the whole menu list with the menus chosen to buy and adds total price to pay.

            bool menuExist = false;

            foreach (var item in menuEatList)
            {
                for(var i = 0; i < arrayMenu.Length; i++) 
                { 
                    if (item == arrayMenu[i])
                    {
                        totalPrice += arrayPriceMenu[i];
                        menuExist = true;
                    }
                }

                if (!menuExist) 
                { 
                    Console.WriteLine("One of the menus you've entered doesn't exist, we will remove it from the order. ");
                }
                menuExist = false;
            }

            Console.Write("\n");
            Console.WriteLine($"Your total price is {totalPrice} euros");       
        }
    }
}

/*
 - Una vez hemos acabado de pedir comida, tendremos que comparar la lista con el array hecho al principio. 
 En el caso que la información introducida en la list coincida con la del array tendremos que sumar el precio  del producto
 pedido,  en caso contrario tendremos que mostrar un mensaje que  diga que la comida que hemos pedido no existe en el menú.
 */
