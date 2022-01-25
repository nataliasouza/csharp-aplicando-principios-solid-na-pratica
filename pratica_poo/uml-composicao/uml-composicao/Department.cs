using System;

namespace uml_composicao
{
    public class Department : IDisposable
    {
        private string Name { get; set; }
        private School School { get; set; }

        internal Department(School school, string name)
        {
            this.School = school;
            this.Name = name;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
