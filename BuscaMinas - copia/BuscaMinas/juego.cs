using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BuscaMinas
{
    internal class Juego
    {
        Random r;
        int filas, columnas, m;
        Dictionary<Posicion, string> terreno;
        List<Posicion> minas;
        List<Posicion> posicionesRotas;
        List<Posicion> posicionesMarcadas;

        Posicion jugador;
        ConsoleColor colorJugador;

        bool perdiste = false;
        public Juego(int filas, int columnas,int minas)
        {
            r = new Random();
            this.filas = filas;
            this.columnas = columnas;
            m = minas;
            terreno = rellenarTerreno(filas, columnas);
            this.minas = new List<Posicion>();
            posicionesRotas = new List<Posicion>();
            posicionesMarcadas = new List<Posicion>();
            for (int i = 0; i < minas; i++)
                agregarMinas();
            comprobar();

            jugador = new Posicion(0, 0);
            colorJugador = ConsoleColor.White;
        }


        //--------metodos----------
        private void agregarMinas() 
        {
            int x = r.Next(0, columnas);
            int y = r.Next(0, filas);
            int e = 0;
            bool existe = true;

            while (existe)
            {
                foreach (Posicion i in minas)
                    if (i == new Posicion(x, y)) e = 1;
                if(e != 1) existe = false;
                x = r.Next(0, columnas);
                y = r.Next(0, filas);
            }
            minas.Add(new Posicion(x, y));
        }

        private Dictionary<Posicion, string> rellenarTerreno(int filas, int columnas)
        {
            Dictionary<Posicion, string> t = new Dictionary<Posicion, string>();

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    t.Add(new Posicion(c, f), " ");
                }
            }
            return t;
        }
        private void comprobar()
        {
            List<Posicion>posMinas = new List<Posicion>();
            Posicion posMina = new Posicion(0,0);
            bool mina = false;
            foreach (var t in terreno)
            {
                mina = false;
                foreach (Posicion m in minas)
                {
                    if (t.Key.X == m.X && t.Key.Y == m.Y) mina = true;
                }
                if (mina) posMinas.Add(t.Key);
            }
            foreach (Posicion pos in posMinas)
            {
                terreno[pos] = "0";
            }
            ponerNumeros();
        }

        private void ponerNumeros()
        {
            Dictionary<Posicion, int> numeros = new Dictionary<Posicion, int>();
            Posicion p = new Posicion(0,0);
            int num = 0;
            int iF = 0;
            int fF = 0;
            int iC = 0;
            int fC = 0;
            foreach (var t in terreno) 
            {
                iC = (t.Key.X != 0) ? -1 : 0;
                fC = (t.Key.X != columnas - 1) ? 1 : 0;
                iF = (t.Key.Y != 0) ? -1 : 0;
                fF = (t.Key.Y != filas - 1) ? 1 : 0;
                num = 0;
                if (t.Value != "0")
                {
                    for (int i = iC; i <= fC; i++)
                    {
                        for (int e = iF; e <= fF; e++)
                        {
                            p = new Posicion(t.Key.X + i, t.Key.Y + e);
                            foreach(var mat in terreno)
                            {
                                if(mat.Key.X == p.X &&  mat.Key.Y == p.Y && mat.Value == "0") num++;
                            }
                        }
                    }
                }
                if(num != 0)
                {
                    numeros.Add(t.Key, num);
                }
            }
            foreach(var pos in numeros)
            {
                terreno[pos.Key] = $"{pos.Value}";
            }
        }
        public void dibujar()
        {
            bool rota = false;
            bool marcada = false;
            int espacio = 0;
            foreach (var t in terreno)
            {
                rota = false;
                marcada = false;
                foreach (var pos in posicionesMarcadas)
                    if (t.Key.X == pos.X && t.Key.Y == pos.Y) marcada = true;
                foreach (var pos in posicionesRotas)
                    if (t.Key.X == pos.X && t.Key.Y == pos.Y) rota = true;
                //--------Donde esta el jugador--------
                Console.BackgroundColor = (t.Key.X == jugador.X && t.Key.Y == jugador.Y) ? colorJugador: ConsoleColor.Black;
                Console.ForegroundColor = (t.Key.X == jugador.X && t.Key.Y == jugador.Y) ? ConsoleColor.Black : ConsoleColor.Green;

                //--------los lugares donde puede estar las minas--------
                if (t.Key.X == 0) espacio = 0;
                Console.SetCursorPosition(t.Key.X + espacio, t.Key.Y);
                if (marcada)
                    Console.ForegroundColor = ConsoleColor.Red;
                if (rota) 
                { 
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(t.Value);
                }
                else Console.Write("X");
                espacio++;
            }

            foreach (var t in terreno)
            {
                //--------los lugares donde puede estar las minas--------
                if (t.Key.X == 0) espacio = 0;
                Console.SetCursorPosition(t.Key.X + espacio + 25, t.Key.Y);
                Console.ForegroundColor = (t.Value == "0") ? ConsoleColor.Red : ConsoleColor.White;

                Console.Write(t.Value);
                espacio++;
            }
            //Console.SetCursorPosition(0, 7);
            //foreach (var m in posicionesMarcadas)
            //{
            //    Console.WriteLine($"{m.X} - {m.Y}");
            //}
            //Console.SetCursorPosition(0, 10);
            //foreach (var m in minas)
            //{
            //    Console.WriteLine($"{m.X} - {m.Y}");
            //}
        }
        public void moverse()
        {
            if (Console.KeyAvailable)
            {
                var tecla = Console.ReadKey(true).Key;
                if (!perdiste)
                {
                    switch (tecla)
                    {
                        case ConsoleKey.D:
                            derecha();
                            break;
                        case ConsoleKey.A:
                            izquierda();
                            break;
                        case ConsoleKey.W:
                            arriba();
                            break;
                        case ConsoleKey.S:
                            abajo();
                            break;
                        case ConsoleKey.Enter:
                            presionar();
                            break;
                        case ConsoleKey.E:
                            marcar();
                            break;
                        case ConsoleKey.R:
                            restart();
                            break;
                    }
                }
                else
                {
                    if(tecla == ConsoleKey.R)
                        restart();
                }
            }
        }
        private void derecha()
        {
            jugador.X = (jugador.X < columnas - 1) ? jugador.X + 1: 0;
        }
        private void izquierda()
        {
            jugador.X = (jugador.X > 0) ? jugador.X - 1: columnas - 1;
        }
        private void arriba()
        {
            jugador.Y = (jugador.Y > 0) ? jugador.Y - 1 : filas - 1;
        }
        private void abajo()
        {
            jugador.Y = (jugador.Y < filas - 1) ? jugador.Y + 1 : 0;
        }
        private void marcar()
        {
            bool yaEstaMarcado = false;
            Posicion estamarcado = new Posicion(0,0);
            foreach(var t in posicionesMarcadas)
            {
                if (t.X == jugador.X && t.Y == jugador.Y)
                {
                    yaEstaMarcado = true;
                    estamarcado = t;
                }
            }
            foreach (var t in terreno)
            {
                if (t.Key.X == jugador.X && t.Key.Y == jugador.Y)
                {
                    if (yaEstaMarcado)
                        posicionesMarcadas.Remove(estamarcado);
                    else
                        posicionesMarcadas.Add(new Posicion(t.Key.X, t.Key.Y));
                        
                }
                    
            }
                
        }
        private void presionar() 
        {
            bool yaExiste = false;
            foreach (var t in terreno)
            {
                if(t.Key.X == jugador.X && t.Key.Y == jugador.Y)
                {
                    romper(t);
                    yaExiste = false;
                    foreach (var p2 in posicionesRotas)
                    {
                        if (p2.X == jugador.X && p2.Y == jugador.Y)
                        {
                            yaExiste = true;
                        }
                    }
                    if(!yaExiste)posicionesRotas.Add(new Posicion(t.Key.X, t.Key.Y));
                    if (t.Value == "0")
                    {
                        colorJugador = ConsoleColor.Green;
                        perder();
                    }
                    else colorJugador = ConsoleColor.White;
                }
            }
        }
        private void perder()
        {
            perdiste = true;
            Console.SetCursorPosition(0, 14);
            Console.WriteLine("PERDISTE");
        }
        private void restart()
        {
            Console.Clear();
            perdiste = false;
            terreno = rellenarTerreno(filas, columnas);
            this.minas = new List<Posicion>();
            posicionesRotas = new List<Posicion>();
            posicionesMarcadas = new List<Posicion>();
            for (int i = 0; i < m; i++)
                agregarMinas();
            comprobar();

            jugador = new Posicion(0, 0);
        }

        public void revisarSiGanaste()
        {
            int totalterreno = terreno.Count;
            if (totalterreno - posicionesRotas.Count == m)
                ganaste();
        }
        private void ganaste()
        {
            perdiste = true;
            Console.SetCursorPosition(0, 14);
            Console.WriteLine("Ganaste");
        }
        private void romper(KeyValuePair<Posicion,string> t)
        {
            List<Posicion> posEntraron = new List<Posicion>();
            List<Posicion> nPosEntraron = new List<Posicion>();
            int entraron = 0;
            bool yaExiste = false;
            Posicion p = new Posicion(0, 0);
            int iC = (t.Key.X != 0) ? -1 : 0;
            int fC = (t.Key.X != columnas - 1) ? 1 : 0;
            int iF = (t.Key.Y != 0) ? -1 : 0;
            int fF = (t.Key.Y != filas - 1) ? 1 : 0;
            if (t.Value == " ")
            {
                for (int i = iC; i <= fC; i++)
                {
                    for (int e = iF; e <= fF; e++)
                    {
                        p = new Posicion(t.Key.X + i, t.Key.Y + e);
                        foreach (var mat in terreno)
                        {
                            if (mat.Key.X == p.X && mat.Key.Y == p.Y)
                            {
                                yaExiste = false;
                                foreach (var p2 in posicionesRotas)
                                {
                                    if (p2.X == p.X && p2.Y == p.Y) { 
                                        yaExiste = true; 
                                    }
                                }
                                if(!yaExiste) posicionesRotas.Add(new Posicion(mat.Key.X, mat.Key.Y));
                                if(mat.Value == " ")
                                {
                                    entraron++;
                                    posEntraron.Add(mat.Key);
                                }
                            }
                                
                        }
                    }
                }
            }
            while(entraron != 0)
            {
                nPosEntraron = new List<Posicion>();
                entraron = 0;
                foreach (var pe in posEntraron)
                {
                    iC = (pe.X != 0) ? -1 : 0;
                    fC = (pe.X != columnas - 1) ? 1 : 0;
                    iF = (pe.Y != 0) ? -1 : 0;
                    fF = (pe.Y != filas - 1) ? 1 : 0;
                    if (t.Value == " ")
                    {
                        for (int i = iC; i <= fC; i++)
                        {
                            for (int e = iF; e <= fF; e++)
                            {
                                yaExiste = false;
                                p = new Posicion(pe.X + i, pe.Y + e);
                                foreach (var p2 in posicionesRotas)
                                {
                                    if(p2.X == p.X && p2.Y == p.Y) yaExiste = true;
                                }
                                foreach (var mat in terreno)
                                {
                                    if (mat.Key.X == p.X && mat.Key.Y == p.Y && !yaExiste)
                                    {
                                        posicionesRotas.Add(new Posicion(mat.Key.X, mat.Key.Y));
                                        if (mat.Value == " ")
                                        {
                                            nPosEntraron.Add(mat.Key);
                                        }
                                        entraron++;
                                    }
                                }
                            }
                        }
                    }
                }
                posEntraron = nPosEntraron;
                
            }
        }
        //private void romper(KeyValuePair<Posicion,string> t)
        //{
        //    int iC = (t.Key.X != 0) ? -1 : 0;
        //    int fC = (t.Key.X != columnas - 1) ? 1 : 0;
        //    int iF = (t.Key.Y != 0) ? -1 : 0;
        //    int fF = (t.Key.Y != filas - 1) ? 1 : 0;
        //    if (t.Value == " ")
        //    {
        //        for (int i = iC; i <= fC; i++)
        //        {
        //            for (int e = iF; e <= fF; e++)
        //            {
        //                p = new Posicion(t.Key.X + i, t.Key.Y + e);
        //                foreach (var mat in terreno)
        //                {
        //                    if (mat.Key.X == p.X && mat.Key.Y == p.Y)
        //                        posicionesMarcadas.Add(new Posicion(mat.Key.X, mat.Key.Y));
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
