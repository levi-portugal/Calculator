using CalculatorLeo.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        //Menu.HomeMenu();

        Console.Write("How many calculations do you want to perform? ");
        int num = int.Parse(Console.ReadLine());


        for (int i = 1; i <= num; i++)
        {
            Console.Write($"Enter the first number digit of the account #{i}. ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write($"Enter the second number digit of the account #{i}. ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"What operation do you want to perform with the numbers? {num1} e {num2}?\n");
            Console.WriteLine("Sum - enter 1 \nSubtration - enter 2 \nMultiplication - enter 3 \nDivision - enter 4");
            int choice = int.Parse(Console.ReadLine());

            Operation calc = new Operation();

            switch (choice)
            {
                case 1:
                    int result = calc.Sum(num1, num2);
                    Console.WriteLine($"Your result is {result}");
                    break;
                case 2:
                    int result2 = calc.Subtration(num1, num2);
                    Console.WriteLine($"Your result is {result2}");
                    break;
                case 3:
                    int result3 = calc.Multiplication(num1, num2);
                    Console.WriteLine($"Your result is {result3}");
                    break;
                case 4:
                    int result4 = calc.Division(num1, num2);
                    Console.WriteLine($"Your result is {result4}");
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }
    }
}



//Console.WriteLine("Qual operação deseja realizar? ");
//Console.WriteLine("Soma digite 1 \nSubtração digite2 \nMultiplicação digite 3 \nDivisão digite 4");
//int choice = int.Parse(Console.ReadLine());

