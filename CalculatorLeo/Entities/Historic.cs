using System;
using System.Collections.Generic;
using System.Text;
using CalculatorLeo.Entities;


namespace TestCalculator.Entities
{
    public class Historic : Operation
    {
        public void HistoricShow()
        {
            Console.Clear();
            Console.WriteLine("###-calculation history--###\n");

            foreach (var item in operations)
            {
                Console.WriteLine(item.Num1 + item.Num2);
            }

            Console.Write("Press any key to return to the menu.");
            Console.ReadKey();

            Menu mn = new Menu();
            mn.ShowMenu();
        }
    }
}
