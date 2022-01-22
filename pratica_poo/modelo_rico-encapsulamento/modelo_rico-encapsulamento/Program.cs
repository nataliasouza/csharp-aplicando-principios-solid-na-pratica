using System;

namespace modelo_rico_encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using overloaded methods
            Client client = new Client(1,"Natt Souza"," Rua fulano de tal");
            Console.WriteLine($"Id: {client.Id} Cliente: {client.Name} Endereço:{client.Address}");           

            var resultSum = Sum(2, 2, 3, 7);           
            Console.WriteLine($"\nA soma dos 4 valores é: {resultSum}");

            var resultSum2 = Sum(new int[] { 1, 2, 3, 4 });
            Console.WriteLine($"A soma dos 4 valores é: {resultSum2}");

            var resultSum3 = Program.Sum(2, 1, 10);
            Console.WriteLine($"A soma dos 3 valores é: {resultSum3}");

            var resultSum4 = Sum(3, 1);
            Console.WriteLine($"A soma dos valores é: {resultSum4}\n");

            //using optional parameters

            var result = Sum(100);
            var result2 = Sum(100, 200);
            var result3 = Sum(100, 300, 500);
            var result4 = Sum(100, 200, 300, 400);

            Console.WriteLine($"Soma com 1 paramêtro{result}");
            Console.WriteLine($"Soma com 2 paramêtros{result2}");
            Console.WriteLine($"Soma com 3 paramêtros{result3}");
            Console.WriteLine($"Soma com 4 paramêtros{result4}");

            Console.ReadLine();
        }

        //Methods with overload
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

        //Method - Parameters Optional
        static int Sum(int n1, int n2 = 20, int n3 = 50, int n4 = 10)
        {
            return n1 + n2 + n3 + n4;
        }

    }
}
