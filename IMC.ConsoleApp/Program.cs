using System;

namespace IMC.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Altura: ");
            double altura = Convert.ToDouble(Console.ReadLine()); 
            
            double imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do Peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Peso Normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Acima do Peso");
            }
            else
            {
                Console.WriteLine("Obeso");
            }
        }
    }
}
