using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer16
{
    public class MenuAgenda
    {
        private AgendaContactos agenda;
        private List<string> items;
        private Dictionary<int, string> opciones;
        private int pos;
        private int itemSeleccionado;
        private bool enterPresionado;
        private int itemPresionado;

        public MenuAgenda() 
        {
            enterPresionado = false;
            agenda = new AgendaContactos();
            //agenda.añadirContacto(new Contacto("Manuel", 143));
            //agenda.añadirContacto(new Contacto("Mariano", 112));
            itemSeleccionado = 0;
            opciones = new Dictionary<int, string>();
            pos = 0;
            items = new List<string>() {"Mostrar contactos","Añadir contacto", "Eliminar contacto", "Existe contacto", "Buscar contacto", "Agenda llena", "Huecos agenda"};
            foreach (var item in items) 
            {
                opciones.Add(pos, item);
                pos += item.Length + 2;
            }
        }
        public void dibujar()
        {
            foreach (var item in opciones)
            {
                Console.SetCursorPosition(item.Key, 0);
                if(item.Value == items[itemSeleccionado]) Console.BackgroundColor = ConsoleColor.Red;
                else Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(item.Value);
            }
        }
        private void derecha()
        {
            itemSeleccionado++;
            if (itemSeleccionado + 1 > opciones.Count)
                itemSeleccionado = 0;
            enterPresionado = false;
            dibujar();
        }
        private void izquierda()
        {
            itemSeleccionado--;
            if (itemSeleccionado < 0)
                itemSeleccionado = opciones.Count - 1;
            enterPresionado = false;
            dibujar();
        }
        public void controles(ConsoleKeyInfo tecla)
        {
            if (tecla.Key == ConsoleKey.RightArrow)
                derecha();
            if (tecla.Key == ConsoleKey.LeftArrow)
                izquierda();
            if (tecla.Key == ConsoleKey.Enter)
            {
                funcionesAgenda();
                enterPresionado = !enterPresionado;
            }
        }
        private void funcionesAgenda()
        {
            string nombre;
            int numero;
            Console.Clear();
            dibujar();
            if (!enterPresionado)
            {
                Console.SetCursorPosition(0, 2);
                if (itemSeleccionado == 0)
                    agenda.listarContactos();
                else if (itemSeleccionado == 1)
                {
                    Console.WriteLine("Contacto Nuevo");
                    Console.Write("Nombre:");
                    nombre = Console.ReadLine();
                    Console.Write("Telefono:");
                    numero = int.Parse(Console.ReadLine());
                    agenda.añadirContacto(new Contacto(nombre, numero));
                }
                else if (itemSeleccionado == 2)
                {
                    Console.WriteLine("Eliminar contacto");
                    Console.Write("Nombre:");
                    nombre = Console.ReadLine();
                    agenda.eliminarContacto(nombre);
                }
                else if(itemSeleccionado == 3)
                {
                    Console.WriteLine("Eliminar contacto");
                    Console.Write("Nombre:");
                    nombre = Console.ReadLine();
                   if(agenda.existeContacto(new Contacto(nombre, 02343)))
                    {
                        Console.WriteLine("El contacto ya existe");

                    }
                }

            }
            
        }

    }
}
