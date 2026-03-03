using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CalculatorLeo.Entities
{
    internal class Historic
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int OperationCode { get; set; }
        public Operation OperationUsed { get; set; }
        public int Result { get; set; }
        public Historic(int num1, int num2, Operation operationUsed, int operationCode, int result)
        {
            Num1 = num1;
            Num2 = num2;
            OperationUsed = operationUsed;
            OperationCode = operationCode;
            Result = result;
        }

        public void HistoricView()
        {
            Console.WriteLine("Histórico: ");
            Console.WriteLine($"Operação numero {OperationCode}: \n");
            Console.WriteLine($"Numeros escolhidos: {Num1} e {Num2}");
            Console.WriteLine($"Operação escolhida: {OperationUsed}");
            Console.WriteLine($"Resultado: {Result}");
            Console.WriteLine("###################################");
        }

        
    }
}
