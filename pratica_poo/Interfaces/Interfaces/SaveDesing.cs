using Interfaces.interfaces;
using System;

namespace Interfaces
{
    public class SaveDesing : NameDesign, ISaveDesign
    {
        public void SaveDesignForm()
        {
            throw new NotImplementedException();
        }

        //Não é obrigatório implementar metódo da classe concreta NameDesign
        //mas pode ser usado para sobrescrever método
        public override void NameDesignForm()
        {
            Console.WriteLine("Definir nome ..."); ;
        }
    }
}
