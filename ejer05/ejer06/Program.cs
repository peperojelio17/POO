using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sueldo =0;
            string valor = "";
            Console.Write("Ingrese su sueldo:");
            valor = Console.ReadLine();
            sueldo = int.Parse(valor);
            if (sueldo > 30000)
            {
                Console.WriteLine("Usted debe abonar impuestos");
            }
            Console.ReadKey();
        }
    }
}
