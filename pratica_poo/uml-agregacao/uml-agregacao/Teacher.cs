using System;

namespace uml_agregacao
{
    public class Teacher : IDisposable
    {
        public string Name { get; set; }       

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}