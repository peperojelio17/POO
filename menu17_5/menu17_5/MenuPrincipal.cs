using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                col += 30;
            }
        }

        public void derecha()
        {
            menu[posMenu].posItem = 0;
            posMenu++;
            if (posMenu + 1 > menu.Count)
                posMenu = 0;
            dibujar();
        }
        public void izquierda()
        {
            menu[posMenu].posItem = 0;
            posMenu--;
            if (posMenu < 0)
                posMenu = menu.Count - 1;
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
            Clientes p;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            string nombre;
            int[] posicion = {0,0};
            foreach (var item in menu)
            {
                if (item == menu[posMenu]) { 
                    Console.WriteLine("-------" +item.nombreMenu+"-------");
                    Console.WriteLine(posMenu + " " + item.posItem);
                    posicion[0] = posMenu;
                    posicion[1] = item.posItem;
                break;
                }
            }
            return posicion;
            //switch (posMenu)
            //{
            //    case 0:
            //        Console.WriteLine("-------Clientes-------");
            //        int dni, num = 0;
            //        string nombre;
            //        switch (menu[posMenu].posItem)
            //        {
            //            case 0:
            //                Console.WriteLine(menu[posMenu].items[0]);
            //                Console.Write("Ingrese su nombre:");
            //                nombre = Console.ReadLine();
            //                Console.Write("Ingrese su dni:");
            //                dni = int.Parse(Console.ReadLine());
            //                num++;
            //                p = new Clientes(num, nombre, dni);
            //                menu[posMenu].clientes.Add(p);
            //                Console.Write("Cliente ingresado");

            //                break;
            //            case 2:
            //                Console.WriteLine(menu[posMenu].items[2]);
            //                foreach (var cliente in menu[posMenu].clientes)
            //                    Console.WriteLine(cliente.nombreCli);
            //                break;
            //        }
            //        nombre = Console.ReadLine();
            //        Console.Clear();
            //        dibujar();
            //        break;
            //    case 1:
            //        Console.WriteLine("-------Productos-------");
            //        nombre = Console.ReadLine();
            //        Console.Clear();
            //        dibujar();
            //        break;
            //}
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
                    for (int i = 0; i < can.items.Length; i++)
                    {
                        Console.SetCursorPosition(can.columna, can.fila++);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(can.items[i]);
                    }
                }


                can.fila = 1;
            }

        }
    }
}
