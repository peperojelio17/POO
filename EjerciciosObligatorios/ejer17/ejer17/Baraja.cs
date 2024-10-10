using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer17
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
    public abstract class Baraja
    {
        public List<Carta> mazo;
        private int numCartas;
        private int numCartasPalo;
        public Baraja(int _numCartas, int _numCartasPalo)
        {
            mazo = new List<Carta>();
            numCartas = _numCartas;
            numCartasPalo = _numCartasPalo;
        }
        public abstract void crearCartas();
        
    }
    public class BarajaEspañola : Baraja
    {
        private bool jugar8y9;
        public BarajaEspañola(int _numCartas, int _numCartasPalo) : base(_numCartas, _numCartasPalo)
        {
            jugar8y9 = false;
        }

        public override void crearCartas()
        {
            throw new NotImplementedException();
        }
    }
}
