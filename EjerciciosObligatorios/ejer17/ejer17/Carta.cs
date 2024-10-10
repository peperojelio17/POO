using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer17
{
    public class Carta
    {
        enum palosBarFrancesa
        {
            DIAMANTES,
            PICAS,
            CORAZONES,
            TREBOLES
        }
        enum PalosBarEspañola
        {
            OROS,
            COPAS,
            ESPADAS,
            BASTOS
        }
        private List<string> palos = new List<string>();
        static private Random r;
        private string palo;
        private int numero;

        

        public string Palo { get { return palo; } }
        public int Numero { get { return numero; } }
        public Carta(string tipoPalo)
        {
            r = new Random();
            palo = elegirPalo();
            numero = elegirNumero();
            if (tipoPalo == "E")
            {
                //foreach (string s in PalosBarEspañola) {
            }
        }
        private string elegirPalo()
        {
            string palos = "EBOC";
            char p = palos[r.Next(4)];
            return p.ToString();
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
