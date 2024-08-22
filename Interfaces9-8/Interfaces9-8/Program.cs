using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces9_8
{

    interface IAves
    {
        string Name { get; }
        void comer(int cantidad);
    }

    interface Ivolar
    {
        void volar(int altura);
    }

    class Ñandu : IAves
    {

        public int cantidadComida = 0;

        public string Name { get; }

        public void comer(int cantidad)
        {
            cantidadComida += cantidad;
        }
    }

    class Pajaro : IAves, Ivolar
    {
        public string Name { get; }

        public void comer(int cantidad)
        {
     
        }
        public void volar(int alura)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ñandu ñandu = new Ñandu();
            ñandu.comer(102);
            Console.WriteLine(ñandu.cantidadComida);
            Console.ReadKey();
        }
    }
}