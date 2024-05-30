using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace menu17_5
{
    public class Copo
    {
        public int col = 0;
        public int fila = 0;

        public Copo(int col, int fila)
        {
            this.col = col;
            this.fila = fila;
        }
    }
    internal class Copos
    {


        static TimeSpan transurso;
        static DateTime h1 = DateTime.Now;
        static DateTime h2 = DateTime.Now;
        static int fila = 0;
        static int columna = 0;
        static List<Copo> copos = new List<Copo>();
        static List<Copo> borrarCopos = new List<Copo>();

        static int limite = 10;
        static bool bajar(Copo copo)
        {
            bool total = true;
            if (copo.fila + 1 == limite)
                return false;

            foreach (Copo c in copos)
            {
                if (copo.fila + 1 == c.fila && copo.col == c.col)
                {
                    total = false;

                }
            }
            return total;
        }
        static void lleno()
        {
            int llenar = 0;

            foreach (Copo copo in copos)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (copo.col == i && copo.fila == limite - 1)
                    {
                        llenar++;
                    }
                }
            }
            if (llenar == 7)
            {
                for (int i = copos.Count - 1; i >= 0; i--)
                {
                    if (copos[i].fila == limite - 1)
                    {
                        Console.SetCursorPosition(copos[i].col, copos[i].fila);
                        Console.Write(" ");
                        copos.Remove(copos[i]);

                    }
                }

            }
        }
        public void parametros()
        {
            int filas;
            Console.WriteLine("indique cuantas filas quere:");
            filas = int.Parse(Console.ReadLine());
            Console.Clear();
            mostrar(filas, h2, h1);
        }
        public void mostrar(int filas, DateTime h2, DateTime h1)
        {
            Copo a1;

            Random r = new Random();
            columna = r.Next(1, filas);



            for (int i = 0; i < 3; i++)
            {
                a1 = new Copo(r.Next(1, filas), 1);
                copos.Add(a1);
            }

            while (true)
            {
                //h2 = DateTime.Now;
                transurso = h2 - h1;
                Console.CursorVisible = false;

                if (transurso.Milliseconds > 300)
                {
                    a1 = new Copo(r.Next(1, filas), 1);
                    copos.Add(a1);

                    foreach (Copo copo in copos)
                    {

                        if (bajar(copo))
                        {
                            Console.SetCursorPosition(copo.col, copo.fila);
                            Console.Write(" ");
                            copo.fila++;
                            Console.SetCursorPosition(copo.col, copo.fila);
                            Console.Write("*");

                        }
                        h1 = h2;

                    }
                    lleno();
                }
            }
        }
    }
}
