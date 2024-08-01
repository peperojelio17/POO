using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer4
{
    public class Lavadora : Electrodomestico
    {
        private int carga = 5;
        public Lavadora() { }
        public Lavadora(double _precio, double _peso) : base(_precio, _peso)
        {
        }
        public Lavadora(double _precio, string _color, char _consumo, double _peso, int _carga) : base(_precio, _color, _consumo, _peso)
        {
            carga = _carga;
        }
        public int Carga { get { return carga; } }
        public override double precioFinal()
        {
            double extra = base.precioFinal();
            extra += (carga > 30) ? 50 : 0;
            return extra;
        }
    }
}
