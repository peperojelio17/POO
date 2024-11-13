using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaMinas
{
    public class PantallaInicio
    {
        int tiempo;
        List<string> dificultades;
        int w;
        int h;
        int[] posiciones;
        int posTotal;
        Random r;
        List<ConsoleColor> colores;
        ConsoleColor colorTexto;
        public PantallaInicio() 
        {
            colorTexto = ConsoleColor.White;
            r = new Random();
            tiempo = 0;
            posiciones = new int[20];
            posTotal = 0;
            colores = new List<ConsoleColor>() { ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.White, ConsoleColor.Cyan, ConsoleColor.Yellow};
            dificultades = new List<string>() { "facil","medio","dificil"};
            for (int i = 0; i < dificultades.Count; i++) 
            {
                posTotal += dificultades[i].Length + 3;
                posiciones[i] = posTotal;
            }
            w = Console.WindowWidth;
            h = Console.WindowHeight;
        }
        public void dibujar()
        {
            tiempo++;
            if(tiempo >= 1500)
            {
                colorTexto = colores[r.Next(0, colores.Count)];
                tiempo = 0;
            }
                
            Console.ForegroundColor = colorTexto ;
            Console.SetCursorPosition(w/2 - 8, h/2 - 5);
            Console.WriteLine("BUSCA MINAS");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < dificultades.Count; i++)
            {
                Console.SetCursorPosition(w / 2 - posTotal / 2 + posiciones[i] - 8, h / 2);
                Console.WriteLine(dificultades[i]);
            }
            

        }
        public int dificultad()
        {
            return 3;
        }
    }
}
