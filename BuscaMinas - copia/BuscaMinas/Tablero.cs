using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace BuscaMinas
{
    
    public class Tablero
    {
        Juego j;
        PantallaInicio pa;
        int f;
        int c;
        int m;
       public Tablero(int filas, int columnas, int minas) 
       {
            pa = new PantallaInicio();
            j = new Juego(filas, columnas, minas);
            f = filas;
            c = columnas;
            m = minas;
       }
        public void ejecutarJuego()
        {
            while (true) 
            {
                pa.dibujar();
            }
            while (true)
            {
                j.revisarSiGanaste();
                j.moverse();
                j.dibujar();
            }
        }
    }
}
