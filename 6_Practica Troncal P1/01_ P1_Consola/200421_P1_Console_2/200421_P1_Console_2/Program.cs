using System;
using System.Collections.Generic;
using System.Linq;

namespace _200421_P1_Console_2
{
    class Program
    {
        static string CurrentOption { get; set; }

        static List<double> Marks { get; set; }

        static void Main(string[] args)
        {
            Marks = new List<double>();

            Console.WriteLine("Welcome to the Class Management Program");
            ShowMainMenu();

            while (true)
            {
                var option = Console.ReadKey().KeyChar;

                if (option == 'm')
                {
                    ClearCurrentConsoleLine();
                    if (CurrentOption != "m")
                    {
                        Console.WriteLine();
                        ShowMainMenu();
                    }
                }
                else if (option == 'n')
                {
                    ClearCurrentConsoleLine();
                    if (CurrentOption != "n")
                    {
                        Console.WriteLine();
                        ShowAddNotesMenu();
                    }
                }
                else if (option == 'c')
                {
                    ClearCurrentConsoleLine();
                    if (CurrentOption != "c")
                    {
                        Console.WriteLine();
                        ShowStatisticsMenu();
                    }
                }
            }
        }

        static void ShowMainMenu()
        {
            CurrentOption = "m";
            Console.WriteLine("Main Menu");

            Console.WriteLine("Option: m - Back to main menu");
            Console.WriteLine("Option: n - Add students grades");
            Console.WriteLine("Option: c - Stadistics");
        }

        static void ShowAddNotesMenu()
        {
            CurrentOption = "n";
            Console.WriteLine("Add students grades menu");
            Console.WriteLine("Add grades and press enter");
            Console.WriteLine("Press m to end and go back to main menu");

            while (true)
            {
                var notaText = Console.ReadLine();

                if (notaText == "m")
                {
                    break;
                }
                else
                {
                    double nota;
                    if (double.TryParse(notaText.Replace(".", ","), out nota))
                    {
                        Marks.Add(nota);
                    }
                    else
                    {
                        Console.WriteLine($"valor introducido [{notaText}] no válido");
                    }
                }
            }

            ClearCurrentConsoleLine();
            Console.WriteLine();
            ShowMainMenu();
        }

        static void ShowStatisticsMenu()
        {
            CurrentOption = "c";

            Console.WriteLine("Stadistics Options");
            Console.WriteLine("Press m to finish and go back to main menu");
            Console.WriteLine("Option: avg - get the average student grade");
            Console.WriteLine("Option: max - get the maximum student grade");
            Console.WriteLine("Option: min - get the minimum student grade");

            while (true)
            {
                var optionText = Console.ReadLine();

                if (optionText == "m")
                {
                    break;
                }
                else if (optionText == "avg")
                {
                    ShowAverage();
                }
                else if (optionText == "min")
                {
                    ShowMinimum();
                }
                else if (optionText == "max")
                {
                    ShowMaximum();
                }
            }

            ClearCurrentConsoleLine();
            Console.WriteLine();
            ShowMainMenu();
        }

        static void ShowAverage()
        {
            //var avg = GetAverage();
            Console.WriteLine($"Actual average score is: {Marks.Average()}");
            Console.WriteLine();
        }

        static void ShowMinimum()
        {
            Console.WriteLine($"Minimum grade is: {Marks.Min()}");
            Console.WriteLine();
        }

        static void ShowMaximum()
        {
            Console.WriteLine($"Maximum grade is: {Marks.Max()}");
            Console.WriteLine();
        }     

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        #region Formulas

        public static double GetAverage()
        {
            var sum = 0.0;

            for (var i = 0; i < Marks.Count; i++)
            {
                sum += Marks[i];
            }

            return sum / Marks.Count;
        }

        #endregion
    }
}
