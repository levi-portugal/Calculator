using CalculatorLeo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TestCalculator.Entities
{
    public class Menu : Operation
    {
        public void ShowMenu()
        {
            Console.Clear();
            Menu showMenu = new();

            Console.WriteLine("###-Virtual Calculator Menu-###\n");
            Console.WriteLine("Choose a feature\n");
            Console.WriteLine("New calc - enter 1 \nView Historic - enter 2 \nExit - enter 0 \n");

            int resposta = int.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 1:
                    Newcalc();
                    break;
                case 2:
                    Historic h = new Historic();
                    h.HistoricShow();
                    break;
                case 0:
                    Console.WriteLine("Until later!");
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("This option does not exist!");
                    break;
            }

        }
    }
}
