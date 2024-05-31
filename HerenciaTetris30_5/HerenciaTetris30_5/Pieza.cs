using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTetris30_5
{
    public abstract class Pieza
    {
        int limite = 25;
        public List<Bloque> bloques = new List<Bloque>();

        public Bloque a, b, c, d;

        public bool bajar(List<Pieza> piezas)
        {
            Pieza piezaActual;
            piezaActual = piezas.Last();
            bool total = true;
            foreach (var bloque in bloques)
            {
                if (bloque.x + 1 == limite)
                {
                    total = false;
                    return total;
                }
            }
            foreach (Pieza c in piezas)
            {
                if(c != piezaActual) { 
                foreach (var bloque in bloques)
                {
                    foreach (var item in c.bloques)
                    {
                        if (bloque.x == item.x - 1 && bloque.y == item.y)
                        {
                            total = false;
                        }
                    }
                }
                }
            }
            return total;
        }

        public abstract void Rotar();
        
        public void derecha()
        {
            foreach (var bloque in bloques)
            {
                Console.SetCursorPosition(bloque.y + 30, bloque.x);
                Console.Write(" ");
                bloque.y++;
            }

        }
        public void izquierda()
        {
            foreach (var bloque in bloques)
            {
                Console.SetCursorPosition(bloque.y + 30, bloque.x);
                Console.Write(" ");
                bloque.y--;
            }
        }
        public void color()
        {
            Random r = new Random();
            int color = r.Next(1,4);
            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
                
        }
        public void nueva(List<Pieza> piezas)
        {
            Random r = new Random();
            int num = r.Next(1, 6);
            Linea a1;
            Cubo a2;
            Te a3;
            Ele a4;
            Ese a5;
            Zeta a6;
            switch (num)
            {
                case 1:
                    a2 = new Cubo();
                    piezas.Add(a2);
                    break;
                case 2:
                    a3 = new Te();
                    piezas.Add(a3);
                    break;
                case 3:
                    a4 = new Ele();
                    piezas.Add(a4);
                    break;
                case 4:
                    a1 = new Linea();
                    piezas.Add(a1);
                    break;
                case 5:
                    a5 = new Ese();
                    piezas.Add(a5);
                    break;
                case 6:
                    a6 = new Zeta();
                    piezas.Add(a6);
                    break;
            }
        }
    }
}
