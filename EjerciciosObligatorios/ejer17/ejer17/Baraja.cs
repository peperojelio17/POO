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
        private Random r;
        public List<Carta> mazo;
        public List<Carta> mazoDeDescarte;
        private int sCarta;

        private int numCartas;
        private int numCartasPalo;

        public int NumCartas { get { return numCartas; } set { numCartas = value; } }
        public int NumCartasPalo { get { return numCartasPalo; } set { numCartasPalo = value; } }
        public Baraja()
        {
            mazo = new List<Carta>();
            mazoDeDescarte = new List<Carta>();
            numCartas = 0;
            numCartasPalo = 0;
            crearCartas();
            sCarta = 0;
            r = new Random();
        }
        public abstract void crearCartas();
        public void barajar()
        {
            Carta temp = new Carta();
            int n;
            for (int i = mazo.Count - 1; i >= 0; i--)
            {
                n = r.Next(0, mazo.Count);
                temp = mazo[i];
                mazo[i] = mazo[n];
                mazo[n] = temp;
            }
            n = 0;
        }
        public int cartasDisponibles()
        {
            return mazo.Count - 1;
        }
        public string siguienteCarta()
        {
            Carta c = new Carta();
            string carta;

            if (0 <= mazo.Count - 1)
            {
                c = mazo[sCarta];
                carta = $"{c.Numero} {c.Palo}";
                mazoDeDescarte.Add(c);
                mazo.Remove(c);
            }
            else carta = "Ya no hay más cartas";
            return carta;
        }
        public string darCartas(int cant)
        {
            string cart = "";
            if (cant <= cartasDisponibles())
            {
                for (int i = 0; i < cant; i++)
                {
                    cart += siguienteCarta() + ", ";
                }
            }
            else cart = $"No hay suficentes cartas, solo hay {cartasDisponibles()} cartas disponibles";
            return cart;
        }
        public string cartasMonton()
        {
            string cartas = "";
            foreach (Carta c in mazoDeDescarte)
            {
                cartas += $"{c.Numero} {c.Palo}, ";
            }
            return cartas;
        }
        public string mostrarBaraja()
        {
            string cartas = "";
            foreach (Carta c in mazo)
            {
                cartas += $"{c.Numero} {c.Palo}, ";
            }
            return cartas;
        }

    }

public class BarajaEspañola : Baraja
    {
        private bool jugar8y9;
        public BarajaEspañola()
        {
            jugar8y9 = false;
        }

        public override void crearCartas()
        {
            Carta c1;
            int esta;
            int cantCartas = 0;
            while (cantCartas != 40)
            {
                esta = 0;
                if (cantCartas != 0)
                {
                    c1 = new Carta();
                    foreach (Carta c in mazo) if (c1.Numero == c.Numero && c1.Palo == c.Palo) esta = 1;
                    if (esta != 1)
                    {
                        mazo.Add(c1);
                        cantCartas++;
                    }
                }
                else
                {
                    c1 = new Carta();
                    mazo.Add(c1);
                    cantCartas++;
                }

            }
        }
    }
    public class BarajaFrancesa : Baraja
    {
        public BarajaFrancesa()
        {
            NumCartas = 52;
            NumCartasPalo = 13;
        }

        public override void crearCartas()
        {
            throw new NotImplementedException();
        }
}
}
