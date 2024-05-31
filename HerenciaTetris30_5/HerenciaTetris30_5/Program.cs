using System;
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
            Pieza piezaActual;
            Te a1;
            bool nuevaPieza = false;
            a1 = new Te();
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
                                piezaActual.derecha();
                            if (tecla == ConsoleKey.LeftArrow)
                                piezaActual.izquierda();
                            if (tecla == ConsoleKey.UpArrow)
                            {
                            piezaActual.Rotar();
                            }
                    }
                    //tecla = Console.ReadKey();
                    foreach (Pieza pieza in piezas)
                    {
                        if (pieza == piezaActual)
                        {
                            if (pieza.bajar(piezas))
                            {
                                foreach (Bloque bloque in pieza.bloques)
                                {
                                    Console.SetCursorPosition(bloque.y + 30, bloque.x);
                                    Console.Write(" ");
                                }
                                foreach (Bloque bloque in pieza.bloques)
                                    bloque.x++;
                                foreach (Bloque bloque in pieza.bloques)
                                {
                                    
                                    Console.SetCursorPosition(bloque.y + 30, bloque.x);
                                    Console.Write("#");
                                }
                            }
                            else nuevaPieza = true;
                            h1 = h2;
                                
                        }

                    }
                    if (nuevaPieza)
                    {
                        piezaActual.color();
                        piezaActual.nueva(piezas);
                        nuevaPieza = false;
                    }
                }

            }
        }
    }
}
