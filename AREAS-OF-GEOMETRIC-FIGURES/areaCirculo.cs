using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado1, lado2;
            int areaCuadrado;

            Console.Write("Digite el Lado #1: ");
            lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite el Lado #2: ");
            lado2 = Convert.ToInt32(Console.ReadLine());

            areaCuadrado = (lado1 * lado2);

            Console.WriteLine("El área del cuadrado es {0} x {1} = {2}cm²", lado1, lado2, areaCuadrado);
        }
    }
}
