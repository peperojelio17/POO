using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jueguito
{
    public class Jugador
    {
        private int w = Console.WindowWidth;
        private int h = Console.WindowHeight;
        private int x;
        private int y;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public Jugador() {
            x = w / 2;
            y = h / 2;
        }
        private string jugador = "Tu";
        public void dibujar()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(jugador);
        }
        private void borrar()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(" ");
            Console.SetCursorPosition(x + 1, y);
            Console.WriteLine(" ");
        }
        //-----------movimientos------------
        public void derecha() 
        {
            borrar();
            x++;
            dibujar();
        }
        public void izquierda() 
        {
            borrar();
            x--;
            dibujar();
        }
        public void arriba()
        {
            borrar();
            y--;
            dibujar();
        }
        public void abajo()
        {
            borrar();
            y++;
            dibujar();
        }
    }
}
