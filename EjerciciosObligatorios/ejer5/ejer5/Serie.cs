using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer5
{
    public class Serie : IEntregable
    {
        private string titulo = "";
        private int numTemporadas = 3;
        private bool entregado = false;
        private string genero = "";
        private string creador = "";
        public Serie() { }
        public Serie(string _titulo, string _creador) {
            titulo = _titulo;
            creador = _creador;
        }
        public Serie(string _titulo, int _numTemporadas, string _genero, string _creador)
        {
            titulo = _titulo;
            numTemporadas = _numTemporadas;
            genero = _genero;
            creador = _creador;
        }
        public string Titulo {  get { return titulo; } set { titulo = value; } }
        public int NumTemporadas { get { return numTemporadas; } set { numTemporadas = value; } }
        public string Genero {  get { return genero; } set { genero = value; } }
        public string Creador { get { return creador; } set { creador = value; } }

        public void entregar()
        {
            entregado = true;
        }

        public void devolver()
        {
            entregado = false;
        }


        public bool isEntregado()
        {
            return entregado;
        }
        public int compareTo(int a)
        {
            return numTemporadas.CompareTo(a);

        }
    }
}
