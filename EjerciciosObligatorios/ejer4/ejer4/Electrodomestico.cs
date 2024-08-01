using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer4
{
    public class Electrodomestico
    {
        static private string[] colores = {"blanco", "negro", "rojo", "azul" , "gris"};
        private string consumo = "ABCDEF";
        private double precioBase = 100;
        private string color = colores[0];
        private char consumoEnergetico = 'F';

        private double peso = 5;

        public Electrodomestico() { }
        public Electrodomestico(double _precio, double _peso) {
            precioBase = _precio;
            peso = _peso;
        }
        public Electrodomestico(double _precio, string _color, char _consumo, double _peso) {
            precioBase = _precio;
            color = comprobarColor(_color.ToLower());
            consumoEnergetico = comprobarConsumoEnergetico(_consumo);
            peso = _peso;
        }

        public double PrecioBase { get { return precioBase; } }
        public string Color { get { return color; }  }
        public char ConsumoEnergetico { get { return consumoEnergetico; } }
        public double Peso { get { return peso; } }

        private char comprobarConsumoEnergetico(char letra)
        {
            int l = 0;
            foreach (var c in consumo)
                l = (c == letra) ? 1 : l;
            letra = (l == 0) ? 'F' : letra;
            return letra;
        }
        private string comprobarColor(String color)
        {
            int si = 0;
            foreach (var c in colores)
                si = (c == color) ? 1 : si;
            color = (si == 0) ? colores[0] : color;
            return color; 
        }
        public virtual double precioFinal()
        {
            double precioF = precioBase;
            switch (consumoEnergetico)
            {
                case 'A':
                    precioF += 100;
                    break;
                case 'B':
                    precioF += 80;
                    break;
                case 'C':
                    precioF += 60;
                    break;
                case 'D':
                    precioF += 50;
                    break;
                case 'E':
                    precioF += 30;
                    break;
                case 'F':
                    precioF += 10;
                    break;
            }

            if(peso >= 0 &&  peso <=19 )
                precioF += 10;
            else if (peso >= 20 && peso <= 49)
                precioF += 50;
            else if (peso >= 50 && peso <= 79)
                precioF += 80;
            else
                precioF += 100;
            return precioF;
        }
    }
}
