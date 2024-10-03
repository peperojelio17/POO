using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer14
{
    // No estoy segura que significa cuando dice cree sus constructores getters and setter y toString
    internal class Program
    {
        static void Main(string[] args)
        {
            NoPerecedero sal = new NoPerecedero("sal", 34, "mineral");
            Perecedero lechuga = new Perecedero("lechuga", 20, 1);
            NoPerecedero azucar = new NoPerecedero("azucar", 12, "dulce");
            Perecedero carne = new Perecedero("carne", 53, 3);
            Producto tv = new Producto("tv", 253);
            List<Producto> productos = new List<Producto>() { sal,lechuga,azucar,carne,tv};

            foreach(Producto p in productos) 
                Console.WriteLine($"{p.Nombre} --- Precio base: {p.Precio} ---- Precio por 5 unidades: {p.calcular(5)}");

            Console.ReadLine();
        }
    }
}
