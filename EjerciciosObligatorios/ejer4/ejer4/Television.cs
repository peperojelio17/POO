using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer4
{
    public class Television : Electrodomestico
    {
        private int resolucion = 20;
        private bool sintotizadorTDT = false;
        public Television() { }
        public Television(double _precio, double _peso) : base(_precio, _peso) { }
        public Television(double _precio, string _color, char _consumo, double _peso, int _resolucion, bool _TDT) : base(_precio, _color, _consumo, _peso)
        {
            resolucion = _resolucion;
            sintotizadorTDT = _TDT;
        }
        public int Resolucion { get { return resolucion; } }
        public bool SintotizadorTDT { get { return sintotizadorTDT; } }
        public override double precioFinal()
        {
            double extra = base.precioFinal();
            extra *= (resolucion > 40) ? 1.3 : 1;
            extra += (sintotizadorTDT) ? 50 : 0;
            return extra;
        }

    }
}
