using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer8_mejorado
{
    public class Estudiante : Persona
    {

        private int calificacion;
        public int Calificacion { get { return calificacion; } }

        public Estudiante(string n, int e, char s, int c) : base(n, e, s)
        {
            calificacion = c;
        }
        public override bool AsistirClase()
        {
            var guid = Guid.NewGuid();
            var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 4));
            Random r = new Random(seed);

            int n = r.Next(2);
            return (n >= 1) ? true : false;
        }
    }
}
