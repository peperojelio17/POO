using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer7
{
    public class Raices
    {
        private int a;
        private int b;
        private int c;
        public Raices(int _a, int _b, int _c) 
        {
            a = _a;
            b = _b;
            c = _c;
        }
        

        public void obtenerRaices()
        {
            if (tieneRaices())
            {
                double num1 = (-b + Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
                double num2 = (-b - Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
                Console.WriteLine($"Las raices son: x1 = {num1} --- x2 = {num2}");
            }
        }
        public void obtenerRaiz()
        {
            if (tieneRaiz())
            {
                double num = -b / (2 * a);
                Console.WriteLine($"La raiz es: x = {num}");
            }
        }
        public double getDiscriminante()
        {
            return (b * b) - 4 * a * c;
        }
        public bool tieneRaices() {
            if (getDiscriminante() > 0)
                return true;
            else
                return false; 
        }
        public bool tieneRaiz() {
            if (getDiscriminante() == 0)
                return true;
            else
                return false;
        }
        public void calcular()
        {
            if (tieneRaices())
                obtenerRaices();
            else if (tieneRaiz())
                obtenerRaiz();
            else
                Console.WriteLine("La ecuación no tiene raices.");

        }
    }
}
