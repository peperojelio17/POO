using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer8_mejorado
{
    public class Tabla
    {
        private int w = Console.WindowWidth;
        private int h = Console.WindowHeight;
        private int pFiltro = 0;
        private int f = 0;
        private string filtro = "";
        private string asis;

        private Aula aula;
        public Tabla( Aula a) 
        { 
            aula = a;
        }
        public void tablero()
        {
            Console.SetCursorPosition(35, 0);
            Console.Write($"Clase {aula.NumAula} | Materia: {aula.Materia} | Profesor: {aula.AulaProfesor.Nombre}");
        }
        public void dibujar()
        {

            while (true)
            {
                if(f == 0) { 
                tablero();
                datosProfesor();
                Console.SetCursorPosition(0, 9);
                    if (aula.darClases())
                    {
                        datosEstudiantes();
                    Console.SetCursorPosition(10, pFiltro - 1);
                    }
                    filtro = Console.ReadLine();
                if (filtro != "")
                     f = 1;
                }
                Console.Clear();
                f = 0;
                

            }
            Console.Clear();
            tablero();
            datosProfesor();
            Console.SetCursorPosition(0, 9);
            //if(aula.darClases())
            datosEstudiantes();
            Console.SetCursorPosition(10, pFiltro - 1);
            filtro = Console.ReadLine();

        }
        public void datosProfesor() 
        {
            int a = 2;
            int inicio = a;
            linea(a - 1);
            Console.SetCursorPosition((w / 2) - 4, a++);
            Console.Write("profesor");
            linea(a++);
            int b = a;

            Console.SetCursorPosition(9, a);
            Console.Write("Nombre");
            Console.SetCursorPosition(w / 5 + 9, a);
            Console.Write("Edad");
            Console.SetCursorPosition((w / 5) * 2 + 9, a);
            Console.Write("Sexo");
            Console.SetCursorPosition((w / 5) * 3 + 6, a);
            Console.Write("Materia");
            Console.SetCursorPosition(w - (w / 5) + 6, a);
            Console.Write("Asistencia");
            linea(++a);

            a++;
                Console.SetCursorPosition(3, a);
                Console.Write(aula.AulaProfesor.Nombre);
                Console.SetCursorPosition(w / 5 + 3, a);
                Console.Write(aula.AulaProfesor.Edad);
                Console.SetCursorPosition((w / 5) * 2 + 3, a);
                Console.Write(aula.AulaProfesor.Sexo);
                Console.SetCursorPosition((w / 5) * 3 + 3, a);
                Console.Write(aula.AulaProfesor.Materia);
                Console.SetCursorPosition(w - (w / 5) + 3, a);
            Console.ForegroundColor = (aula.AulaProfesor.Asistencia) ? ConsoleColor.Green : ConsoleColor.Red;

            Console.Write((aula.AulaProfesor.Asistencia) ? "Presente" : "Ausente");
                linea(++a);
            columna(0, inicio, a + 1);
            columna(w - 1, inicio, a + 1);

            columna(w / 5, b, a + 1);
            columna((w / 5) * 2, b, a + 1);
            columna((w / 5) * 3, b, a + 1);
            columna(w - (w / 5), b, a + 1);
        }
        public void datosEstudiantes()
        {
            int a = 10;
            int inicio = a;
            linea(a - 1);
            Console.SetCursorPosition((w/ 2) - 4, a++);
            Console.Write("Alumnos");
            linea(a++);
            Console.SetCursorPosition(2, a++);
            Console.Write("Filtrar:");
            pFiltro = a;
            linea(a++);
            int b = a;

            Console.SetCursorPosition(9, a);
            Console.Write("Nombre");
            Console.SetCursorPosition(w/5 + 9, a);
            Console.Write("Edad");
            Console.SetCursorPosition((w/5)*2 + 9, a);
            Console.Write("Sexo");
            Console.SetCursorPosition((w / 5) * 3 + 6, a);
            Console.Write("Calificacion");
            Console.SetCursorPosition(w - (w / 5) + 6, a);
            Console.Write("Asistencia");
            linea(++a);

            foreach(Estudiante est in aula.AulaEstudiantes)
            {
                asis = (est.Asistencia) ? "Presente" : "Ausente";
                if (filtro == "") { 
                Console.ForegroundColor = (est.Calificacion >= 6) ? ConsoleColor.Green : ConsoleColor.Red;
                a++;
                Console.SetCursorPosition(3, a);
                Console.Write(est.Nombre);
                Console.SetCursorPosition(w / 5 + 3, a);
                Console.Write(est.Edad);
                Console.SetCursorPosition((w / 5) * 2 + 3, a);
                Console.Write(est.Sexo);
                Console.SetCursorPosition((w / 5) * 3 + 3, a);
                Console.Write(est.Calificacion);
                Console.SetCursorPosition(w - (w / 5) + 3, a);
                Console.ForegroundColor = (est.Asistencia) ? ConsoleColor.Green : ConsoleColor.Red;
                Console.Write(asis);
                linea(++a);
                }
                else
                {
                    if (filtro == asis)
                    {
                        Console.ForegroundColor = (est.Calificacion >= 6) ? ConsoleColor.Green : ConsoleColor.Red;
                        a++;
                        Console.SetCursorPosition(3, a);
                        Console.Write(est.Nombre);
                        Console.SetCursorPosition(w / 5 + 3, a);
                        Console.Write(est.Edad);
                        Console.SetCursorPosition((w / 5) * 2 + 3, a);
                        Console.Write(est.Sexo);
                        Console.SetCursorPosition((w / 5) * 3 + 3, a);
                        Console.Write(est.Calificacion);
                        Console.SetCursorPosition(w - (w / 5) + 3, a);
                        Console.ForegroundColor = (est.Asistencia) ? ConsoleColor.Green : ConsoleColor.Red;
                        Console.Write(asis);
                        linea(++a);
                    }
                }

            }
            columna(0, inicio, a + 1);
            columna(w - 1, inicio, a + 1);

            columna(w / 5, b, a + 1);
            columna((w / 5) * 2, b, a + 1);
            columna((w / 5) * 3, b, a + 1);
            columna(w - (w / 5), b, a + 1);
        }
        private void linea(int e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 1; i < w - 1; i++)
            {
                Console.SetCursorPosition(i, e);
                Console.Write("-");
            }

        }
        private void columna(int e, int inicio, int fin) 
        {
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = inicio; i < fin - 1; i++)
            {
                Console.SetCursorPosition(e, i);
                Console.Write("|");
            }
        }
    }
}
