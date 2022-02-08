using System;

namespace SomaOrMultiplica.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            • Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B.
            //Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.

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
