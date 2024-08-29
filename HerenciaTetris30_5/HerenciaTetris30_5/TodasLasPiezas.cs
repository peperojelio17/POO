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
    }
}
