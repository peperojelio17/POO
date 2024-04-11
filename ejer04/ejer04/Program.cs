using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado;
            int superficie;
            string valor;
            Console.Write("el valor de un lado:");
            valor = Console.ReadLine();
            lado = int.Parse(valor);
            superficie = lado * 4;
            Console.Write("La superficie es de ");
            Console.WriteLine(superficie);
            Console.ReadKey();
        }
    }
}
