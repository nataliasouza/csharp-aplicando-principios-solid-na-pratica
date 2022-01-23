using System;

namespace heranca_construtor
{
    public class Vehicle
    {
        private string _numberChassis { get; set; }

        public Vehicle(string numberChassis)
        {
            _numberChassis = numberChassis;
            Console.WriteLine($"Inicializando veículo: {numberChassis}");
        }
        public Vehicle()
        {
            Console.WriteLine("Inicializando veículo");
        }

        public virtual void UmMetodoQualquer()
        {
            Console.WriteLine("Um metódo qualquer");
        }
    }
}
