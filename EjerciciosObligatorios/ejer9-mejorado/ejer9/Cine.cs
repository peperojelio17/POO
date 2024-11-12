using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejer9
{
    public class Cine
    {
        private int posicionXbutacas;
        private int posicionYbutacas;

        private Pelicula pelicula;
        private int precio;
        public List<string> butacas;
        public List<string> butacasLibres;
        public List<string> butacasOcupadas;
        public Cine(Pelicula p, int pr)
        {
            posicionXbutacas = 30;
            posicionYbutacas = 6;

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
            posicionXbutacas = 30;
            posicionYbutacas = 6;
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("Sala:");
            for (int i = 0; i < butacas.Count; i++)
            {
                
                color = 0;
                if (i > 0 && butacas[i][0] != butacas[i - 1][0])
                {
                    posicionYbutacas++;
                    posicionXbutacas = 30;
                }
                foreach (string b in butacasOcupadas)
                {
                    if (butacas[i] == b)
                        color = 1;
                }
                posicionXbutacas += 4;
                Console.SetCursorPosition(posicionXbutacas, posicionYbutacas);
                Console.ForegroundColor = (color == 1) ? ConsoleColor.Green : ConsoleColor.White;
                Console.Write(butacas[i] + ",");
                

            }
            Console.WriteLine();
        }
        public void sentar(List<Espectador> espectadores)
        {
            var guid = Guid.NewGuid();
            var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 4));
            Random r = new Random(seed);
            int espectadoresNoSentados = espectadores.Count;

            int a;
            foreach (Espectador e in espectadores) 
            {
                Console.SetCursorPosition(0, 1);
                Console.WriteLine($"Se tienen que sentar: {espectadoresNoSentados} espectadores");
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
                    animacionSentar(butacasLibres[a]);
                    butacasOcupadas.Add(butacasLibres[a]);
                    dibujar();
                }
                else if (butacasLibres.Count <= 1)
                    e.Asiento = "El espectador no pudo entrar porque el cine esta lleno";
                else if (e.Dinero < precio)
                    e.Asiento = "El espectador no pudo entrar por falta de dinero";
                else
                    e.Asiento = "El espectador no pudo entrar por no tener la edad minima";
                espectadoresNoSentados--;
                Console.SetCursorPosition(0, 1);
                Console.WriteLine($"Se tienen que sentar: {espectadoresNoSentados} espectadores");
                dibujar();

            }
            Console.SetCursorPosition(45, 15);
            Console.Write("           ");
        }
        private void animacionSentar(string butaca)
        {
            int sentAnimacion = 0;
            int sentando = 0;


            posicionXbutacas = 34;
            posicionYbutacas = 6;
            string letras = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            int Ynumero = int.Parse(butaca[0].ToString());
            char letra = butaca[1];
            int XnumLetra = 0;
            for (int i = 0; i < letras.Length; i++)
                if(letras[i] == letra)
                    XnumLetra = i;


            string persona = "O";
            int personaPosX = 0;
            int personaPosY = posicionYbutacas;
            int tempX = 0;
            int tempY = 0;
            int tiempo = 0;

            XnumLetra = posicionXbutacas + XnumLetra * 4;
            Ynumero = posicionYbutacas + 8 - Ynumero;

            while(personaPosX != XnumLetra || personaPosY != Ynumero)
            {
                Thread.Sleep(100);
                tempX = personaPosX;
                tempY = personaPosY;

                if (personaPosX < XnumLetra) personaPosX++;
                else if (personaPosX > XnumLetra) personaPosX--;

                if (personaPosY < Ynumero) personaPosY++;
                else if (personaPosY > Ynumero) personaPosY--;


                Console.SetCursorPosition(tempX, tempY);
                Console.Write(" ");
                dibujar();
                Console.SetCursorPosition(personaPosX, personaPosY);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(persona);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(45, 15);
                if(sentAnimacion == 0)
                {
                    if (sentando == 0) Console.Write("Sentando   ");
                    if (sentando == 1) Console.Write("Sentando.  ");
                    if (sentando == 2) Console.Write("Sentando.. ");
                    if (sentando == 3) Console.Write("Sentando...");
                    if (sentando < 3) sentando++;
                    else sentando = 0;
                }
                sentAnimacion++;
                if (sentAnimacion == 3) sentAnimacion = 0;


            }


            //Console.WriteLine(persona);

        }
    }
}
