using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Apotema, Perimetro;
            double areaHexagono;

            Console.Write("Digite el Apotema: ");
            Apotema = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite el Perimetro: ");
            Perimetro = Convert.ToDouble(Console.ReadLine());

            areaHexagono = (Apotema * Perimetro) / 2;

            Console.WriteLine("El área del Hexagono es ({0} x {1}) / 2 = {2:N2}cm²", Apotema, Perimetro, areaHexagono);
        }
    }
}
