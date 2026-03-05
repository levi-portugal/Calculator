using CalculatorLeo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TestCalculator.Entities
{
    public class Menu
    {
        public void ShowMenu()
        {
            while (true) // Mantém o menu vivo
            {
                Console.Clear();
                Console.WriteLine("###- Virtual Calculator Menu -###\n");
                Console.WriteLine("Choose a feature\n");

                Console.WriteLine("1 - New calc\n2 - View Historic\n0 - Exit\n");

                int resposta = int.Parse(Console.ReadLine());
                //oi
                switch (resposta)
                {
                    case 1:
                        new Operation().Newcalc();
                        break;
                    case 2:
                        new Historic().HistoricShow();
                        break;
                    case 0:
                        Console.WriteLine("Until later!");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}