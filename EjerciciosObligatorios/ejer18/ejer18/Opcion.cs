using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer18
{
    public class Opcion
    {
        private string texto;
        private bool esCorrecta;

        public string Texto{ get { return texto; } }
        public bool EsCorrecta { get { return esCorrecta; } }
        public Opcion(string _texto, bool _esCorrecta)
        {
            texto = _texto;
            esCorrecta = _esCorrecta;
        }
    }
}
