using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer9
{
    public class Cine
    {
        private Pelicula pelicula;
        private int precio;
        public List<string> butacas;
        public List<string> butacasLibres;
        public List<string> butacasOcupadas;
        public Cine(Pelicula p, int pr)
        {
            pelicula = p;
            precio = pr;
            butacas = generarButacas(8,9);
            butacasLibres = generarButacas(8, 9);
            butacasOcupadas = new List<string>();
        }
        private List<string> generarButacas(int filas, int columnas)
        {
            string abecedario = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            List<string> bu = new List<string>() ;
                for (int i = filas; i >= 1; i--) {
                    for (int j = 0; j < columnas; j++)
                    {
                        bu.Add($"{i}{abecedario[j]}");
                    }
                }
            return bu;
        }
        public void dibujar()
        {

            int color = 0;
            Console.WriteLine("Butacas:");
            for (int i = 0; i < butacas.Count; i++)
            {
                color = 0;
                if (i > 0 && butacas[i][0] != butacas[i - 1][0])
                        Console.WriteLine();
                foreach (string b in butacasOcupadas)
                {
                    if (butacas[i] == b)
                        color = 1;
                }
                Console.ForegroundColor = (color == 1) ? ConsoleColor.Red : ConsoleColor.White;

                Console.Write(butacas[i] + ", ");
                

            }
            Console.WriteLine();
        }
        public void sentar(List<Espectador> espectadores)
        {

            var guid = Guid.NewGuid();
            var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 4));
            Random r = new Random(seed);

            int a;
            foreach (Espectador e in espectadores) 
            {
                if (e.Dinero >= precio && e.Edad >= pelicula.EdadMinina && butacasLibres.Count > 1)
                {
                    for (int i = butacasLibres.Count - 1; i >= 0; i--)
                    {
                        foreach (string l in butacasOcupadas)
                        {
                            if (l == butacasLibres[i])
                            {
                                butacasLibres.RemoveAt(i);
                            }
                        }
                    }
                    a = r.Next(butacasLibres.Count - 1);
                    e.Asiento = $"El asiento de {e.Nombre} es: {butacasLibres[a]}";
                    butacasOcupadas.Add(butacasLibres[a]);
                }
                else if (butacasLibres.Count <= 1)
                    e.Asiento = "El espectador no pudo entrar porque el cine esta lleno";
                else if (e.Dinero < precio)
                    e.Asiento = "El espectador no pudo entrar por falta de dinero";
                else
                    e.Asiento = "El espectador no pudo entrar por no tener la edad minima";
            }

        }
    }
}
