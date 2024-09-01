using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer8_mejorado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Profesor p = new Profesor("Fisela", 50, 'H', "Matematicas");
            Estudiante e1 = new Estudiante("Martin", 17, 'H', 7);
            Estudiante e2 = new Estudiante("Gino", 16, 'H', 3);
            Estudiante e3 = new Estudiante("Eugenia", 17, 'M', 9);
            Estudiante e4 = new Estudiante("Anny", 17, 'M', 5);
            Estudiante e5 = new Estudiante("Facundo", 17, 'H', 7);
            Estudiante e6 = new Estudiante("Maidana", 16, 'H', 5);
            Estudiante e7 = new Estudiante("Gabriela", 18, 'M', 7);
            Estudiante e8 = new Estudiante("Nairel", 15, 'M', 8);
            Estudiante e9 = new Estudiante("Muriel", 17, 'M', 9);
            List<Estudiante> estudiantes = new List<Estudiante>() { e1, e2, e3, e4, e5, e6, e7, e8, e9};
            Aula clase = new Aula(101, 20, "Matematicas", p, estudiantes);

            Tabla t = new Tabla(clase);
            t.dibujar();
            Console.ReadKey();

        }
    }
}
