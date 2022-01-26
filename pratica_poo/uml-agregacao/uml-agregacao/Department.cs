using System;
using System.Collections.Generic;

namespace uml_agregacao
{
    public class Department : IDisposable
    {
        private string Name { get; set; }        
        public List<Teacher> Teachers { get; set; }

        public void Dispose()
        { }
    }
}
