using System;

namespace argumentos_nomeados
{
    class Program
    {
        static void Send(string destination, string title, string subject)
        {
            Console.WriteLine($"{destination} - {title} - {subject}");
        }
        static void Main(string[] args)
        {
            Send(destination: "Destino: nataliasouza.ti@hotmail.com", title: "Título: Argumentos Nomeados",
                subject: "Assunto: Apenas treinando Argumentos Nomeados");

            Send(title: "Título: Prática de Argumentos Nomeados", subject: "Assunto: Prática de Argumentos Nomeados", 
                destination: "Destino: nattsouza.ti@hotmail.com");

            Send(subject: "Assunto: Criar Artigo Argumentos Nomeados", destination: "Destino: natt.ti@hotmail.com",
                title: "Título: Artigo Argumentos Nomeados");

            Console.ReadLine();
        }
    }
}
