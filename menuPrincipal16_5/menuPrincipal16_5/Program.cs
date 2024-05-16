/* 
Partiendo de este codigo, terminar el programa en el que se pueda ver el menu y con las teclas recorrerlo y poder elegir una opcion para hacer algo diferente en cada caso
*/

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Item
    {
        string opcion;
    }
    
    class MenuPrincipal
    {
        List<Menu> menu = new List<Menu>();
        int posMenu = 1;
        public MenuPrincipal(Dictionary<string, string[]> menus)
        {
            // Recorro el diccionario
            int pos = 1;
            foreach (var subMenu in menus)
            {
                menu.Add(new Menu(pos++, subMenu.Key, subMenu.Value));
            }
        }

        public void derecha()
        {
            posMenu++;
        }
        public void izquierda()
        {
            posMenu--;
        }


        public void bajar()
        {            
            menu[posMenu - 1].posItem++;
            if (menu[posMenu - 1].posItem == menu[posMenu - 1].items.Length)
                menu[posMenu - 1].posItem = 0;
        }

        public void dibujar(int columna, int fila, int subMenu, int activo, int itemActivo)
        {
            Console.SetCursorPosition(columna, fila++);
            if (subMenu == activo) {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(menu[subMenu - 1].nombreMenu);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(menu[subMenu - 1].nombreMenu);
            }
            //foreach (string item in menu[subMenu - 1].items)
            for (int i = 0; i < menu[subMenu - 1].items.Length; i++) 
            {
                Console.SetCursorPosition(columna, fila++);

                if (subMenu == activo)
                {
                    if (menu[subMenu - 1].items[i] == menu[subMenu - 1].items[itemActivo])
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(menu[subMenu - 1].items[i]);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(menu[subMenu - 1].items[i]);
                    }
                }
            }
            //bool primerItem = true;
            //foreach (string item in items)
            //{
            //    if (primerItem)
            //    {
            //        Console.BackgroundColor = ConsoleColor.Red;
            //        Console.ForegroundColor = ConsoleColor.White;
            //        primerItem = false;
            //    }
            //    else
            //    {
            //        Console.BackgroundColor = ConsoleColor.Gray;
            //        Console.ForegroundColor = ConsoleColor.Black;
            //    }
            //    Console.SetCursorPosition(columna, fila++);
            //    Console.Write(item);
            //}
        }
    }

    class Menu
    {
        public string[] items;
        public string nombreMenu;
        public int posItem;
        public int columna;
        public int fila;

        public Menu(int posMenu, string nombreMenu, string[] opciones)
        {
            this.items = opciones;
            this.nombreMenu = nombreMenu;
            this.posItem = posMenu;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal menu;
            int activo = 1;
            int itemActivo = 0;
            int cantItem = 0;
            string[] menu1 = { "Nuevo Cliente", "Modificar Cliente", "Listar Clientes", "Salir" };
            string[] menu2 = { "Nuevo Producto", "Modificar Producto", "Eliminar Producto", "Listar Producto", "Salir" };

            cantItem = menu1.Length;
            var menus = new Dictionary<string, string[]>
            {
                { "Archivo", menu1 }, { "Editar", menu2 }
            };

            Console.Clear();
            menu = new MenuPrincipal(menus);
            menu.dibujar(1, 1, 1, activo, itemActivo);
            menu.dibujar(30, 1, 2, activo, itemActivo);

            ConsoleKeyInfo tecla;
             //Readkey devuelve un dato de tipo ConsoleKey
            do {
                tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.RightArrow)
            {
                Console.Clear();
                if (activo > menus.Count -1) activo = 1;
                else activo++;
                menu.dibujar(1, 1, 1, activo, itemActivo);
                menu.dibujar(30, 1, 2, activo, itemActivo);
                    
            }
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    if (activo == 1) activo = 2;
                    else activo--;
                    menu.dibujar(1, 1, 1, activo, itemActivo);
                    menu.dibujar(30, 1, 2, activo, itemActivo);

                }


                menu.derecha();
                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    menu.bajar(); 
                    menu.dibujar();                    
                    //if (itemActivo > .Values.Count) activo = 1;
                    //else itemActivo++;
                    //menu.dibujar(1, 1, 1, activo, itemActivo);
                    
                }
                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    menu.subir();                    
                    menu.dibujar();                    
                }

            } while(true);

                Console.ReadKey();

        }
    }
}