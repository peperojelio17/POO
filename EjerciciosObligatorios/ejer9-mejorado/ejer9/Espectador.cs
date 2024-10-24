using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer9
{
    public class Espectador
    {
        private string nombre;
        private int edad;
        private int dinero;
        private string asiento;

        public string Nombre { get { return nombre; } }
        public int Edad { get { return edad; } }
        public int Dinero { get { return dinero; } }
        public string Asiento { get { return asiento; } set { asiento = value; } }
        public Espectador(string nombre, int edad, int dinero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dinero = dinero;
            asiento = "";
        }

    }
}
