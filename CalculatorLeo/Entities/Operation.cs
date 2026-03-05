using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Channels;
using TestCalculator.Entities;

namespace CalculatorLeo.Entities
{
    public class Operation
    {
        public List<Operation> operations = new List<Operation>();

        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public double Sum(double num1, double num2)
        {
            double sum = num1 + num2;
            return sum;
        }

        public double Subtration(double num1, double num2)
        {
            double sum = num1 - num2;
            return sum;
        }

        public double Multiplication(double num1, double num2)
        {
            double mult = num1 * num2;
            return mult;
        }

        public double Division(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("You cannot divide by zero.");
            }
            double div = num1 / num2;
            return div;
        }

        public void Newcalc()
        {
            Console.Clear();
            Console.WriteLine("###-New calc-###");
            //Console.Write("\nHow many calculations do you want to perform? ");
            //int num = int.Parse(Console.ReadLine());
            double num1;
            double num2;
            // for (int i = 1; i <= num; i++)
            //{
            while (true)
            {
                Console.Write($"\nEnter the first number digit of the account. ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write($"Enter the second number digit of the account. \n");
                num2 = double.Parse(Console.ReadLine());

                Console.WriteLine($"What operation do you want to perform with the numbers? {num1} e {num2}?\n");
                Console.WriteLine("Sum - enter 1 \nSubtration - enter 2 \nMultiplication - enter 3 \nDivision - enter 4");
                int choice = int.Parse(Console.ReadLine());

                Operation calc = new Operation();

                switch (choice)
                {
                    case 1:
                        double result = calc.Sum(num1, num2);
                        Console.WriteLine($"Your result is {result}");
                        break;
                    case 2:
                        double result2 = calc.Subtration(num1, num2);
                        Console.WriteLine($"Your result is {result2}");
                        break;
                    case 3:
                        double result3 = calc.Multiplication(num1, num2);
                        Console.WriteLine($"Your result is {result3}");
                        break;
                    case 4:
                        double result4 = calc.Division(num1, num2);
                        Console.WriteLine($"Your result is {result4}", CultureInfo.InvariantCulture);
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;

                }

                Console.Write("\nDo you want to perform a new calculation? (y/n) ");
                char input = char.Parse(Console.ReadLine());

                if (input == 'y' || input == 'Y')
                {
                    continue;
                }
                else
                {
                    Menu menu = new Menu();
                    menu.ShowMenu();
                }
            }
        }

    }
}
