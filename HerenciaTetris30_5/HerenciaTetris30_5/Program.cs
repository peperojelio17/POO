﻿using System;
using System.Collections.Generic;

namespace HerenciaTetris30_5
{
    internal class Program
    {
        static TimeSpan transurso;
        static DateTime h1 = DateTime.Now;
        static DateTime h2 = DateTime.Now;
        public static List<Pieza> piezas = new List<Pieza>();
        private static List<Pieza> nuPiezas = new List<Pieza>();

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            bool noPerdiste = true;
            Tablero t = new Tablero();
            t.dibujar();
            Pieza proximaPieza;
            Pieza piezaActual;
            Ele a1;
            bool nuevaPieza = false;
            a1 = new Ele();
            proximaPieza = new Ele();
            piezas.Add(a1);
            nuPiezas.Add(proximaPieza);
            while (noPerdiste)
            {
                proximaPieza = nuPiezas[piezas.Count - 1];
                piezaActual = piezas[piezas.Count - 1];
                noPerdiste = piezaActual.noPerdiste(piezas);
                h2 = DateTime.Now;
                transurso = h2 - h1;
                if (transurso.Milliseconds > 50)
                {
                    if (Console.KeyAvailable)
                    {
                        var tecla = Console.ReadKey(true).Key;
                        if (tecla == ConsoleKey.RightArrow)
                            piezaActual.derecha(piezas);
                        if (tecla == ConsoleKey.LeftArrow)
                            piezaActual.izquierda(piezas);
                        if (tecla == ConsoleKey.UpArrow)
                            piezaActual.Rotar();
                    }
                    foreach (Bloque bloque1 in proximaPieza.bloques) 
                    {
                        proximaPieza.color(proximaPieza.colorP);
                        Console.SetCursorPosition(bloque1.y + 15 , bloque1.x + 2);
                            Console.Write("#");
                    }
                    foreach (Pieza pieza in piezas)
                    {

                            if (pieza.bajar(piezas, pieza))
                            {
                                piezaActual.color(pieza.colorP);
                                foreach (Bloque bloque in pieza.bloques)
                                {
                                    Console.SetCursorPosition(bloque.y, bloque.x);
                                    Console.Write(" ");
                                }
                                foreach (Bloque bloque in pieza.bloques)
                                bloque.x++;
                                foreach (Bloque bloque in pieza.bloques)
                                {
                                    Console.SetCursorPosition(bloque.y, bloque.x);
                                    Console.Write("#");
                                }
                            piezaActual.eliminar(piezas);
                            if (piezaActual.eliminar(piezas) == true)
                                nuevaPieza = true;
                        }
                            else if(piezaActual.bajar(piezas, pieza) == false) nuevaPieza = true;
                            h1 = h2;
                                

                    }
                    if (nuevaPieza)
                    {
                        foreach (Bloque bloque in proximaPieza.bloques)
                        {
                            Console.SetCursorPosition(bloque.y + 15, bloque.x + 2);
                            Console.Write("   ");
                        }
                        proximaPieza.nueva(nuPiezas);
                        piezaActual = proximaPieza;
                        piezas.Add(piezaActual);
                        nuevaPieza = false;
                    }
                }
            }
            t.perdiste();
        }
    }
}
