using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaMinas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Juego j = new Juego(8,10,10);
            while (true)
            {
                j.moverse();
                j.dibujar();
            }
        }
    }
}
