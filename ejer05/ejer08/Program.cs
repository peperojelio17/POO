using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            string valor = "";
            Console.Write("Ingrese el valor del primer numero:");
            valor = Console.ReadLine();
            num1 = int.Parse(valor);
            Console.Write("Ingrese el valor del segundo numero:");
            valor = Console.ReadLine();
            num2 = int.Parse(valor);
            Console.Write("Ingrese el valor del tercer numero:");
            valor = Console.ReadLine();
            num3 = int.Parse(valor);
            if (num1 >  num2 && num1 > num3)
            {
                Console.Write(num1);
            }
            else
            {
                if (num3 > num2)
                {
                    Console.Write(num3);
                }
                else
                {
                    Console.Write(num2);
                }
            }
            Console.ReadKey();
        }
    }
}
