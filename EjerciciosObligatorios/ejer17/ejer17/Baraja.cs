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
        private string tipo;

        private int numCartasTotal;
        private int numCartasPalo;

        public string Tipo { get { return tipo; } set { tipo = value; } }
        public int NumCartasTotal { get { return numCartasTotal; } set { numCartasTotal = value; } }
        public int NumCartasPalo { get { return numCartasPalo; } set { numCartasPalo = value; } }
        public Baraja()
        {
            r = new Random();

            mazo = new List<Carta>();
            mazoDeDescarte = new List<Carta>();
            sCarta = 0;
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
            if (tipo == "E")
            {
                foreach (Carta c in mazo)
                {
                    if (c.Numero == 10) cartas += $"Sota de {c.Palo}, ";
                    else if (c.Numero == 11) cartas += $"Caballo de {c.Palo}, ";
                    else if (c.Numero == 12) cartas += $"Rey de {c.Palo}, ";
                    else if (c.Numero == 1) cartas += $"As de {c.Palo}, ";
                    else cartas += $"{c.Numero} {c.Palo}, ";
                }
            }
            else
            {
                foreach (Carta c in mazo)
                {
                    if (c.Numero == 11) cartas += $"Jota de {c.Palo}, ";
                    else if (c.Numero == 12) cartas += $"Reina de {c.Palo}, ";
                    else if (c.Numero == 13) cartas += $"Rey de {c.Palo}, ";
                    else if (c.Numero == 1) cartas += $"As de {c.Palo}, ";
                    else cartas += $"{c.Numero} {c.Palo}, ";
                }
            }
            
            return cartas;
        }
    }
    public class BarajaEspañola : Baraja
    {
        private bool jugar8y9;
        public BarajaEspañola(bool _jugar8y9)
        {
            Tipo = "E";
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
                c1 = new Carta("E");
                if (mazo.Count != 0)
                {
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
        public BarajaFrancesa()
        {
            Tipo = "F";
            NumCartasTotal = 52;
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
                c1 = new Carta("F");
                if(mazo.Count != 0)
                {
                    foreach(Carta c in mazo) if (c1.Numero == c.Numero && c1.Palo == c.Palo) invalida = 1;
                    if (invalida != 1)
                        mazo.Add(c1);
                }
                else mazo.Add(c1);
            }
        }
        public void cartaRoja(Carta carta)
        {
            if (carta.Palo == "CORAZONES")
                Console.WriteLine("La carta es de corazones");
            else if (carta.Palo == "DIAMANTES")
                Console.WriteLine("La carta es de diamantes");
            else 
                Console.WriteLine("La carta no se roja");
        }
        public void cartaNegra(Carta carta)
        {
            if (carta.Palo == "TREBOLES")
                Console.WriteLine("La carta es de treboles");
            else if (carta.Palo == "PICAS")
                Console.WriteLine("La carta es de picas");
            else
                Console.WriteLine("La carta no se negra");
        }
    }
}
