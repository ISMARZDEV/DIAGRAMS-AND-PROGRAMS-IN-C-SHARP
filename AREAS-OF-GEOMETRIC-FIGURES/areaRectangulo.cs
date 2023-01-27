using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Base, Altura;
            int areaRectangulo;

            Console.Write("Digite la Base: ");
            Base = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite la Altura: ");
            Altura = Convert.ToInt32(Console.ReadLine());

            areaRectangulo = (Base * Altura);

            Console.WriteLine("El área del Rectangulo es {0} x {1} = {2}cm²", Base, Altura, areaRectangulo);
            
        }
    }
}
