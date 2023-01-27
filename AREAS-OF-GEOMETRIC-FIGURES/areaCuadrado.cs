using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado1, lado2;
            int areaCuadrado;

            // Ask the user to enter the first side
            Console.Write("Ingrese Lado #1: ");
            lado1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to enter the second side
            Console.Write("Ingrese Lado #2: ");
            lado2 = Convert.ToInt32(Console.ReadLine());

            // Calculate the area of the square
            areaCuadrado = (lado1 * lado2);

            // Print the result of the calculation on the screen
            Console.WriteLine("El área del cuadrado es {0} x {1} = {2}cm²", lado1, lado2, areaCuadrado);
        }
    }
}
