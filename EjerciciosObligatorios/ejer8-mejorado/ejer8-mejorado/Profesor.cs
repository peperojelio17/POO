using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer8_mejorado
{
    public class Profesor : Persona
    {
        private string materia;

        public string Materia { get { return materia; } }

        public Profesor(string n, int e, char s, string m) : base(n, e, s)
        {
            materia = m;
        }
        public override bool AsistirClase()
        {
            Random r = new Random();

            int n = r.Next(1, 10);
            return (n > 2) ? true : false;
        }

    }
}
