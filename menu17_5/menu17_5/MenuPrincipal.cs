using System;
using System.Collections.Generic;

namespace menu17_5
{
    internal class MenuPrincipal
    {
        List<Menu> menu = new List<Menu>();
        public int posMenu = 0;

        public MenuPrincipal(Dictionary<string, string[]> menus)
        {
            // Recorro el diccionario
            int pos = 0;
            int fila = 1;
            int col = 1;
            foreach (var subMenu in menus)
            {
                menu.Add(new Menu(pos, subMenu.Key, subMenu.Value, fila, col));
                col += subMenu.Key.Length + 2;
            }
        }

        public void derecha()
        {
            menu[posMenu].posItem = 0;
            posMenu++;
            if (posMenu + 1 > menu.Count)
                posMenu = 0;
            Console.Clear();
            dibujar();
        }
        public void izquierda()
        {
            menu[posMenu].posItem = 0;
            posMenu--;
            if (posMenu < 0)
                posMenu = menu.Count - 1;
            Console.Clear();
            dibujar();
        }

        public void bajar()
        {
            menu[posMenu].posItem++;
            if (menu[posMenu].posItem == menu[posMenu].items.Length)
                menu[posMenu].posItem = 0;
            dibujar();
        }
        public void subir()
        {
            menu[posMenu].posItem--;
            if (menu[posMenu].posItem < 0)
                menu[posMenu].posItem = menu[posMenu].items.Length - 1;
            dibujar();
        }
        public int[] select()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            int[] posicion = { 0, 0 };
            foreach (var item in menu)
            {
                if (item == menu[posMenu])
                {
                    if (item.items[item.posItem] == "Salir")
                        Environment.Exit(0);
                    else
                    {
                        Console.WriteLine("-------" + item.nombreMenu + "-------");
                        posicion[0] = posMenu;
                        posicion[1] = item.posItem;
                    }
                    break;
                }
            }
            return posicion;

        }

        public void dibujar()
        {
            foreach (var can in menu)
            {
                Console.SetCursorPosition(can.columna, can.fila++);
                if (can == menu[posMenu])
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(can.nombreMenu);
                    for (int i = 0; i < can.items.Length; i++)
                    {
                        Console.SetCursorPosition(can.columna, can.fila++);
                        if (can.items[i] == can.items[can.posItem])
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(can.items[i]);
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(can.items[i]);
                        }
                    }
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(can.nombreMenu);
                    Console.SetCursorPosition(0, can.items.Length + 1);
                }

                Console.BackgroundColor = ConsoleColor.Black;
                can.fila = 1;
            }

        }
    }
}
