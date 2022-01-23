using System;

namespace metodos_estaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma = " + Calculator.Addition(10,3));
            Console.WriteLine("Subtração = " + Calculator.Subtract(10, 5));

            Console.ReadLine();
        }
    }
}
