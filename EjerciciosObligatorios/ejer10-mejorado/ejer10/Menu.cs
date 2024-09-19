using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer10
{
    public class Menu
    {
        Baraja mazo;
        private string[] opciones = { "Mostrar_mazo","Barajar","Una_carta","Cant_cartas_disponibles", "Cartas_descartadas","Dar_cartas" };
        private Dictionary<int, string> opcionesPosicion;
        List<string> cartasD;
        private int pos;
        private int temp;
        private bool presionoDosVeces;
        private int itemSelccionado;
        private int lineaC;
        private int columC;
        private int inicioL;
        private bool nuevaLinea;
        private int c;
        private int cantFilas;
        public Menu(Baraja _mazo) 
        {
            cartasD = new List<string>();

            cantFilas = 0;
            c = 0;
            inicioL = 0;
            nuevaLinea = false;
            lineaC = 1;
            columC = 0;
            mazo = _mazo;
            itemSelccionado = 0;
            pos = 0;
            temp = 10;
            presionoDosVeces = true;
            opcionesPosicion = new Dictionary<int, string>();
            foreach (string opcion in opciones) {
                opcionesPosicion.Add(pos,opcion);
                pos += opcion.Length + 2;
            }
        }
        public void dibujar()
        {
            
            foreach (var i in opcionesPosicion) {

                Console.SetCursorPosition(i.Key,0);
                if (i.Value == opciones[itemSelccionado])
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else 
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write(i.Value);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public void derecha()
        {
            foreach (var i in opcionesPosicion)
            {
                Console.SetCursorPosition(i.Key, 0);
                if (i.Value == opciones[itemSelccionado])
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(i.Value);
                }
            }
            itemSelccionado++;
            if (itemSelccionado + 1 > opcionesPosicion.Count)
                itemSelccionado = 0;
            dibujar();
        }
        public void izquierda()
        {
            foreach (var i in opcionesPosicion)
            {
                Console.SetCursorPosition(i.Key, 0);
                if (i.Value == opciones[itemSelccionado])
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(i.Value);
                }
            }
            itemSelccionado--;
            if (itemSelccionado < 0)
                itemSelccionado = opcionesPosicion.Count - 1;
            dibujar();
        }
        public void controles(ConsoleKeyInfo tecla)
        {
            
                if (tecla.Key == ConsoleKey.RightArrow)
                    derecha();
                if (tecla.Key == ConsoleKey.LeftArrow)
                    izquierda();
                if (tecla.Key == ConsoleKey.Enter)
                funcionesBaraja();
        }
        public void funcionesBaraja()
        {
            if (temp != itemSelccionado || presionoDosVeces)
            {
                Console.Clear();
                dibujar();
                Console.SetCursorPosition(0, 1);
                if (itemSelccionado == 0)
                {
                    cartasD = mazo.mostrarBaraja();
                    cantFilas = 0;
                    for (int i = 0; i < cartasD.Count; i++)
                    {
                        dibujarCarta(cartasD[i], i);
                    }
                    //Console.WriteLine(mazo.mostrarBaraja());
                    presionoDosVeces = false;
                }
                if (itemSelccionado == 1)
                {
                    mazo.barajar();
                }
                if (itemSelccionado == 2)
                {
                    string h = mazo.siguienteCarta();
                    if (h != "Ya no hay más cartas")
                        dibujarCarta(h);
                    else Console.WriteLine("Ya no hay más cartas");
                }
                if (itemSelccionado == 3)
                {
                    Console.WriteLine(mazo.cartasDisponibles());
                }
                if (itemSelccionado == 4)
                {
                    //Console.WriteLine(mazo.cartasMonton());
                    cartasD = mazo.cartasMonton();
                    cantFilas = 0;
                    for (int i = 0; i < cartasD.Count; i++)
                    {
                        dibujarCarta(cartasD[i], i);
                    }
                }
                if (itemSelccionado == 5)
                {
                    cuantasCartas();
                }
            }
            else if (!presionoDosVeces)
            {
                Console.Clear();
                dibujar();
                presionoDosVeces = true;
            }
            temp = itemSelccionado;

        }
        public void cuantasCartas()
        {
            
            int numero = 0;
            int nn = 0;
            Console.SetCursorPosition(0, 1);
            Console.Write("¿Cuantas cartas quiere?:");
            numero = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(0, 2);
            //Console.WriteLine(mazo.darCartas(numero));
            cartasD = mazo.darCartas(numero);
            foreach(var cart in cartasD)
            {
                if (cart == "No hay suficentes cartas") nn = 1;
            }
            if(nn == 0)
            {
                for (int i = 0; i < cartasD.Count; i++)
                {
                    dibujarCarta(cartasD[i], i);
                }
            }
            else { 
                Console.WriteLine("No hay suficentes cartas");
                nn = 0;
            }
            
        }
        public void dibujarCarta(string carta)
        {
            lineaC = 1;
            columC = 0;
            linea(lineaC,columC + 1, 11);
            lineaC ++;
            
            columna(columC, lineaC, 8);
            columC = 10;
            columna(columC, lineaC, 8);
            lineaC += 5;
            linea(lineaC, 1 , 11);
            Console.SetCursorPosition(4, 4);
            Console.Write(carta);
        }
        public void dibujarCarta(string carta, int cantidad)
        {
            c++;
            if (c >= 10 && cantidad > 9)
            {
                nuevaLinea = true;
                c = 0;
                cantFilas++;
            }
            if (cantidad <= 9)
            {
                lineaC = 2;
            }
            else
            {
                lineaC = 9 * cantFilas;
            }
            
                
            if (cantidad == 0 || nuevaLinea)
            {
                columC = 0;
                nuevaLinea = false;
            }
                
            else columC += 1;
            inicioL = columC;
            linea(lineaC, inicioL + 1, inicioL + 11);
            lineaC ++;
            
            columna(columC, lineaC, lineaC + 6);
            columC += 10;
            columna(columC, lineaC, lineaC + 6);
            lineaC += 5;
            linea(lineaC, inicioL + 1, inicioL + 11);
            Console.SetCursorPosition(columC - 6, lineaC - 4);
            Console.Write(carta);
        }
        private void linea(int y,int inicio, int final)
        {
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = inicio; i < final - 1; i++)
            {
                Console.SetCursorPosition(i, y);
                Console.Write("-");
            }

        }
        private void columna(int x, int inicio, int fin)
        {
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = inicio; i < fin - 1; i++)
            {
                Console.SetCursorPosition(x, i);
                Console.Write("|");
            }
        }
    }
}
