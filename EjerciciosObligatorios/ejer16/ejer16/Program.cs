﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuAgenda menuAgenda = new MenuAgenda(6);
            menuAgenda.dibujar();
            while (true)  menuAgenda.controles(Console.ReadKey());
        }
    }
}