﻿using System;
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
            BarajaEspañola barajaEspañola = new BarajaEspañola(true);
            BarajaFrancesa barajaFrancesa = new BarajaFrancesa();

            Console.WriteLine($"{carta.Numero} {carta.Palo}");
            Console.WriteLine();
            Console.WriteLine(barajaFrancesa.mostrarBaraja());
            Console.WriteLine();
            Console.WriteLine(barajaEspañola.mostrarBaraja());
            Console.WriteLine();
            barajaFrancesa.cartaNegra(carta);
            Console.WriteLine();
            barajaFrancesa.cartaRoja(carta);


            Console.ReadKey();
        }
    }
}