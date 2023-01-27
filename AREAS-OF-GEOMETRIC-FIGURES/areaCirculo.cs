using System;

namespace ConsoleApp
{
    internal class Program
    {
        // Entry point of the program
        static void Main(string[] args)
        {
            // Declare variable to store the radius
            double Radio;
            // Declare a variable to store the area of the circle
            double areaCirculo;

            // Prompt the user to enter the value for the radius
            Console.Write("Digite el Radio: ");
            // Read and store the user input in the variable Radio
            Radio = Convert.ToDouble(Console.ReadLine());
            
            // Calculate the area of the circle using the formula pi * r^2
            areaCirculo = (Math.PI) * (Math.Pow(Radio,2));

            // Display the result of the calculation, including the input values and the final area
            Console.WriteLine("El área del Circulo es ({0:N2} x {1}²) = {2:N2}cm²", Math.PI, Radio, areaCirculo);
        }
    }
}
