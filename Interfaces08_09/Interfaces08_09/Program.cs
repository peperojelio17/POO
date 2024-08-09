using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces08_09
{
    interface IAves
    {
        string Name { get; }
        void comer(int cantidad);
    }
    interface IVolar
    {
        string Name { get; }
        void volar(int altura);
    }
    class Kiwi : IAves
    {
        public int cantidadComida = 0;
        public string Name { get; set; }

        public void comer(int cantidad)
        {
            cantidadComida += cantidad;
        }
    }
    class Pajaro : IAves, IVolar
    {
        public string Name { get; set; }
        public void comer(int cantidad)
        {
        }

        public void volar(int altura)
        {
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
