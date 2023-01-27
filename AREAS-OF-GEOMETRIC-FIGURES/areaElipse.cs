using System;

namespace ConsoleApp
{
    internal class Program
    {
        // Entry point of the program
        static void Main(string[] args)
        {
            // Declare variables to store the major and minor radii
            double RadioMayor, RadioMenor;
            // Declare a variable to store the area of the ellipse
            double areaElipse;

            // Prompt the user to enter the value for the major radius
            Console.Write("Digite el RadioMayor: ");
            // Read and store the user input in the variable RadioMayor
            RadioMayor = Convert.ToDouble(Console.ReadLine());

            // Prompt the user to enter the value for the minor radius
            Console.Write("Digite el RadioMenor: ");
            // Read and store the user input in the variable RadioMenor
            RadioMenor = Convert.ToDouble(Console.ReadLine());

            // Calculate the area of the ellipse using the formula pi*r1*r2
            areaElipse = (Math.PI * RadioMayor * RadioMenor);

            // Display the result of the calculation, including the input values and the final area
            Console.WriteLine("El área de Elipse es ({0:N2} x {1} x {2}) = {3:N2}cm²", Math.PI, RadioMayor, RadioMenor,areaElipse);
        }
    }
}
