using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer5
{
    public class Videojuego : IEntregable
    {
        private string titulo = "";
        private int hEstimadas = 10;
        private bool entregado = false;
        private string genero = "";
        private string compañia = "";

        public Videojuego() { }
        public Videojuego(string _titulo, int _horasE) {
            titulo = _titulo;
            hEstimadas = _horasE;
        }
        public Videojuego(string _titulo, int _horasE, string _genero, string _compañia) {
            titulo= _titulo;
            hEstimadas = _horasE;
            genero = _genero;
            compañia = _compañia;
        }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public int HEstimadas { get { return hEstimadas; } set { hEstimadas = value; } }
        public string Genero { get { return genero; } set { genero = value; } }
        public string Compañia { get { return compañia; } set { compañia = value; } }

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
            return HEstimadas.CompareTo(a);
        }
    }
}
