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
        int posMenu = 0;
        
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
            posMenu++;
            if (posMenu + 1 > menu.Count)
                posMenu = 0;
            dibujar();
        }
        public void izquierda()
        {
            posMenu--;
            if (posMenu < 0)
                posMenu = menu.Count -1;
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
        public void select()
        {
            Clientes p;
            Console.Clear();
            Console.SetCursorPosition(0,0);
            Console.ForegroundColor = ConsoleColor.White;
            switch (posMenu)
            {
                case 0:
                    Console.WriteLine("-------Clientes-------");
                    int dni,num = 0;
                    string nombre;
                    switch (menu[posMenu].posItem)
                    {
                        case 0:
                            Console.WriteLine(menu[posMenu].items[0]);
                            Console.Write("Ingrese su nombre:");
                            nombre = Console.ReadLine();
                            Console.Write("Ingrese su dni:");
                            dni = int.Parse(Console.ReadLine());
                            num++;
                            p = new Clientes(num, nombre, dni);
                            menu[posMenu].clientes.Add(p);
                            Console.Write("Cliente ingresado");
                            
                            break;
                        case 2:
                            Console.WriteLine(menu[posMenu].items[2]);
                            foreach(var cliente in menu[posMenu].clientes)
                            Console.WriteLine(cliente.nombreCli);
                            break;
                    }
                    nombre = Console.ReadLine();
                    Console.Clear();
                    dibujar();
                    break;
                case 1: 
                    Console.WriteLine("-------Productos-------");
                    nombre = Console.ReadLine();
                    Console.Clear();
                    dibujar();
                    break;
            }
        }

        public void dibujar()
        {
            
            foreach (var can in menu) {
                Console.SetCursorPosition(can.columna,can.fila++);
                if (can == menu[posMenu]) {
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

    class Clientes
    {
        public int numCli;
        public string nombreCli;
        public int dni;
        public Clientes(int numCli, string nombreCli, int dni)
        {
            this.numCli = numCli;
            this.nombreCli = nombreCli;
            this.dni = dni;
        }
    }
    class Menu
    {
        public string[] items;
        public string nombreMenu;
        public int posItem;
        public int columna;
        public int fila;
        public List<Clientes> clientes = new List<Clientes>();
        public Menu(int posItem, string nombreMenu, string[] opciones, int fila, int col)
        {
            this.items = opciones;
            this.nombreMenu = nombreMenu;
            this.posItem = posItem;
            this.fila = fila;
            this.columna = col;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal menu;
            
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
            menu.dibujar();

            ConsoleKeyInfo tecla;
            //Readkey devuelve un dato de tipo ConsoleKey
            do
            {
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
                    menu.select();
            } while (true);

            Console.ReadKey();

        }
    }
}