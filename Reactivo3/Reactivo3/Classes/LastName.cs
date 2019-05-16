using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reactivo3.Exceptions;

namespace Reactivo3.Classes
{
    class LastName
    {
        string lastname;

        public void AskLastName()
        {
            Console.WriteLine("\nAhora, escribe tu apellido:");
            lastname = Console.ReadLine();
            if (lastname.Length <= 2)
            {
                throw (new NameException("\t\tApellido no válido..."));
            }
            else
            {
                Console.WriteLine("\t\tFormato adecuado...");
            }
        }
    }
}
