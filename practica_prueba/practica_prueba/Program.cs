using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_prueba
{
    
   public class MenuPrincipal
    {
        int posMenu = 0;
        List<Menu> menu = new List<Menu>();
        int pos =0;
        int fila = 1;
        int col = 1;
        public MenuPrincipal(Dictionary<string, string[]> menus)
        {
            foreach (var m in menus) {
                menu.Add(new Menu(pos, m.Key, m.Value,fila, col));
                col += m.Key.Length + 2;
            }
        }
        public void dibujar()
        {
            foreach (var m in menu) {
            Console.SetCursorPosition(m.col,m.fila++);
                if(m == menu[posMenu]) {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write(m.nombreMenu); 
                    foreach(var item in m.items)
                    {
                        Console.SetCursorPosition(m.col, m.fila);
                        if (item == m.items[m.posItem])
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(item);
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(item);
                        }
                        m.fila++;
                    }
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(m.nombreMenu);
                }
            }
        }
    }
    public class Menu
    {
        public int posItem;
        public int fila = 1;
        public int col = 1;
        public string[] items;
        public string nombreMenu;
        public Menu(int posItem, string nombre, string[] items, int fila, int col) {
            this.posItem = posItem; 
            this.nombreMenu = nombre;
            this.items = items;
            this.fila = fila;
            this.col = col;
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            MenuPrincipal m;
            Console.CursorVisible = false;
            string[] menu1 = { "nuevo archivo", "editar archivo", "eliminar" };
            string[] menu2 = { "nuevo archivo2", "editar archivo2", "eliminar2" };
            var lista = new Dictionary<string, string[]>
            {
                {"archivo", menu1 }, {"producto", menu2 }
            };
            m = new MenuPrincipal(lista);
            m.dibujar();
            ConsoleKeyInfo tecla;
            while (true)
            {
                tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.M) { }
            }
            
            Console.ReadKey();
        }
    }
}
