using System;

namespace heranca_construtor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carro = new Car("XYZ");
            carro.UmMetodoQualquer();
            Console.ReadLine();            
        }
    }
}
