using System;
using System.Collections.Generic;

namespace menu17_5
{
    class Item
    {
        string opcion;
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            MenuPrincipal menu;
            List<Clientes> clientes = new List<Clientes>();
            List<Productos> productos = new List<Productos>();
            List<Productos> productos1 = new List<Productos>();

            string[] menu1 = { "Nuevo Cliente", "Modificar Cliente", "Listar Clientes", "Salir" };
            string[] menu2 = { "Nuevo Producto", "Modificar Producto", "Eliminar Producto", "Listar Producto", "Salir" };
            string[] menu3 = { "Nuevo Producto verduras", "Modificar Producto verduras", "Eliminar Producto verduras", "Listar Producto verduras", "Salir" };


            var menus = new Dictionary<string, string[]>
            {
                { "Archivo", menu1 }, { "Editar", menu2 }, {"verduras",  menu3 }
            };

            Console.Clear();
            menu = new MenuPrincipal(menus);
            menu.dibujar();
            bool selectAct = false;
            ConsoleKeyInfo tecla;
            //Readkey devuelve un dato de tipo ConsoleKey
            do
            {
                int[] num = { };
                tecla = Console.ReadKey();
                if(selectAct == false)
                {if (tecla.Key == ConsoleKey.RightArrow)
                    menu.derecha();
                if (tecla.Key == ConsoleKey.LeftArrow)
                    menu.izquierda();
                if (tecla.Key == ConsoleKey.DownArrow)
                    menu.bajar();
                    if (tecla.Key == ConsoleKey.UpArrow)
                        menu.subir();
                }
                if (tecla.Key == ConsoleKey.Enter)
                {
                    selectAct = !selectAct;
                    Clientes c;
                    Productos p;
                    c = new Clientes(0, "pepe", 123);
                    p = new Productos(0, "ropa", 123);
                    num = menu.select();
                    if (selectAct)
                    {
                        switch (num[0])
                        {

                            case -1:
                                break;
                            case 0:
                                c.select(num, clientes);
                                break;
                            case 1:
                                p.select(num, productos);
                                break;
                            case 2:
                                p.select(num, productos1);
                                break;
                        }

                    }
                    else
                    {
                        Console.Clear();
                        menu.dibujar();
                        //selectAct = true;
                    }

                }
            } while (true);

            Console.ReadKey();

        }
    }
}
