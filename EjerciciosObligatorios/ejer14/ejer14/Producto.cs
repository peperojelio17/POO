using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer14
{
    public class Producto
    {
        private string nombre;
        private int precio;

        public int Precio { get { return precio; } set { precio = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public Producto(string _nombre, int _precio)
        {
            nombre = _nombre;
            precio = _precio;
        }
        public virtual int calcular(int cantProductos)
        {
            return precio * cantProductos;
        }
    }
    public class Perecedero : Producto
    {
        private int diasAcaductar;
        public int DiasAcaductar { get { return diasAcaductar; } set { diasAcaductar = value; } }
        public Perecedero(string _nombre, int _precio, int _diasAcaductar) : base(_nombre, _precio)
        {
            diasAcaductar = _diasAcaductar;
        }
        public override int calcular(int cantProductos)
        {
            int precioFinal = base.calcular(cantProductos);
            if (diasAcaductar == 3) precioFinal /= 2;
            if (diasAcaductar < 3) precioFinal /= (diasAcaductar == 2) ? 8 : 16;
            return precioFinal;
        }
    }
    public class NoPerecedero : Producto
    {
        private string tipo;
        public string Tipo { get { return tipo; } set { tipo = value; } }
        public NoPerecedero(string _nombre, int _precio, string _tipo) : base(_nombre, _precio)
        {
            tipo = _tipo;
        }
    }
}
