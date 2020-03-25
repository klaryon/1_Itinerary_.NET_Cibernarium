using System;
using System.Collections.Generic;

namespace _200323_PHASE_4_Restaurant
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
            int totalPrice = 0; // only works with integers
            var contador = 1;
            var contador2 = 1;
            var contador3 = 1;

            //Enter menu + menu price (no doubles accepted, only integers) and saves them in each corresponding array.

            string[] arrayMenu = new string[allMenus];
            int[] arrayPriceMenu = new int[allMenus]; // only works with integers

            for (int i = 0; i < allMenus; i++)
            {
                Console.WriteLine($"Enter menu {contador++} :");
                arrayMenu[i] = (Console.ReadLine()).ToLower();

                Console.WriteLine($"Enter price menu {contador2++} :");
                var priceMenu = Console.ReadLine();
                arrayPriceMenu[i] = int.Parse(priceMenu);
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
                for (var i = 0; i < arrayMenu.Length; i++)
                {
                    if (item == arrayMenu[i])
                    {
                        totalPrice += arrayPriceMenu[i];
                        menuExist = true;
                    }
                }

                if (!menuExist)
                {
                    Console.WriteLine("One of the menus you've entered doesn't exist, we will remove it from the order.");
                }
                menuExist = false;
            }

            Console.Write("\n");
            Console.WriteLine($"Your total price is {totalPrice} euros");
            Console.Write("\n");

            //Indicate the amount of change to give back (indicate both bills and coins (just 1 or 2 euro). 

            bool moneyExist = false;

            int[] arrayMoney = new int[9];

            arrayMoney[0] = euro500;
            arrayMoney[1] = euro200;
            arrayMoney[2] = euro100;
            arrayMoney[3] = euro50;
            arrayMoney[4] = euro20;
            arrayMoney[5] = euro10;
            arrayMoney[6] = euro5;
            arrayMoney[7] = euro2;
            arrayMoney[8] = euro1;

            for (int i = 0; i < arrayMoney.Length; i++)
            {
                if ((totalPrice / arrayMoney[i]) > 0)
                {
                    moneyExist = true;
                }

                if (moneyExist)
                {
                    int divMoney = (totalPrice / arrayMoney[i]);

                    if (arrayMoney[i] > 2)
                    {
                        Console.WriteLine($"Your payment is {divMoney} bill(s) of {arrayMoney[i]} euros");
                    }
                    else
                    {
                        Console.WriteLine($"Your payment is {divMoney} coin(s) of {arrayMoney[i]} euros");
                    }

                    var modulusMoney = (totalPrice % arrayMoney[i]);
                    totalPrice = modulusMoney;
                }
            }
        }
    }
}

/*
    Una vez sabemos el precio final de nuestra comida tendremos que mostrar  cuantos billetes
    necesitará el cliente para pagar. En el caso  que el precio no sea múltiplo de 5 por ejemplo 27
    lo podéis hacer de dos maneras. Podéis calcular cuántos billetes necesitaría para pagar 30 euros y el cambio  
    en monedas que se le daría o bien calcular cuántos billetes necesitaría para pagar 25 euros y cuántas monedas
    necesitaría de 1 a 2 euros. 
 */
