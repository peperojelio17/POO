using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Almacen ala = new Almacen();
            ala.AgregarProducto(new Bebida(1, 5, 40, "coca"));
            ala.AgregarProducto(new Bebida(2, 3, 35, "Fanta"));
            ala.AgregarProducto(new AguaMineral(3, 3, 58, "Larga vida", "Cordoba"));
            ala.AgregarProducto(new Bebida(4, 2, 10, "Pepsi"));
            ala.AgregarProducto(new Bebida(5, 2, 35, "Pepsi"));
            ala.EliminarProducto(4);
            ala.AgregarProducto(new Bebida(6, 2, 20, "Nezquic"));
            
            ala.AgregarProducto(new Bebida(7, 1, 23, "Helado"));
            ala.AgregarProducto(new BebidasAzucarada(8, 4, 30, "Pepsi",32, true));
            ala.AgregarProducto(new Bebida(9, 2, 50, "coca"));
            ala.AgregarProducto(new Bebida(10, 6, 45, "Sprite"));
            ala.AgregarProducto(new Bebida(11, 2, 30, "Nezquic"));
            ala.AgregarProducto(new Bebida(12, 4, 15, "Sprite"));

            ala.mostrarInformacion();
            Console.WriteLine($"El precio total es: ${ala.precioBebidas()}");
            Console.WriteLine($"El precio total de las bebidas marca pepsi es: ${ala.precioMarca("Pepsi")}");
            Console.WriteLine($"El precio de la estanteria 2 es: ${ala.precioEstanteria(2)}");


            Console.ReadKey();
        }
    }
}
