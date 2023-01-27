using System;

namespace ConsoleApp
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            double Radio;
            double areaCirculo;

            Console.Write("Digite el Radio: ");
            Radio = Convert.ToDouble(Console.ReadLine());
            
            areaCirculo = (Math.PI) * (Math.Pow(Radio,2));

            Console.WriteLine("El área del Circulo es ({0:N2} x {1}²) = {2:N2}cm²", Math.PI, Radio, areaCirculo);
        }
    }
}
