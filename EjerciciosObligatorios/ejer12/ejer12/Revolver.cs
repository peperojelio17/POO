using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
    public class Revolver
    {
        private Random r;
        private int posicionActual;
        private int posicionBala;
        public Revolver()
        {
            r = new Random();
            this.posicionActual = r.Next(0,6);
            this.posicionBala = r.Next(0, 6); ;
        }
        //public bool disparar()
        //{
        //    return (posicionActual == posicionBala) ? true: false;
        //}
        //public void siguienteBala()
        //{
        //    posicionActual = (posicionActual < 6) ? posicionActual + 1 : 0;
        //}
        public bool disparar() => (posicionActual == posicionBala) ? true: false;
        public void siguienteBala() => posicionActual = (posicionActual < 6) ? posicionActual + 1 : 0;
    }
}
