using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1
{
    internal class Cuenta
    {
        private string titular;
        private double cantidad;
        public string Titular{ get { return titular; } set { titular = value; } } 
        public double Cantidad { get { return cantidad; } set { cantidad = value; } } 
        public Cuenta(string titular)
        {
            Titular = titular;
        }
        public Cuenta(string titular, double cantidad)
        {
            Titular = titular;
            Cantidad = cantidad;
        }
        public void Ingresar(double cantidad)
        {
            if (cantidad >= 0)
                Cantidad += cantidad;
        }
        public void Retirar(double cantidad)
        {
            if (cantidad >= Cantidad)
                Cantidad = 0;
            else
                Cantidad -= cantidad;
        }
    }
}
