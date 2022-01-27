using Interfaces.interfaces;
using System;

namespace Interfaces
{
    public class SaveDesing : NameDesign, ISaveDesign
    {
        public void SaveDesign()
        {
            throw new NotImplementedException();
        }

        //Não é obrigatório implementar metódo da classe concreta NameDesign
        //mas pode ser usado para sobreescrever método
        public override void Name()
        {
            Console.WriteLine("Definir nome ..."); ;
        }
    }
}
