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
            Console.WriteLine("###- Calculation History -###\n");

            //aqui ele verifica se a lista não está vazia
            if (operations.Count == 0)
            {
                Console.WriteLine("No records found.");
            }
            else
            {
                //se não tiver ele exiber todos os elementos da lista no formato de string
                foreach (string item in operations)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("\nPress any key to return to the menu.");
            Console.ReadKey();
            // Removi a chamada do menu que estava aqui pq acabava criando um outro fluxo alternativo sem querer
        }
    }
}