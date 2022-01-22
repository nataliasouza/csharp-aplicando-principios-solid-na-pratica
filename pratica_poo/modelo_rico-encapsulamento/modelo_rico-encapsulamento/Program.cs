using System;

namespace modelo_rico_encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(1,"Natt Souza"," Rua fulano de tal");
            Console.WriteLine($"Id: {client.Id} Cliente: {client.Name} Endereço:{client.Address}");
           

            var resultSum = Sum(2, 2, 3, 7);           
            Console.WriteLine($"A soma dos 4 valores é: {resultSum}");

            var resultSum2 = Sum(new int[] { 1, 2, 3, 4 });
            Console.WriteLine($"A soma dos 4 valores é: {resultSum2}");

            var resultSum3 = Program.Sum(2, 1, 10);
            Console.WriteLine($"A soma dos 3 valores é: {resultSum3}");

            var resultSum4 = Sum(3, 1);
            Console.WriteLine($"A soma dos valores é: {resultSum4}");

            Console.ReadLine();
        }

        //trabalhando com sobrecargas
        static public int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        static public double Sum(double n1, int n2)
        {
            return n1 + n2;
        }

        static public int Sum(int n1, int n2, int n3)
        {
            return (n1 + n2) + n3;
        }

        static public int Sum(params int[] numbers)
        {
            var result = 0;
            foreach(var num in numbers)
                result += num;
            return result;
        }
    }
}
