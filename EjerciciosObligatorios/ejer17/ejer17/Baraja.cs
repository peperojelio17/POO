using ejer17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer17
{

    public abstract class Baraja
    {
        public List<Carta> mazo;
        public List<Carta> mazoDeDescarte;
        private int sCarta;

        private int numCartasTotal;
        private int numCartasPalo;

        public int NumCartasTotal { get { return numCartasTotal; } set { numCartasTotal = value; } }
        public int NumCartasPalo { get { return numCartasPalo; } set { numCartasPalo = value; } }
        public Baraja()
        {
            mazo = new List<Carta>();
            mazoDeDescarte = new List<Carta>();
            sCarta = 0;
        }
        public abstract void crearCartas();
    }
    public class BarajaEspañola : Baraja
    {
        private bool jugar8y9;
        public BarajaEspañola(bool _jugar8y9)
        {
            jugar8y9 = _jugar8y9;
            NumCartasTotal = jugar8y9 ? 48 : 40;
            NumCartasPalo = NumCartasTotal / 4;
            crearCartas();
        }
        public override void crearCartas()
        {
            Carta c1;
            int invalida;
            while(mazo.Count != NumCartasTotal)
            {
                invalida = 0;
                if (mazo.Count != 0)
                {
                    c1 = new Carta("E");
                    foreach (Carta c in mazo)
                    {
                        if (jugar8y9)
                        {
                            if ((c1.Numero == c.Numero && c1.Palo == c.Palo) || c1.Numero > 12) invalida = 1;
                        }
                        else
                        {
                            if ((c1.Numero == c.Numero && c1.Palo == c.Palo) || c1.Numero == 9 || c1.Numero == 8 || c1.Numero > 12) invalida = 1;
                        }
                    }
                    if (invalida != 1)
                        mazo.Add(c1);
                }
                else
                {
                    c1 = new Carta("E");
                    if (jugar8y9)
                    {
                        if (c1.Numero <= 12)
                            mazo.Add(c1);
                    }
                    else
                    {
                        if (c1.Numero != 9 && c1.Numero != 9 && c1.Numero <= 12)
                            mazo.Add(c1);
                    }
                }
            }
        }
    }
    public class BarajaFrancesa : Baraja
    {
        public override void crearCartas()
        {
            throw new NotImplementedException();
        }
    }
}
