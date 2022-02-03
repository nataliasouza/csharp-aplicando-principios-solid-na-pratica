using System;

namespace InterfacesDesacoplandoCodigo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var registraOcorrenciasConsole = 
                new RegisterOccurrence(new RegisterInConsole());
            registraOcorrenciasConsole.Register("Registro Console");

            var registraOcorrenciasArquivo =
                new RegisterOccurrence(new RegisterInFile(@"C:\Users\natal\Desktop\"));
            registraOcorrenciasArquivo.Register("Registro arquivo");
            
            Console.ReadLine();
        }
    }
}
