using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carta carta = new Carta("F");
            BarajaEspañola barajaEspañola = new BarajaEspañola(false);
            //Console.WriteLine($"{carta.Palo} - {carta.Numero}");
            foreach (var item in barajaEspañola.mazo) 
            { 
                Console.WriteLine($"{item.Numero} - {item.Palo}");
            }
            Console.ReadKey();
        }
    }
}
