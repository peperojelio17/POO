using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer11
{
    public class Persona
    {
        private Random r;

        private string nombre;
        private int dinero;
        private Dictionary<int, string> apuestaPartidos;
        public Dictionary<int, string> ApuestaPartidos { get { return apuestaPartidos;} }

        public string Nombre {get{return nombre;} }
        public int Dinero {get{return dinero;} set { dinero = value; } }
        public Persona(string _nombre, int _dinero)
        {
            r = new Random();
            apuestaPartidos = new Dictionary<int, string>();
            nombre = _nombre;
            dinero = _dinero;
        }
        public void apuesta(int partidoIndice)
        {
            var guid = Guid.NewGuid();
            var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 4));
            r = new Random(seed);
            string resultado;
            int n = r.Next(0,100);
            if (n <= 33) resultado = "perdió";
            else if (n > 33 && n < 66) resultado = "ganó";
            else resultado = "empató";
            if(apuestaPartidos.ContainsKey(partidoIndice)) apuestaPartidos[partidoIndice] = resultado;
            else apuestaPartidos.Add(partidoIndice, resultado);
        }
    }
}
