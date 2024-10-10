using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer17
{
    public class Carta
    {
        static private Random r;
        private char palo;
        private int numero;

        

        public char Palo { get { return palo; } }
        public int Numero { get { return numero; } }
        public Carta()
        {
            r = new Random();
            palo = elegirPalo();
            numero = elegirNumero();
        }
        private char elegirPalo()
        {
            string palos = "EBOC";
            char p = palos[r.Next(4)];
            return p;
        }
        private int elegirNumero()
        {
            int num = 0;
            while (num == 0 || num == 8 || num == 9)
            {
                num = r.Next(1, 13);
            }
            return num;
        }
    }
}
