using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comercial e1 = new Comercial("Rodrigo", 27, 2500, 310);
            Repartidor e2 = new Repartidor("Gino", 28, 1400, "zona 1");
            Comercial e3 = new Comercial("Marta", 40, 1200, 310);
            Repartidor e4 = new Repartidor("Gustavo", 23, 1400, "zona 3");
            Comercial e5 = new Comercial("Lucero", 20, 3100, 124);
            Repartidor e6 = new Repartidor("Ana Maria", 18, 2030, "zona 2");
            Comercial e7 = new Comercial("Ana Liza", 32, 2100, 240);
            Repartidor e8 = new Repartidor("Yosua", 47, 1800, "zona 3");
            Comercial e9 = new Comercial("Carla", 45, 4100, 180);

            List<Empleado> list = new List<Empleado>() { e1,e2,e3,e4,e5,e6,e7,e8,e9};
            string c = "";
            Console.WriteLine("Datos de los empleados:");
            foreach (Empleado e in list)
            {
                c = (e is Comercial) ? "Comercial": "Repartidor";
                Console.WriteLine($"Nombre: {e.Nombre} --- Tipo: {c} --- Edad: {e.Edad} --- Salario: {e.Salario}");
            }
            Console.WriteLine();
            Console.WriteLine("Datos de los empleados tras analizar el plus:");
            foreach (Empleado e in list)
            {
                if(e.plus()) Console.ForegroundColor = ConsoleColor.Green;
                else Console.ForegroundColor = ConsoleColor.White;
                c = (e is Comercial) ? "Comercial" : "Repartidor";
                Console.WriteLine($"Nombre: {e.Nombre} --- Tipo: {c} --- Edad: {e.Edad} --- Salario: {e.Salario}");
            }
            Console.ReadKey();
        }
    }
}
