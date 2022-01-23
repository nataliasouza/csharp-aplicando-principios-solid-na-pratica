using System;

namespace metodos_de_extensao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text1 = "curso";
            var text2 = "cSharp";

            //Extension Method
            text1 = text1.UppercaseFirstLetter();
            text2 = text2.UppercaseFirstLetter();

            Console.WriteLine(text1);
            Console.WriteLine(text2);

        }
    }
}
