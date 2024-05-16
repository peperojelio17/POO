using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace clase16DeMayo
{
    class Menu
    {
        string[] items; //creo array
        static int activo = 0;
        public Menu(string[] opciones)
        { //constructor
            items = opciones; //se guardan opciones en el array items
        }

        public void dibujar(int columna, int fila)
        {
            
            bool primerItem = true;

            
            for (int i = 0; i < items.Length; i++) 
            { //guarda los valores del array items en la variable item


                if (items[i]== items[activo])
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    primerItem = false;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                Console.SetCursorPosition(columna, fila++);
                Console.Write(items[i]);
            }
        }



        internal class Program
        {
            static void Main(string[] args)
            {
             
                Menu menu;
                string[] opciones = { "      Nuevo cliente         ",
                                      "      Modificar cliente     ",
                                      "      Eliminar Cliente      ",
                                      "      Listar Clientes       ",
                                      "      Salir                 "
                                    };

                Console.Clear();
                menu = new Menu(opciones);
                menu.dibujar(6, 3);

                do
                {
                    

                    ConsoleKeyInfo tecla;
                    tecla = Console.ReadKey(); //Readkey devuelve un dato de tipo ConsoleKey

                    if (tecla.Key == ConsoleKey.DownArrow)
                    {
                        if (activo >= 4)
                        {
                            activo = 0;
                            menu.dibujar(6, 3);
                        }
                        else { 
                            activo++;
                            menu.dibujar(6, 3);
                        }
                        
                    }
                    if (tecla.Key == ConsoleKey.UpArrow)
                    {
                        if (activo <= 0)
                        {
                            activo = 4;
                            menu.dibujar(6, 3);
                        }
                        else
                        {
                            activo--;
                            menu.dibujar(6, 3);
                        }

                    }
                    if (tecla.Key == ConsoleKey.Enter)
                    {
                        
                    }
                } while(true);

            }
        }
    }
}
