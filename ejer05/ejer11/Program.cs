using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            string valor = "";
            do
            {
                Console.Write("Ingrese un numero entre el 0 y el 999(frena con 0):");
                valor = Console.ReadLine();
                numero = int.Parse(valor);
                if (numero >= 100)
                {
                    Console.WriteLine("El numero tiene 3 digitos");
                }
                else { 
                if(numero>= 10)
                    {
                        Console.WriteLine("El numero tiene 2 digitos");
                    }
                    else
                    {
                        Console.WriteLine("El numero tiene 1 digito");
                    }
                }
            }while(numero != 0);
            Console.ReadKey();
        }
    }
}
