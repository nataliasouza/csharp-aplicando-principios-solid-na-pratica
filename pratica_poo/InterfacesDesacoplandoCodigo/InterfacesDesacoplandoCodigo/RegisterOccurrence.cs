using System;

namespace InterfacesDesacoplandoCodigo
{
    public class RegisterOccurrence
    {
        private readonly IRegister _registration;
        public RegisterOccurrence(IRegister registration)
        {
            _registration = registration;
        }

        public void Register(string msg)
        {
            _registration.RegisterInfo($"{msg}:{DateTime.Now}");
        }
    }
}
