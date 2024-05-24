using System;
using System.Collections.Generic;

namespace menu17_5
{
    internal class Clientes
    {
        public int numCli;
        public string nombreCli;
        public int dni;
        public int posCli;
        string valor;
        public Clientes(int numCli, string nombreCli, int dni)
        {
            this.numCli = numCli;
            this.nombreCli = nombreCli;
            this.dni = dni;
        }

        public void modificarS(List<Clientes> clientes)
        {

            void dibujar()
            {
                Console.SetCursorPosition(0, 2);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("--------clientes-----------");
                foreach (var cliente in clientes)
                {
                    Console.Write(cliente.numCli);
                    Console.Write("-");
                    Console.WriteLine(cliente.nombreCli);
                }
                Console.WriteLine("Escriba el numero del cliente que quiere modificar:(si quiere salir presione S)");
                valor = Console.ReadLine();
                if (valor == "S" || valor == "s")
                    return;
                else
                {
                    try { 
                    posCli = int.Parse(valor);
                    if (posCli >= clientes.Count){
                         Console.WriteLine("El cliente que quiere modificar no existe"); return;}
                    modificar(posCli);
                    return;}
                    catch (FormatException) {
                    Console.WriteLine("Solo ingrese datos de tipo numero por favor"); return;
                    }
                    
                }
            }
            dibujar();

            void modificar(int cliente)
            {
                string nombre;
                string stDni;
                int dni;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("Nombre actual del cliente: " + clientes[cliente].nombreCli);
                Console.Write("Nuevo nombre del cliente: ");
                nombre = Console.ReadLine();
                Console.WriteLine("DNI actual del cliente: " + clientes[cliente].dni);
                Console.Write("Nuevo DNI del cliente: ");
                stDni = Console.ReadLine();
                if(stDni == "" || nombre == "")
                {
                    Console.WriteLine("No puede tener campos vacios"); return;
                }
                dni = int.Parse(stDni);
                clientes[cliente].nombreCli = nombre;
                clientes[cliente].dni = dni;
                Console.Write("Cliente modificado");
            }
        }
        public void select(int[] posicion, List<Clientes> clientes)
        {

            int dni;
            string stDni;
            int num;
            if (clientes.Count == 0) num = 0;
            else num = clientes.Count;
            string nombre;
            Clientes p;
            if (posicion[1] == 0)
            {
                Console.SetCursorPosition(0, 2);

                Console.Write("Ingrese su nombre:");
                nombre = Console.ReadLine();
                Console.Write("Ingrese su dni:");
                stDni = Console.ReadLine();
                if (nombre == "" || stDni == "")
                    Console.WriteLine("No puede tener campos vacios");
                else
                {
                    try { 
                        dni = int.Parse(stDni);
                        p = new Clientes(num, nombre, dni);
                        clientes.Add(p);
                        Console.Write("Cliente ingresado");
                        return;
                    }
                    catch (FormatException)
                    {
                        Console.SetCursorPosition(0, 5);
                        Console.WriteLine("Por fabor no ingrese ni letras ni caracteres especiales en el DNI");
                        return;
                    }
                }
                
            }
            if (posicion[1] == 1)
            {
                modificarS(clientes);
            }
            if (posicion[1] == 2)
            {
                Console.SetCursorPosition(0, 2);
                foreach (var cliente in clientes)
                    Console.WriteLine("-"+cliente.nombreCli);
            }


        }

    }
}
