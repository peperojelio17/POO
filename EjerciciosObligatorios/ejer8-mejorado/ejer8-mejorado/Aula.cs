using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer8_mejorado
{
    public class Aula
    {
        private int numAula;
        private int maxEstudiantes;
        private string materia;
        private Profesor profesor;
        private List<Estudiante> estudiantes;

        public int NumAula { get { return numAula; } }
        public int MaxEstudiantes { get { return maxEstudiantes; } }
        public string Materia { get { return materia; } }

        public Profesor AulaProfesor { get { return profesor; } }
        public List<Estudiante> AulaEstudiantes { get{ return estudiantes; } }

        public Aula(int numA, int maxE, string m, Profesor p, List<Estudiante> e)
        {
            numAula = numA;
            maxEstudiantes = maxE;
            materia = m;
            profesor = p;
            estudiantes = e;
        }
        private bool estudiantesPresentes()
        {
            int estudiantesP = 0;
            foreach (Estudiante e in estudiantes)
            {
                if (e.Asistencia) estudiantesP++;
            }
            return (estudiantesP > estudiantes.Count / 2) ? true : false;
        }
        public bool darClases()
        {
            if (materia != profesor.Materia)
            {
                Console.WriteLine("El profesor no es de esta materia");
                return false;
            }
            else if (!profesor.Asistencia)
            {
                Console.WriteLine("No hubo clase por falta del profesor");
                return false;
            }
            else if (maxEstudiantes < estudiantes.Count)
            {
                Console.WriteLine("Hay mas estudiantes que los que pueden entrar");
                return false;

            }
            else if (!estudiantesPresentes())
            {
                Console.WriteLine("No hubo clase por falta estudiantes");
                return false;
            }
            return true;
        }
        public void estudiantesA()
        {
            int mujeresA = 0;
            int hombresA = 0;
            if (darClases())
            {
                foreach (Estudiante e in estudiantes)
                {
                    if (e.Calificacion >= 6)
                    {
                        if (e.Sexo == 'M')
                            mujeresA++;
                        else
                            hombresA++;
                    }
                }
                //Console.WriteLine($"Hay {mujeresA} mujeres aprobadas en la clase");
                //Console.WriteLine($"Hay {hombresA} hombres aprobados en la clase");
            }
        }
    }
}
