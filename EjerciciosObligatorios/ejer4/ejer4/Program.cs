using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precioEles = 0;
            double precioTvs = 0;
            double precioLavs = 0;
            Lavadora lav1 = new Lavadora();
            Lavadora lav2 = new Lavadora(200, 30);
            Lavadora lav3 = new Lavadora(200, 55);
            Lavadora lav4 = new Lavadora(300, "blanco", 'B', 17, 32);
            Television tv1 = new Television();
            Television tv2 = new Television(400, 14);
            Television tv3 = new Television(400, "Rojo", 'A', 89, 52, true);
            Television tv4 = new Television(540, "verde", 'D', 4, 30, false);
            Electrodomestico ele1 = new Electrodomestico(); 
            Electrodomestico ele2 = new Electrodomestico(90, 55); 
            Electrodomestico[] eles = new Electrodomestico[10] { lav1, lav2, lav3, lav4, tv1, tv2, tv3, tv4, ele1, ele2 };

            for(int e = 0; e < eles.Length; e++)
            {
                Console.WriteLine($"{e + 1}° electrodomestico  precio: {eles[e].precioFinal()}");
            }
            foreach (var e in eles)
            {
                precioEles += e.precioFinal();
                precioTvs += (e is Television) ? e.precioFinal() : 0;
                precioLavs += (e is Lavadora) ? e.precioFinal() : 0;
                //if (e is Television)
                //    precioTvs += e.precioFinal();
                //if (e is Lavadora)
                //    precioLavs += e.precioFinal();
            }
            Console.WriteLine($"El precio total de los electrodomesticos es: {precioEles}");
            Console.WriteLine($"El precio total de las lavadoras es: {precioLavs}");
            Console.WriteLine($"El precio total de los televisores es: {precioTvs}");
            Console.ReadKey();
        }
    }
}
