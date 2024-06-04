using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTetris30_5
{
    public abstract class Pieza
    {
        int limite = 25;
        public List<Bloque> bloques = new List<Bloque>();

        public Bloque a, b, c, d;

        public bool bajar(List<Pieza> piezas)
        {
            Pieza piezaActual;
            piezaActual = piezas.Last();
            bool total = true;
            foreach (var bloque in bloques)
            {
                if (bloque.x + 1 == limite)
                {
                    total = false;
                    return total;
                }
            }
            foreach (Pieza c in piezas)
            {
                if(c != piezaActual) { 
                foreach (var bloque in bloques)
                {
                    foreach (var item in c.bloques)
                    {
                        if (bloque.x == item.x - 1 && bloque.y == item.y)
                        {
                            total = false;
                        }
                    }
                }
                }
            }
            return total;
        }

        public abstract void Rotar();
        public int colorP = 0;
        
        public bool colicion(List<Pieza> piezas, int tipo)
        {
            Pieza piezaActual;
            piezaActual = piezas[piezas.Count - 1];
            bool colision = false;

            foreach (var bloque in bloques)
            {
                foreach (var pieza in piezas)
                {
                    if (pieza != piezaActual)
                    {
                        foreach (var b in pieza.bloques)
                        {
                            if(tipo == 1) { 
                            if (bloque.x == b.x && bloque.y + 1 == b.y)
                            {
                                colision = true;
                            }
                            }
                            if (tipo == 2)
                            {
                                if (bloque.x == b.x && bloque.y - 1 == b.y)
                                {
                                    colision = true;
                                }
                            }
                        }
                    }
                }
            }
            return colision;
        }
        public void derecha(List<Pieza> piezas)
        {
            bool colision;
            colision = colicion(piezas, 1);
            
            if (bajar(piezas))
            {
            foreach (var bloque in bloques)
            {
                if (bloque.y < 72 && colision == false)
                {
                    Console.SetCursorPosition(bloque.y, bloque.x);
                    Console.Write(" ");
                    bloque.y++;
                }
            }
            }

        }
        public void izquierda(List<Pieza> piezas)
        {
            bool colision;
            colision = colicion(piezas, 2);
            if (bajar(piezas))
            {
                foreach (var bloque in bloques)
                {
                    if (bloque.y > 46 && colision == false)
                    {
                        Console.SetCursorPosition(bloque.y, bloque.x);
                        Console.Write(" ");
                        bloque.y--;
                    }
                }
            }
        }
        public void color(int color)
        {
            
            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
                
        }
        public void nueva(List<Pieza> piezas)
        {

            Random r = new Random();
            int num = r.Next(1, 6);
            Linea a1;
            Cubo a2;
            Te a3;
            Ele a4;
            Ese a5;
            Zeta a6;
            switch (num)
            {
                case 1:
                    a2 = new Cubo();
                    piezas.Add(a2);
                    break;
                case 2:
                    a3 = new Te();
                    piezas.Add(a3);
                    break;
                case 3:
                    a4 = new Ele();
                    piezas.Add(a4);
                    break;
                case 4:
                    a1 = new Linea();
                    piezas.Add(a1);
                    break;
                case 5:
                    a5 = new Ese();
                    piezas.Add(a5);
                    break;
                case 6:
                    a6 = new Zeta();
                    piezas.Add(a6);
                    break;
            }
        }
        public bool eliminar(List<Pieza> piezas)
        {
            int limite = 24;
            bool eliminar = false;
            int contador = 0;
            Console.SetCursorPosition(0, 0);
            Console.Write("  ");
            for(int e = 1;  e <= limite; e++) { 
                for (int i = 0; i < piezas.Count; i++)
                {
                    foreach(var bloque in piezas[i].bloques)
                    {
                        if(bloque.x == e) contador++;
                    }
                }
                //Console.SetCursorPosition(0, 0);
                //Console.Write(contador);
                if (contador >= 15) {
                    eliminar = true;
                    for (int i = piezas.Count -1; i >= 0; i--)
                    {
                        //foreach (var bloque in piezas[i].bloques)
                        for (int j = piezas[i].bloques.Count - 1; j >= 0; j--)
                        {
                            if (piezas[i].bloques[j].x == e)
                            {
                                Console.SetCursorPosition(piezas[i].bloques[j].y, piezas[i].bloques[j].x);
                                Console.Write(" ");
                                piezas[i].bloques.Remove(piezas[i].bloques[j]);
                            }
                        }
                    }
                }
                contador = 0;
            }
            return eliminar;
        }
    }
}
