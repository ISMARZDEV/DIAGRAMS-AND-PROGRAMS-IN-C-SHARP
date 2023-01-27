using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double BaseMayor, BaseMenor, Altura;
            double areaTrapecio;

            Console.Write("Digite la Base Mayor: ");
            BaseMayor = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite la Base Menor: ");
            BaseMenor = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite la Altura: ");
            Altura = Convert.ToDouble(Console.ReadLine());

            areaTrapecio = (BaseMayor + BaseMenor) * Altura / 2;

            Console.WriteLine("El área del Trapecio es ({0} + {1}) x {2} / 2 = {3:N2}cm²", BaseMayor, BaseMenor, Altura, areaTrapecio);
            
        }
    }
}
