using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTetris30_5
{
    public class Linea : Pieza
    {
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
    }
    public class Ele : Pieza
    {
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
    }public class Te : Pieza
    {
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
    }
    public class Pieza
    {
        string tipo = "";
        public List<Bloque> bloques = new List<Bloque>();

        public Bloque a, b, c, d;
        public Pieza()
        {
            if (tipo == "ele")
            {
                
            }
            if (tipo == "te")
            {
                
            }
        }



        public void derecha()
        {
            foreach (var item in bloques)
            {
                item.y++;
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
                total = false;
                return total;
            }
            foreach (Pieza c in piezas)
            {
                foreach(var bloque in pieza.bloques) { 
                if (bloque.x + 1 == c.bloques[1].x && bloque.y == c.bloques[0].y)
                {
                    total = false;
                }
                }
            }
            return total;
        }

        static void Main(string[] args)
        {
            Linea a1;
            Cubo a2;
            Te a3;
            Ele a4;
            Random r = new Random();
            int num = 0;
            a1 = new Linea();
            piezas.Add(a1);
            while (true)
            {
                
                h2 = DateTime.Now;
                transurso = h2 - h1;
                if (transurso.Milliseconds > 300)
                {
                    //tecla = Console.ReadKey();
                    foreach (Pieza pieza in piezas)
                    {
                        if (pieza == piezas[piezas.Count - 1])
                        {
                            if (bajar(pieza))
                            {
                                foreach (Bloque bloque in pieza.bloques)
                                {
                                    Console.SetCursorPosition(bloque.x + 3, bloque.x);
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
                                num = r.Next(1,4);
                            }

                        }

                    }
                    if (num == 1)
                    {
                        a2 = new Cubo();
                        piezas.Add(a2);
                        num = 0;
                    }
                    if (num == 2)
                    {
                        a3 = new Te();
                        piezas.Add(a3);
                        num = 0;
                    }
                    if (num == 3)
                    {
                        a4 = new Ele();
                        piezas.Add(a4);
                        num = 0;
                    }
                    if (num == 4)
                    {
                        a1 = new Linea();
                        piezas.Add(a1);
                        num = 0;
                    }
                }
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.RightArrow)
                    {
                        piezas[piezas.Count - 1].derecha();
                        foreach (Bloque bloque in piezas[piezas.Count - 1].bloques)
                        {
                            Console.SetCursorPosition(bloque.y + 2, bloque.x);
                            Console.Write(" ");
                        }
                    }
                }
            }
        }
    }
}
