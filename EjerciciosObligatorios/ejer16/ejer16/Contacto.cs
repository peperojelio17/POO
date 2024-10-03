using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer16
{
    public class Contacto
    {
        private string nombre;
        private int telefono;

        public string Nombre { get { return nombre; } }
        public int Telefono { get { return telefono; } }
        public Contacto(string _nombre, int _telefono) 
        { 
            nombre = _nombre;
            telefono = _telefono;
        }
    }
}
