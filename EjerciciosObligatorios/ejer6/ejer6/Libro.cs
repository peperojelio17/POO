using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer6
{
    public class Libro
    {
        private long isbn;
        private string titulo;
        private string autor;
        private int numPaginas;
        public Libro() {
            isbn = 0;
            titulo = "";
            autor = "";
            numPaginas = 0;
        }
        public Libro(long _isbn, string _titulo, string _autor, int _numPaginas )
        {
            isbn = _isbn;
            titulo = _titulo;
            autor = _autor;
            numPaginas = _numPaginas;
        }

        public long ISBN { get { return isbn; } set { isbn = value; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string Autor { get { return autor; } set { autor = value; } }
        public int NumPaginas { get { return numPaginas; } set { numPaginas = value; } }

        public void mostrarInformacion()
        {
            Console.WriteLine($"El libro {titulo} con ISBN {isbn} creado por el autor {autor} tiene {numPaginas} paginas");
        }


    }
}
