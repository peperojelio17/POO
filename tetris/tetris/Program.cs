using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tetris;

namespace tetris
{

    public class Linea : Pieza
    {
        public Linea (string tipo) : base (tipo) 
        {
            
        }
    }
    public class Pieza
    {
        string tipo = "";
        public List<Bloque> bloques = new List<Bloque>();

        Bloque a, b, c, d;
        public Pieza(string tipo)
        {
            
            if (tipo == "linea")
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
            if (tipo == "cubo")
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
            if (tipo == "ele")
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
            if (tipo == "te")
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

        static int limite = 15;

        static bool bajar(Pieza pieza)
        {
            bool total = true;
            if (pieza.bloques[1].x + 1 == limite)
            {
                return false;
            }
            foreach (Pieza c in piezas)
            {
                if (pieza.bloques[3].x + 1 == c.bloques[1].x)
                {
                    total = false;

                }
            }
            return total;
        }

        static void Main(string[] args)
        {
            Pieza a1;
            Random r = new Random();
            int num = 0;
            a1 = new Pieza("linea");
            piezas.Add(a1);
            ConsoleKeyInfo tecla;
            while (true)
            {
                
                h2 = DateTime.Now;
                transurso = h2 - h1;
                if (transurso.Milliseconds > 500)
                {
                    //tecla = Console.ReadKey();
                    foreach (Pieza pieza in piezas)
                    {
                        if(pieza == piezas[piezas.Count - 1]) { 
                        if (bajar(pieza))
                        {
                                //if (tecla.Key == ConsoleKey.RightArrow)
                                //    pieza.derecha();
                                foreach (Bloque bloque in pieza.bloques) {
                                Console.SetCursorPosition(bloque.y + 3, bloque.x);
                                Console.Write(" ");
                            }
                            foreach (Bloque bloque in pieza.bloques)
                                bloque.x++;
                            foreach (Bloque bloque in pieza.bloques)
                            {
                                Console.SetCursorPosition(bloque.y + 3, bloque.x);
                                Console.Write("#");
                            }
                        }
                        h1 = h2;
                        if (bajar(pieza) == false)
                        {
                            num = r.Next(1, 5);
                        }
                        }

                    }
                    if (num == 1)
                    {
                        a1 = new Pieza("cubo");
                        piezas.Add(a1);
                        num = 0;
                    }
                    if (num == 2)
                    {
                        a1 = new Pieza("te");
                        piezas.Add(a1);
                        num = 0;
                    }
                    if (num == 3)
                    {
                        a1 = new Pieza("linea");
                        piezas.Add(a1);
                        num = 0;
                    }
                    if (num == 3)
                    {
                        a1 = new Pieza("ele");
                        piezas.Add(a1);
                        num = 0;
                    }
                }
                
            }
        }
    }
}



