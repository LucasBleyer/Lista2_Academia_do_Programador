using System;

namespace OrdemDecrescente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valor = new int[3];
            int maior = 0;
            int menor = 999999999;
            int meio = 1;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Digite um valor na posição " +i+": ");
                valor[i] = Convert.ToInt32(Console.ReadLine());

                if (valor[i] > maior)
                {
                    maior = valor[i];
                }
                else
                {
                    menor = valor[i];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (valor[i] > menor && valor[i] < maior)
                {
                    meio = valor[i];
                }
            }
            Console.WriteLine("Ordem Decrescente: " + maior + " " + meio + " " + menor);
            Console.ReadLine();
        }
    }
}
