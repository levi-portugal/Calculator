using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLeo.Entities
{
    public class Operation
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }


        public int Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public int Subtration(int num1, int num2)
        {
            int sum = num1 - num2;
            return sum;
        }

        public int Multiplication(int num1, int num2)
        {
            int mult = num1 * num2;
            return mult;
        }

        public int Division(int num1, int num2)
        {
            int div = num1 / num2;
            return div;
        }
    }
}
