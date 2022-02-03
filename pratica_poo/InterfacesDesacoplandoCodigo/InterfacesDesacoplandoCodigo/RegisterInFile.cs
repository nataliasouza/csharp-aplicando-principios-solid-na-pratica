using System;
using System.IO;

namespace InterfacesDesacoplandoCodigo
{
    public class RegisterInFile : IRegister
    {
        private readonly string _path;
        public RegisterInFile(string path)
        {
            _path = path;
        }

        public void RegisterInfo(string msg)
        {
            Log(msg);
        }

        private void Log(string msg)
        {
            using(var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(msg);
            }
        }
    }
}
