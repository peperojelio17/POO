using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer17
{
    public class Carta<P>
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
        public Carta()
        {
            palos = new List<string>();
            r = new Random();
            palo = elegirPalo();
            numero = elegirNumero();
            foreach (PalosBarEspañola f in Enum.GetValues(typeof(PalosBarEspañola)))
                palos.Add(f.ToString());
        }
        public Carta(P tipoPalo)
        {
            palos = new List<string>();
            r = new Random();
            palo = elegirPalo();
            numero = elegirNumero();
            if (tipoPalo.ToString() == "PalosBarEspañola")
                foreach (PalosBarEspañola f in Enum.GetValues(typeof(PalosBarEspañola)))
                    palos.Add(f.ToString());
            else if(tipoPalo.ToString() == "PalosBarEspañola")
                foreach (palosBarFrancesa f in Enum.GetValues(typeof(palosBarFrancesa)))
                    palos.Add(f.ToString());
        }
        private string elegirPalo()
        {
            string p = palos[r.Next(palos.Count)];
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
