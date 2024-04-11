using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = Console.ReadLine();
            int cero = 0;
            int p = nombre.Length - 1;
            int d = nombre.Length / 2;
            int doble = d * 2;
            for (int i = 0; i < d; i++)
            {
                //Console.Write(d);
                for (int n = 0; n <= i; n++)
                {
                    Console.Write(" ");

                }
                Console.Write(nombre[i]);
                doble--;
                //p--;
                //for (int j = p - i; j >= 0; j--)
                for (int j = doble - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(nombre[i]);

            }
            //Console.Write(d);
            p = nombre.Length;
            for (int w = 0; w <= d; w++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(nombre[d]);
            for (int a = d + 1; a < nombre.Length; a++)
            {

                // Console.Write(d);
                //Console.Write(p);
                //Console.Write(p + " - " + cero);
                //Console.Write(p - cero);
                //for (int m = p - a ; m >= 0; m--)
                for (int m = d - 1 - cero; m >= 0; m--)
                {
                    Console.Write(" ");
                }

                Console.Write(nombre[a]);

                for (int l = d + 1; l <= a + cero; l++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(nombre[a]);
                cero++;
            }
            Console.ReadKey();

        }
    }
}
