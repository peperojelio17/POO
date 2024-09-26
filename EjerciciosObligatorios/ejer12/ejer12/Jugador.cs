using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
    public class Jugador
    {
        private int id;
        private string nombre;
        private bool vivo;

        public bool Vivo { get { return vivo; } }
        public string Nombre { get { return nombre; } }
        public Jugador(int _id)
        {
            id = _id;
            nombre = $"Jugador {_id}";
            vivo = true;
        }
        public void disparar(Revolver r)
        {
            vivo = (r.disparar()) ? false : true;
            r.siguienteBala();
        }
    }
}
