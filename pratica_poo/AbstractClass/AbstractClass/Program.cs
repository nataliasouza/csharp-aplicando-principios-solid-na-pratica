using System;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var square = new Square();

            Console.WriteLine(square.Description());
            Console.Write("\nInforme a cor da figura: ");
            square.Color = Console.ReadLine();

            Console.Write("\nInforme o lado do quadrado: ");
            square.Side = Convert.ToInt32(Console.ReadLine());

            square.CalculateArea();
            square.CalculatePerimeter();

            Console.WriteLine($"\nA área do quadrado é: {square.Area} m2");
            Console.WriteLine($"O perímetro do quadrado é: {square.Perimeter} m");
            Console.WriteLine($"O perímetro do quadrado é: {square.Color}");

            Console.ReadKey();
        }
    }
}
