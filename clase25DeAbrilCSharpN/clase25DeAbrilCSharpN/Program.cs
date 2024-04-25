using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace clase25DeAbrilCSharpN
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
    internal class Program
    {

        static TimeSpan transurso;
        static DateTime h1 = DateTime.Now;
        static DateTime h2 = DateTime.Now;
        static int fila = 0;
        static int columna = 0;
        static List<Copo> copos = new List<Copo>(); 
        static void Main(string[] args)
        {
            Copo a1;
            
            Random r = new Random();
            columna = r.Next(1,50);
            
            for (int i = 0; i < 10; i++) { 
            a1 = new Copo(r.Next(1,50),1);
            copos.Add(a1);
            }

            while (true)
            {
                h2 = DateTime.Now;
                transurso = h2 - h1;
                Console.CursorVisible = false;
                foreach(Copo co in copos) 
                {
                    if (transurso.Milliseconds > 500) {
                        Console.SetCursorPosition(co.col, co.fila);
                    Console.Write(" ");
                    co.fila++;
                    Console.SetCursorPosition(co.col, co.fila);
                    Console.Write("*");
                    h1 = h2;
                }
                }
            }
            //for (int i = 0; i < 10; i++) {
            //    Console.SetCursorPosition(10, 10 + i);
            //    Console.Write("*");
            //    Thread.Sleep(2000);
            //    Console.Write(" ");
            //}
        }
    }
}
