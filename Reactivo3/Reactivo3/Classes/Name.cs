using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reactivo3.Exceptions;

namespace Reactivo3.Classes
{
    class Name
    {
        string name;

        public void AskName()
        {
            Console.WriteLine("Por favor, escribe tu nombre:");
            name = Console.ReadLine();
            if (name.Length <= 2)
            {
                throw (new NameException("\t\tNombre no válido..."));
            }
            else
            {
                Console.WriteLine("\t\tFormato adecuado...");
            }
        }
    }
}
