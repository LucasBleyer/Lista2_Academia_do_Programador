using System;

namespace SomaOrMultiplica.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = 0;

            if (a == b)
            {
                c = a + b;
                Console.WriteLine(a+"+"+b+"="+c);
            }
            else
            { 
                c = a * b;
                Console.WriteLine(a+"*"+b+"="+c);
            }
            Console.ReadLine();
        }
    }
}
