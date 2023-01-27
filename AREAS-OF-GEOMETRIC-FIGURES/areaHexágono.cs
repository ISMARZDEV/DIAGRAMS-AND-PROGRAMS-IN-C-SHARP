using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Apotema, Perimetro;
            double areaHexagono;

            // Ask the user to enter the apotema of the hexagon
            Console.Write("Digite el Apotema: ");
            Apotema = Convert.ToDouble(Console.ReadLine());

            // Ask the user to enter the perimeter of the hexagon
            Console.Write("Digite el Perimetro: ");
            Perimetro = Convert.ToDouble(Console.ReadLine());

            // Calculate the area of the hexagon
            areaHexagono = (Apotema * Perimetro) / 2;

            // Print the result of the calculation on the screen
            Console.WriteLine("El área del Hexagono es ({0} x {1}) / 2 = {2:N2}cm²", Apotema, Perimetro, areaHexagono);
        }
    }
}
