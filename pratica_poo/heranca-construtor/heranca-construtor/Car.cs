using System;

namespace heranca_construtor
{
    public class Car : Vehicle
    {
        public Car(string numberChassis) : base(numberChassis)
        {
            Console.WriteLine($"Inicializando carro: {numberChassis}");
        }
        public Car()
        {
            Console.WriteLine("Inicializando o carro");
        }

        public override void UmMetodoQualquer()
        {
            base.UmMetodoQualquer();
            Console.WriteLine("Sobrescrevi método!");
        }
    }
}
