using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tetris;

namespace tetris
{
    public class Pieza
    {
        string tipo = "";
        public List<Bloque> bloques = new List<Bloque>();

        public Pieza(string tipo)
        {
            if (tipo == "linea")
            {
                Bloque a = new Bloque(1, 1);
                Bloque b = new Bloque(1, 2);
                Bloque c = new Bloque(1, 3);
                Bloque d = new Bloque(1, 4);

                bloques.Add(a);
                bloques.Add(b);
                bloques.Add(c);
                bloques.Add(d);
            }
            if (tipo == "cubo")
            {
                Bloque a = new Bloque(1, 1);
                Bloque b = new Bloque(1, 2);
                Bloque c = new Bloque(2, 1);
                Bloque d = new Bloque(2, 2);
                bloques.Add(a);
                bloques.Add(b);
                bloques.Add(c);
                bloques.Add(d);
            }
        }

        public void derecha()
        {
            foreach (var item in bloques)
            {
                item.x++;
            }
        }
        
    }

    public class Bloque
    {
        public int x;
        public int y;

        public Bloque(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    internal class Program
    {
        static TimeSpan transurso;
        static DateTime h1 = DateTime.Now;
        static DateTime h2 = DateTime.Now;
        static List<Pieza> piezas = new List<Pieza>();

        static int limite = 10;

        static bool bajar(Pieza pieza)
        {
            bool total = true;
            if (pieza.bloques[1].x + 1 == limite)
            {
                return false;
            }
            //foreach (Pieza c in piezas)
            //{
            //    if (pieza.fila + 1 == c.fila && pieza.col == c.col)
            //    {
            //        total = false;

            //    }
            //}
            return total;
        }

        static void Main(string[] args)
        {
            Pieza a1;

            a1 = new Pieza("linea");
            piezas.Add(a1);
            while (true)
            {
                h2 = DateTime.Now;
                transurso = h2 - h1;
                if (transurso.Milliseconds > 500)
                {
                    foreach (Pieza pieza in piezas)
                    {
                        if (bajar(pieza))
                        {
                            foreach(Bloque bloque in pieza.bloques) {
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
                        }
                        h1 = h2;

                    }

                }
            }
        }
    }
}



