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
            int numP = 0;
            Persona p1, p2, p3;
            List<Persona> personas = new List<Persona>();
            string nombre;
            int edad;
            char sexo;
            double peso;
            double altura;
            Console.Write("introdusca el nombre de la persona:");
            nombre = Console.ReadLine();
            Console.Write("introdusca la edad de la persona:");
            edad = int.Parse(Console.ReadLine());
            Console.Write("introdusca el sexo de la persona:");
            sexo = char.Parse(Console.ReadLine());
            Console.Write("introdusca el peso de la persona:");
            peso = double.Parse(Console.ReadLine());
            Console.Write("introdusca la altura de la persona:");
            altura = double.Parse(Console.ReadLine());

            p1 = new Persona(nombre,edad, sexo, peso, altura);
            p2 = new Persona(nombre, edad, sexo);
            p3 = new Persona();
            p3.Nombre = "Martin";
            p3.Edad = 16;
            p3.Sexo = 'M';
            p3.Peso = 69;
            p3.Altura = 1.62;
            personas.Add(p1); personas.Add(p2); personas.Add(p3);

            foreach (Persona persona in personas)
            {
                Console.WriteLine("---------Persona" + ++numP +"---------");
                Console.WriteLine($"DNI:  {persona.DNI}");
                Console.WriteLine($"Nombre:  {persona.Nombre}");
                Console.WriteLine($"Edad:  {persona.Edad}");
                Console.WriteLine($"Sexo:  {persona.Sexo}");
                Console.WriteLine($"Peso:  {persona.Peso}");
                Console.WriteLine($"Altura:  {persona.Altura}");
                if (persona.calcularIMC() == -1) Console.WriteLine($"{persona.Nombre} esta por debajo del peso recomendado");
                else if (persona.calcularIMC() == 0) Console.WriteLine($"{persona.Nombre} esta en su peso ideal");
                else if (persona.calcularIMC() == 1) Console.WriteLine($"{persona.Nombre} tiene sobrepeso");
                if (persona.esMayorDeEdad()) Console.WriteLine($"{persona.Nombre} es mayor de edad");
                else Console.WriteLine($"{persona.Nombre} no es mayor de edad");
            }
            Console.ReadKey();
        }
    }
}
