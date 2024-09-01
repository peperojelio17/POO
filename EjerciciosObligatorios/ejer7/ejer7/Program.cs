using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raices raiz = new Raices(3, -6, 1);
            raiz.calcular();
            Console.ReadKey();
        }
    }
}
