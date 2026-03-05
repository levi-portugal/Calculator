namespace CalculatorLeo.Entities
{
    public class Operation
    {
        // 'static' faz com que todas as classes acessem a MESMA lista na memória
        //não estava conseguindo ver o histórico pq alista não era static
        public static List<string> operations = new List<string>();

        public double Sum(double n1, double n2) => n1 + n2;
        public double Subtration(double n1, double n2) => n1 - n2;
        public double Multiplication(double n1, double n2) => n1 * n2;
        public double Division(double n1, double n2) => n2 != 0 ? n1 / n2 : throw new DivideByZeroException(); //Tive bastante dificuldade pra fazer a verificação,
                                                                                                               //provavelmente preciso estudar mais sobre isso até fixar
        public void Newcalc()
        {
            //condição pra manter o while como verdadeiro ate o usuario querer parar
            bool keepCalculating = true;

            while (keepCalculating)
            {
                Console.Clear();
                Console.WriteLine("###- New calc -###");

                double num1;
                double num2;
                try
                {
                    Console.Write("Enter the first number: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    num2 = double.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"\nErro: {ex.Message}"); // Exibe "Não é possível dividir por zero."
                    Console.WriteLine("Press any key to try another number.");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine("\n1-Sum | 2-Subtration | 3-Multiplication | 4-Division");
                int choice = int.Parse(Console.ReadLine());

                double result = 0;
                string opSymbol = "";

                switch (choice)
                {
                    //troquei as funções normais pra arrow functions
                    case 1: result = Sum(num1, num2); opSymbol = "+"; break;
                    case 2: result = Subtration(num1, num2); opSymbol = "-"; break;
                    case 3: result = Multiplication(num1, num2); opSymbol = "*"; break;
                    case 4:
                        try
                        {
                            result = Division(num1, num2); // Tenta calcular
                            opSymbol = "/";
                        }
                        catch (DivideByZeroException ex)
                        {
                            // Se o erro de divisão por zero ocorrer, caimos aqui
                            Console.WriteLine($"\nErro: {ex.Message}"); // Exibe "Não é possível dividir por zero."
                            Console.WriteLine("Press any key to try another number.");
                            Console.ReadKey();
                            continue; // Volta para o início do while para pedir novos números
                        }
                        break;
                    // result = Division(num1, num2); opSymbol = "/"; break;
                    default: Console.WriteLine("Invalid!"); continue;
                }
                // EXIBE E SALVA NO HISTÓRICO
                string calculationEntry = $"{num1} {opSymbol} {num2} = {result}";
                Console.WriteLine($"\nYour result: {calculationEntry}");
                operations.Add(calculationEntry);

                Console.Write("\nDo you want to perform a new calculation? (y/n): ");
                string resp = Console.ReadLine().ToLower(); // esse Tolower pega a resposta e converte pra minusculo,
                                                            // o que evita de usar um if
                if (resp != "y")
                {
                    keepCalculating = false; // Sai do loop e volta naturalmente para quem chamou (Menu),
                                             // tive dificuldade com a questão de fluxo correto de voltar para o menu,
                                             // que não me deixava salvar no histórico
                }
            }
        }
    }
}