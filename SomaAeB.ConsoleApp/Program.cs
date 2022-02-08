using System;

namespace SomaAeB.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine("--------------------------------------");
                Console.Write("Digite o valor de A: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o valor de B: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o valor de C: ");
                double c = Convert.ToDouble(Console.ReadLine());

                double soma = a + b;

                if (soma > c)
                {
                    Console.WriteLine("A soma de A + B é "+soma+" que é maior do que o valor de C");
                }
                else if (soma == c)
                {
                    Console.WriteLine("A soma de A + B é "+soma+" que é igual ao valor de C");
                }
                else
                {
                    Console.WriteLine("A soma de A + B é "+soma+" que é menor que o valor de C");
                }

                Console.Write(" [Enter] para continuar ou [s] para Sair: ");
                opcao = Console.ReadLine();

            } while (opcao != "s");

            
            Console.ReadLine();
        }
    }
}
