using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Reactivo3.Classes;
using Reactivo3.Exceptions;

namespace Reactivo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Name temp = new Name();
            try
            {
                temp.AskName();
            }
            catch (NameException e)
            {
                Console.WriteLine("\n" + e.Message);
            }

            LastName temp2 = new LastName();
            try
            {
                temp2.AskLastName();
            }
            catch (NameException e)
            {
                Console.WriteLine("\n" + e.Message);
            }

            Console.WriteLine("\nPresiona enter para continuar...");
            Console.ReadKey();
        }
    }
}
