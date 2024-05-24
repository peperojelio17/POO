using System;
using System.Collections.Generic;

namespace menu17_5
{
    internal class Productos
    {
        public int numProd;
        public string nombreProd;
        public int cant;
        public int posProd;
        string valor;
        public Productos(int numProd, string nombreProd, int cant)
        {
            this.numProd = numProd;
            this.nombreProd = nombreProd;
            this.cant = cant;
        }
        public void eliminar(List<Productos> productos)
        {
            Console.SetCursorPosition(0, 2);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("--------productos-----------");
            posProd = 0;
            foreach (var producto in productos)
            {

                Console.Write(posProd);
                posProd++;
                Console.Write("-");
                Console.WriteLine(producto.nombreProd);
            }
            Console.WriteLine("Escriba el numero del cliente que quiere eliminar: (si quiere salir presione S)");
            valor = Console.ReadLine();
            if (valor == "S" || valor == "s")
                return;
            else
            {
                try
                {
                    posProd = int.Parse(valor);
                    if (posProd >= productos.Count)
                    {
                        Console.WriteLine("El producto que quiere eliminar no existe"); return;
                    }
                    productos.RemoveAt(posProd);
                    return;
                }
                catch (FormatException)
                {
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine("Por favor ingrese datos de tipo numeros");
                    return;
                }
            }
        }
        public void modificarS(List<Productos> productos)
        {

            void dibujar()
            {
                Console.SetCursorPosition(0, 2);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("--------productos-----------");
                posProd = 0;
                foreach (var producto in productos)
                {
                    Console.Write(posProd);
                    posProd++;
                    Console.Write("-");
                    Console.WriteLine(producto.nombreProd);
                }
                Console.WriteLine("Escriba el numero del producto que quiere modificar (si quiere salir presione S):");
                valor = Console.ReadLine();
                if (valor == "S" || valor == "s")
                    return;
                else
                {
                    try
                    {
                        posProd = int.Parse(valor);
                        if (posProd >= productos.Count)
                        {
                            Console.WriteLine("El producto que quiere modificar no existe"); return;
                        }
                        modificar(posProd);
                    }
                    catch (FormatException)
                    {
                        Console.SetCursorPosition(0, 9);
                        Console.WriteLine("Por favor ingrese datos de tipo numeros en la cantidad");
                        return;
                    }
                    return;
                }
            }
            dibujar();

            void modificar(int producto)
            {
                string nombre;
                string sCantidad;
                int cantidad;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("Nombre actual del producto: " + productos[producto].nombreProd);
                Console.Write("Nuevo nombre del producto: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Cantidad actual del producto: " + productos[producto].cant);
                Console.Write("Nueva cantidad del producto: ");
                sCantidad = Console.ReadLine();
                if(nombre == "" || sCantidad == ""){
                    Console.WriteLine("Tiene que completar todos los campos"); return;}
                try { 
                cantidad = int.Parse(sCantidad);
                productos[producto].nombreProd = nombre;
                productos[producto].cant = cantidad;
                Console.Write("Producto modificado");}
                catch (FormatException){
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine("Por favor ingrese datos de tipo numeros en la cantidad");
                }

            }
        }
        public void select(int[] posicion, List<Productos> productos)
        {

            int cantidad;
            int num;
            if (productos.Count == 0) num = 0;
            else num = productos.Count;
            string nombre;
            string nomCant;
            Productos p;
            if (posicion[1] == 0)
            {
                Console.SetCursorPosition(0, 3);
                
                Console.Write("Ingrese el nombre del producto:");
                nombre = Console.ReadLine();
                Console.Write("Ingrese la cantidad:");
                nomCant = Console.ReadLine();
                if (nombre == "" || nomCant == "") { 
                    Console.WriteLine("Tiene que completar todos los campos"); return;}
                try{
                    cantidad = int.Parse(nomCant);
                    p = new Productos(num, nombre, cantidad);
                    productos.Add(p);
                    Console.Write("Producto ingresado");
                }
                catch (FormatException)
                {
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine("Por favor ingrese datos de tipo numeros en la cantidad");
                }


            }
            if (posicion[1] == 1)
            {
                modificarS(productos);
            }
            if (posicion[1] == 2)
            {
                eliminar(productos);
            }
            if (posicion[1] == 3)
            {
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("  Nombre  |  cantidad");
                Console.SetCursorPosition(0, 3);
                posProd = 3;
                foreach (var productos1 in productos)
                {
                    Console.Write(productos1.nombreProd);
                    Console.SetCursorPosition(10, posProd);
                    Console.WriteLine("|    " + productos1.cant);
                    posProd++;
                }
            }


        }
    }
}
