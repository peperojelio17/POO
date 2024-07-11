using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1, p2, p3;
            string nombre;
            int edad;
            char sexo;
            int peso;
            int altura;
            string respuesta;
            Console.Write("introdusca el nombre de la persona:");
            respuesta = Console.ReadLine();
            nombre = respuesta;
            Console.Write("introdusca la edad de la persona:");
            respuesta = Console.ReadLine();
            edad = int.Parse(respuesta);
            Console.Write("introdusca el sexo de la persona:");
            respuesta = Console.ReadLine();
            sexo = char.Parse(respuesta);
            Console.Write("introdusca el peso de la persona:");
            respuesta = Console.ReadLine();
            peso = int.Parse(respuesta);
            Console.Write("introdusca la altura de la persona:");
            respuesta = Console.ReadLine();
            altura = int.Parse(respuesta);

            p1 = new Persona(nombre,edad, sexo, peso, altura);
            p2 = new Persona(nombre, edad, sexo);
            p3 = new Persona();

            Console.WriteLine(p)
        }
    }
}
