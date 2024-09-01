using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer8
{
    public abstract class Persona
    {
        private string nombre;
        private int edad;
        private char sexo;
        private bool asistencia;
        public string Nombre { get { return nombre; } }
        public int Edad { get { return edad; } }
        public char Sexo { get { return sexo; } }
        public bool Asistencia { get { return asistencia; } }

        public Persona(string n, int e, char s)
        {
            nombre = n;
            edad = e;
            sexo = s;
            asistencia = AsistirClase();

        }

        public abstract bool AsistirClase();
    }
}
