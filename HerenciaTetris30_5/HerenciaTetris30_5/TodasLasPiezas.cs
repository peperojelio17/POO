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
        public Linea()
        {
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
            Console.SetCursorPosition(a.y + 30, a.x);
            Console.Write("    ");
            a.y = b.y;  c.y = b.y;  d.y = b.y;
            a.x = b.x-1;  c.x = b.x + 1;  d.x = b.x + 2;
            rotar = true;
            }
            else
            {
                for (int i = 0; i < bloques.Count; i++) { 
                Console.SetCursorPosition(a.y + 30, a.x + i);
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
        public Cubo()
        {
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
        bool rotar = false;
        public Ele()
        {
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

            if (rotar == false)
            {
                Console.SetCursorPosition(a.y + 30, a.x);
                Console.Write("   ");
                Console.SetCursorPosition(c.y + 30, c.x +1);
                Console.Write(" ");
                a.y = b.y; c.y = b.y; d.y = b.y-1;
                a.x = b.x - 1; c.x = b.x + 1; d.x = b.x + 1;
                rotar = true;
            }
            else
            {
                for (int i = 0; i < bloques.Count - 1; i++)
                {
                    Console.SetCursorPosition(a.y + 30, a.x + i);
                    Console.Write(" ");
                }
                Console.SetCursorPosition(a.y + 29, c.x);
                Console.Write(" ");
                a.x = b.x; c.x = b.x; d.x = b.x +1;
                a.y = b.y - 1; c.y = b.y + 1; d.y = b.y + 1;
                rotar = false;
            }
        }
    }
    public class Te : Pieza
    {
        bool rotar = false;
        public Te()
        {
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

            if (rotar == false)
            {
                Console.SetCursorPosition(a.y + 30, a.x);
                Console.Write("   ");
                Console.SetCursorPosition(b.y + 30, b.x + 1);
                Console.Write(" ");
                a.y = b.y; c.y = b.y; d.y = b.y - 1;
                a.x = b.x - 1; c.x = b.x + 1; d.x = b.x;
                rotar = true;
            }
            else
            {
                for (int i = 0; i < bloques.Count - 1; i++)
                {
                    Console.SetCursorPosition(a.y + 30, a.x + i);
                    Console.Write(" ");
                }
                Console.SetCursorPosition(a.y + 28, b.x);
                Console.Write(" ");
                a.x = b.x; c.x = b.x; d.x = b.x + 1;
                a.y = b.y - 1; c.y = b.y + 1; d.y = b.y;
                rotar = false;
            }
        }
    }
    public class Ese : Pieza
    {
        public Ese()
        {
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

            a = new Bloque(b.x - 1, b.y);
            c = new Bloque(b.x + 1, b.y);
            d = new Bloque(b.x + 2, b.y);
        }
    }
    public class Zeta : Pieza
    {
        public Zeta()
        {
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

            a = new Bloque(b.x - 1, b.y);
            c = new Bloque(b.x + 1, b.y);
            d = new Bloque(b.x + 2, b.y);
        }
    }
}
