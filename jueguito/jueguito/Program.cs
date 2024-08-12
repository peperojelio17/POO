﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jueguito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Jugador jugador = new Jugador();
            Disparos disparos = new Disparos();
            Enemigo enemigo = new Enemigo();
            Enemigos enemigos = new Enemigos();

            while (true)
            {
                enemigos.crearEnemigo();
                disparos.y = jugador.Y;
                disparos.x = jugador.X;
                if (Console.KeyAvailable)
                {
                    var tecla = Console.ReadKey(true).Key;
                    if (tecla == ConsoleKey.RightArrow) jugador.derecha();
                    if (tecla == ConsoleKey.LeftArrow) jugador.izquierda();
                    if (tecla == ConsoleKey.UpArrow) jugador.arriba();
                    if (tecla == ConsoleKey.DownArrow) jugador.abajo();
                    if (tecla == ConsoleKey.D) disparos.tiro(0);
                    if (tecla == ConsoleKey.W) disparos.tiro(1);
                    if (tecla == ConsoleKey.A) disparos.tiro(2);
                    if (tecla == ConsoleKey.S) disparos.tiro(3);
                }
                enemigos.dibujar(jugador.X, jugador.Y, disparos.list);
                disparos.dibujar(enemigos.enemigos);
                jugador.dibujar();
            }
        }
    }
}
