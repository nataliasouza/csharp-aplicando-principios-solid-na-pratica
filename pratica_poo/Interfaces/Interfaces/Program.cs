using Interfaces.interfaces;
using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var saveDesign = new SaveDesing();            
            saveDesign.NameDesignForm(); //sobrescreve o método da classe base
            saveDesign.SaveDesignForm(); //método da interface

            //usando interfaces
            ISaveDesign isave = new SaveDesing();
            isave.SaveDesignForm();
            //isave.NameDesignForm();
        }
    }
}
