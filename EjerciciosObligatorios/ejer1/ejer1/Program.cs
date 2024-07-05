using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta;
            cuenta = new Cuenta("Erick", 200);
            string respuesta;
            Console.WriteLine(cuenta.Titular + " " +  cuenta.Cantidad);
            
            while (true) {
                Console.WriteLine("Quiere hacer una operacion?(Si/No)");
                respuesta = Console.ReadLine();
                respuesta = respuesta.ToUpper();
                if(respuesta == "SI") { 
                    Console.WriteLine("Quiere ingresar o retirar?");
                    respuesta = Console.ReadLine();
                    respuesta = respuesta.ToUpper();
                    if (respuesta == "INGRESAR")
                    {
                    Console.WriteLine("Cantidad que quiere ingresar: ");
                    respuesta = Console.ReadLine();
                    cuenta.Ingresar(double.Parse(respuesta));
                    Console.WriteLine(cuenta.Titular + " " + cuenta.Cantidad);
                    }
                    else if(respuesta == "RETIRAR")
                    {
                    Console.WriteLine("Cantidad que quiere retirar: ");
                    respuesta = Console.ReadLine();
                    cuenta.Retirar(double.Parse(respuesta));
                    Console.WriteLine(cuenta.Titular + " " + cuenta.Cantidad);
                    }
                }
                else
                {
                    Console.WriteLine("-------Operacion finalizada--------");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
