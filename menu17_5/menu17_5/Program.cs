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
        static DateTime h1 = DateTime.Now;
        static DateTime h2 = DateTime.Now;
        static void Main(string[] args)
        {
            MenuPrincipal menu;
            List<Clientes> clientes = new List<Clientes>();
            List<Productos> productos = new List<Productos>();
            List<Productos> productos1 = new List<Productos>();


            string[] menu1 = { "Nuevo Cliente", "Modificar Cliente", "Listar Clientes", "Salir" };
            string[] menu2 = { "Nuevo Producto", "Modificar Producto", "Eliminar Producto", "Listar Producto", "Salir" };
            string[] menu3 = { "Nuevo Producto verduras", "Modificar Producto verduras", "Eliminar Producto verduras", "Listar Producto verduras", "Salir" };
            string[] menu4 = { "mostrar copos","Salir" };


            var menus = new Dictionary<string, string[]>
            {
                { "Archivo", menu1 }, { "Editar", menu2 }, {"verduras",  menu3 }, {"copos",  menu4 }
            };

            Console.Clear();
            menu = new MenuPrincipal(menus);
            menu.dibujar();
            bool selectAct = false;
            bool copos = true;
            Copos co;
            co = new Copos();
            h2 = DateTime.Now;
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
                        if (num[0] == 3)
                        {
                            copos = true;
                        }
                        h2 = DateTime.Now;
                        if (copos == true)
                        {
                            co.mostrar(6, h2, h1);
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
