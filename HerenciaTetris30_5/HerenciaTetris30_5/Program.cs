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

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Tablero t = new Tablero();
            t.dibujar();
            Pieza piezaActual;
            Ese a1;
            bool nuevaPieza = false;
            a1 = new Ese();
            piezas.Add(a1);
            while (true)
            {
                piezaActual = piezas[piezas.Count - 1];
                h2 = DateTime.Now;
                transurso = h2 - h1;
                if (transurso.Milliseconds > 200)
                {
                    if (Console.KeyAvailable)
                    {
                        var tecla = Console.ReadKey(true).Key;
                            if (tecla == ConsoleKey.RightArrow)
                                piezaActual.derecha(piezas);
                            if (tecla == ConsoleKey.LeftArrow)
                                piezaActual.izquierda(piezas);
                            if (tecla == ConsoleKey.UpArrow)
                            {
                            piezaActual.Rotar();
                            }
                    }
                    foreach (Pieza pieza in piezas)
                    {

                            if (pieza.bajar(piezas))
                            {
                                piezaActual.color(pieza.colorP);
                                foreach (Bloque bloque in pieza.bloques)
                                {
                                    Console.SetCursorPosition(bloque.y, bloque.x++);
                                    Console.Write(" ");
                                }
                                //foreach (Bloque bloque in pieza.bloques)
                                //    bloque.x++;
                                foreach (Bloque bloque in pieza.bloques)
                                {
                                    Console.SetCursorPosition(bloque.y, bloque.x);
                                    Console.Write("#");
                                }
                            piezaActual.eliminar(piezas);
                            if (piezaActual.eliminar(piezas) == true)
                                nuevaPieza = true;
                        }
                            else if(piezaActual.bajar(piezas) == false) nuevaPieza = true;
                            h1 = h2;
                                
                        //}

                    }
                    if (nuevaPieza)
                    {
                        
                        piezaActual.nueva(piezas);
                        nuevaPieza = false;
                    }
                }

            }
        }
    }
}
