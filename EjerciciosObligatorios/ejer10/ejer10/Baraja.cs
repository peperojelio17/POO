using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer10
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
            while(num == 0 || num == 8 || num == 9)
            {
                num = r.Next(1, 13);
            }
        return num; 
        }
    }
    public class Baraja
    {
        private Random r;
        public List<Carta> mazo;
        public List<Carta> mazoDeDescarte;
        private int sCarta;
        public Baraja()
        {
            mazo = new List<Carta>();
            mazoDeDescarte = new List<Carta>();
            crearCartas();
            sCarta = 0;
            r = new Random();
        }
        private void crearCartas()
        {
            Carta c1;
            int esta;
            int cantCartas = 0;
            while(cantCartas != 40)
            {
                esta = 0;
                if (cantCartas != 0)
                {
                    c1 = new Carta();
                    foreach (Carta c in mazo) if (c1.Numero == c.Numero && c1.Palo == c.Palo) esta = 1;
                    if(esta != 1)
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
        public void barajar()
        {
            Carta temp = new Carta();
            int n;
            for(int i = mazo.Count - 1; i >= 0; i--)
            {
                n = r.Next(0, mazo.Count);
                temp = mazo[i];
                mazo[i] = mazo[n];
                mazo[n] = temp;
            }
            n= 0;
        }
        public int cartasDisponibles()
        {
            return mazo.Count-1;
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
            foreach (Carta c in mazoDeDescarte) {
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
    
}
