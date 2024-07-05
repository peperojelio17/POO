using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTetris30_5
{
    public class Linea : Pieza
    {
        bool rotar = false;
        Random r = new Random();
        public Linea()
        {
            
            colorP = r.Next(1, 4);
            a = new Bloque(1, 1);
            b = new Bloque(1, 2);
            c = new Bloque(1, 3);
            d = new Bloque(1, 4);
            bloques.Add(a);
            bloques.Add(b);
            bloques.Add(c);
            bloques.Add(d);
        }
        public override void Rotar()
        {
            if (rotar== false) { 
            Console.SetCursorPosition(a.y, a.x);
            Console.Write("    ");
            a.y = b.y;  c.y = b.y;  d.y = b.y;
            a.x = b.x-1;  c.x = b.x + 1;  d.x = b.x + 2;
            rotar = true;
            }
            else
            {
                for (int i = 0; i < bloques.Count; i++) { 
                Console.SetCursorPosition(a.y, a.x + i);
                Console.Write(" ");
                }
                a.x = b.x; c.x = b.x; d.x = b.x;
                a.y = b.y - 1; c.y = b.y + 1; d.y = b.y + 2;
                rotar = false;
            }
        }

    }
    public class Cubo : Pieza
    {
        Random r = new Random();
        public Cubo()
        {
            colorP = r.Next(1, 4);
            a = new Bloque(1, 1);
            b = new Bloque(1, 2);
            c = new Bloque(2, 1);
            d = new Bloque(2, 2);
            bloques.Add(a);
            bloques.Add(b);
            bloques.Add(c);
            bloques.Add(d);
        }
        public override void Rotar()
        {
        }
    }
    public class Ele : Pieza
    {
        Random r = new Random();
        public Ele()
        {
            colorP = r.Next(1, 4);
            a = new Bloque(1, 1);
            b = new Bloque(1, 2);
            c = new Bloque(1, 3);
            d = new Bloque(2, 3);

            bloques.Add(a);
            bloques.Add(b);
            bloques.Add(c);
            bloques.Add(d);
        }
        public override void Rotar()
        {
            // Rotación específica para la pieza L
            int centroX = bloques[1].x;
            int centroY = bloques[1].y;

            foreach(var bloque in bloques)
            {
                Console.SetCursorPosition(bloque.y, bloque.x );
                Console.Write(" ");
            }
            for (int i = 0; i < bloques.Count; i++)
            {
                
                int x = bloques[i].x - centroX;
                int y = bloques[i].y - centroY;
                bloques[i].x = centroX - y;
                bloques[i].y = centroY + x;
            }
        }
    }
    public class Te : Pieza
    {
        Random r = new Random();
        public Te()
        {
            colorP = r.Next(1, 4);
            a = new Bloque(1, 1);
            b = new Bloque(1, 2);
            c = new Bloque(1, 3);
            d = new Bloque(2, 2);
            bloques.Add(a);
            bloques.Add(b);
            bloques.Add(c);
            bloques.Add(d);
        }
        public override void Rotar()
        {
            foreach (var bloque in bloques)
            {
                Console.SetCursorPosition(bloque.y, bloque.x);
                Console.Write(" ");
            }
            int centroX = bloques[1].x;
            int centroY = bloques[1].y;

            for (int i = 0; i < bloques.Count; i++)
            {
                int x = bloques[i].x - centroX;
                int y = bloques[i].y - centroY;
                bloques[i].x = centroX - y;
                bloques[i].y = centroY + x;
            }
        }
    }
    public class Ese : Pieza
    {
        Random r = new Random();
        public Ese()
        {
            colorP = r.Next(1, 4);
            a = new Bloque(1, 1);
            b = new Bloque(1, 2);
            c = new Bloque(2, 2);
            d = new Bloque(2, 3);
            bloques.Add(a);
            bloques.Add(b);
            bloques.Add(c);
            bloques.Add(d);
        }
        public override void Rotar()
        {

            foreach (var bloque in bloques)
            {
                Console.SetCursorPosition(bloque.y, bloque.x);
                Console.Write(" ");
            }
            int centroX = bloques[1].x;
            int centroY = bloques[1].y;

            for (int i = 0; i < bloques.Count; i++)
            {
                int x = bloques[i].x - centroX;
                int y = bloques[i].y - centroY;
                bloques[i].x = centroX - y;
                bloques[i].y = centroY + x;
            }
        }
    }
    public class Zeta : Pieza
    {
        Random r = new Random();
        public Zeta()
        {
            colorP = r.Next(1, 4);
            a = new Bloque(1, 2);
            b = new Bloque(1, 3);
            c = new Bloque(2, 1);
            d = new Bloque(2, 2);
            bloques.Add(a);
            bloques.Add(b);
            bloques.Add(c);
            bloques.Add(d);
        }
        public override void Rotar()
        {
            foreach (var bloque in bloques)
            {
                Console.SetCursorPosition(bloque.y, bloque.x);
                Console.Write(" ");
            }
            int centroX = bloques[1].x;
            int centroY = bloques[1].y;

            for (int i = 0; i < bloques.Count; i++)
            {
                int x = bloques[i].x - centroX;
                int y = bloques[i].y - centroY;
                bloques[i].x = centroX - y;
                bloques[i].y = centroY + x;
            }
        }
    }
}
