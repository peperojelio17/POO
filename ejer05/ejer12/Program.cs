using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom1 = "";
            string nom2 = "";
            string valor = "";
            int edad1 = 0;
            int edad2 = 0;
            Console.Write("Ingrese el nombre de la primera persona: ");
            nom1 = Console.ReadLine();
            Console.Write("Ingrese la edad de la primera persona: ");
            valor = Console.ReadLine();
            edad1 = int.Parse(valor);
            Console.Write("Ingrese el nombre de la segunda persona: ");
            nom2 = Console.ReadLine();
            Console.Write("Ingrese la edad de la segunda persona: ");
            valor = Console.ReadLine();
            edad2 = int.Parse(valor);
            if (edad1 < edad2)
            {
                Console.WriteLine(nom2);
            }
            else
            {
                Console.WriteLine(nom1);
            }
            Console.ReadKey();
        }
    }
}
