using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Password[] passwords;
            bool[] fuertes;
            int num;
            int largo;
            Console.Write("Cuantas contraseñas desea generar: ");
            num = int.Parse(Console.ReadLine()) ;
            passwords = new Password[num];
            fuertes = new bool[num];
            Console.Write("Indique la longitud de las contraseñas: ");
            largo = int.Parse(Console.ReadLine());
            for (int i = 0; i < passwords.Length; i++){
                Password e = new Password(largo);
                passwords[i] = e;
                fuertes[i] = passwords[i].esFuerte();
            }
            for (int i = 0; i < passwords.Length; i++)
            {
                Console.WriteLine($"{passwords[i].Contraseña}   {fuertes[i]}");
            }
            Console.ReadKey();
        }
    }
}
