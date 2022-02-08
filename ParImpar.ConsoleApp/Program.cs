using System;

namespace ParImpar.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double n = Convert.ToDouble(Console.ReadLine());

            double resto = n % 2;

            if (resto == 0)
            {
                Console.WriteLine(n+" é Par");
            }
            else
            {
                Console.WriteLine(n+" é Impar");
            }
            Console.ReadLine();
        }
    }
}
