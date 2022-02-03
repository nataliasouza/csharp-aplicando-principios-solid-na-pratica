using System;

namespace InterfacesDesacoplandoCodigo
{
    public class RegisterInConsole : IRegister
    {
        public void RegisterInfo(string msg)
        {
            Console.WriteLine($"info : {msg}");
        }
    }
}
