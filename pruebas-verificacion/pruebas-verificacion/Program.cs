using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebas_verificacion
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
        static List<Copo> copos = new List<Copo>();
        static List<Copo> borrarCopos = new List<Copo>();
        static void Main(string[] args)
        {
            Copo a1;

            Random r = new Random();
            
            for (int i = 0; i < 3; i++)
            {
                a1 = new Copo(r.Next(1, 8), 1);
                copos.Add(a1);
            }
            foreach (Copo a in copos)
            {
                Console.WriteLine(a.col);
            }
            Console.WriteLine("-------------------------");
            for (int a = copos.Count-1;a >= 0; a-- )
            {
                borrarCopos.Add(copos[a]);
            }
            foreach (Copo a in borrarCopos)
            {
                Console.WriteLine(a.col);
                copos.Remove(a);
            }
            Console.WriteLine("-------------------------");
            foreach (Copo a in copos)
            {
                Console.WriteLine(a.col);
            }
            
            
        }
    }
}
