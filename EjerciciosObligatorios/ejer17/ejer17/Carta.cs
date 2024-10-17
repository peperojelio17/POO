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
        public Carta(string _tipo) 
        { 
            r = new Random();

            if (_tipo == "E")
                foreach (PalosBarEspañola f in Enum.GetValues(typeof(PalosBarEspañola)))
                    palos.Add(f.ToString());
            else if (_tipo == "F")
                foreach (palosBarFrancesa f in Enum.GetValues(typeof(palosBarFrancesa)))
                    palos.Add(f.ToString());

            numero = elegirNumero();
            palo = elegirPalo();
        }
        public Carta()
        {
            r = new Random();
            foreach (PalosBarEspañola f in Enum.GetValues(typeof(PalosBarEspañola)))
                palos.Add(f.ToString());
            numero = elegirNumero();
            palo = elegirPalo();
        }
        private int elegirNumero()
        {
            int num = 0;
            while (num == 0)
                 num = r.Next(1, 14);
            return num;
        }
        private string elegirPalo()
        {
            string p = palos[r.Next(palos.Count)];
            return p;
        }
    }
    //public class Carta
    //{
    //    enum palosBarFrancesa
    //    {
    //        DIAMANTES,
    //        PICAS,
    //        CORAZONES,
    //        TREBOLES
    //    }
    //    enum PalosBarEspañola
    //    {
    //        OROS,
    //        COPAS,
    //        ESPADAS,
    //        BASTOS
    //    }
    //    private List<string> palos = new List<string>();
    //    static private Random r;
    //    private char palo;
    //    private int numero;

    //    public char Palo { get { return palo; } }
    //    public int Numero { get { return numero; } }
    //    public Carta()
    //    {
    //        r = new Random();
    //        palo = elegirPalo();
    //        numero = elegirNumero();
    //    }
    //    private char elegirPalo()
    //    {
    //        string palos = "EBOC";
    //        char p = palos[r.Next(4)];
    //        return p;
    //    }
    //    private int elegirNumero()
    //    {
    //        int num = 0;
    //        while (num == 0 || num == 8 || num == 9)
    //        {
    //            num = r.Next(1, 13);
    //        }
    //        return num;
    //    }
    //}
}
