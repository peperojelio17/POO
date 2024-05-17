using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        string[] menu1 = { "Nuevo Cliente", "Modificar Cliente", "Listar Clientes", "Salir" };
            string[] menu2 = { "Nuevo Producto", "Modificar Producto", "Eliminar Producto", "Listar Producto", "Salir" };
            string[] menu3 = { "1Nuevo Producto", "1Modificar Producto", "1Eliminar Producto", "Listar Producto", "Salir" };

            
            var menus = new Dictionary<string, string[]>
            {
                { "Archivo", menu1 }, { "Editar", menu2 }, {"Hola",  menu3 }
            };

            Console.Clear();
            menu = new MenuPrincipal(menus);
            menu.dibujar();
            bool selectAct = true;
            ConsoleKeyInfo tecla;
            //Readkey devuelve un dato de tipo ConsoleKey
            do
            {
                int[] num = { };
                tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.RightArrow)
                    menu.derecha();
                if (tecla.Key == ConsoleKey.LeftArrow)
                    menu.izquierda();
                if (tecla.Key == ConsoleKey.DownArrow)
                    menu.bajar();
                if (tecla.Key == ConsoleKey.UpArrow)
                    menu.subir();
                if (tecla.Key == ConsoleKey.Enter)
                {
                    int dni, numer = 0;
                    string nombre;
                    Clientes p;
                    num = menu.select();
                    if (selectAct) { 
                        if (num[0] == 0)
                        {
                            if (num[1] == 0) { 
                            Console.SetCursorPosition(0, 3);
                                
                                Console.Write("Ingrese su nombre:");
                                nombre = Console.ReadLine();
                                Console.Write("Ingrese su dni:");
                                dni = int.Parse(Console.ReadLine());
                                numer++;
                                p = new Clientes(numer, nombre, dni);
                                clientes.Add(p);
                                Console.Write("Cliente ingresado");
                            }
                            if (num[1] == 2)
                            {
                                Console.SetCursorPosition(0, 3);
                                foreach (var cliente in clientes)
                                    Console.WriteLine(cliente.nombreCli);
                            }
                        }
                            selectAct = false;
                    }
                    else
                    {
                        Console.Clear();
                        menu.dibujar();
                        selectAct = true;
                    }

                }
            } while (true);

            Console.ReadKey();

        }
    }
}
