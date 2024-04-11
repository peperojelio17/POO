using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota1 = 0;
            int nota2 = 0; 
            int nota3 = 0;
            string valor = "";
            int promedio = 0;
            Console.Write("Ingrese el valor de la primera nota:");
            valor = Console.ReadLine();
            nota1 = int.Parse(valor);
            Console.Write("Ingrese el valor de la segunda nota:");
            valor = Console.ReadLine();
            nota2 = int.Parse(valor);
            Console.Write("Ingrese el valor de la tercera nota:");
            valor = Console.ReadLine();
            nota3 = int.Parse(valor);
            promedio = nota1 + nota2 + nota3;
            promedio = promedio / 3;
            if (promedio >= 7)
            {
                Console.WriteLine("Promocionado");
            }
            else
            {
                if (promedio < 7 && promedio >= 4)
                {
                    Console.WriteLine("Regular");
                }
                else { Console.WriteLine("Reprobado"); }
            }
            Console.ReadKey();
        }
    }
}
