using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagrama_de_classes
{
    public class People
    {
        private DateTime birthDate = new DateTime(1984, 01, 12); 
        public string  Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        public People()
        {}

        public People(string name, int age, string sex)
        {            
            Name = name;
            Age = age;
            Sex = sex;
        }

        public void IdentifyPerson()
        {
            Console.WriteLine($"Nome: {Name} - Idade:{Age} - Sexo: {Sex}");
        }
    }
}
