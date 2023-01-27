using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Base, Altura;
            double areaTriangulo;

            Console.Write("Digite la Base: ");
            Base = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite la Altura: ");
            Altura = Convert.ToDouble(Console.ReadLine());

            areaTriangulo = (Base * Altura) / 2;

            Console.WriteLine("El área del Triangulo es {0} x {1} / 2 = {2:N2}cm", Base, Altura, areaTriangulo);
            
        }
    }
}
