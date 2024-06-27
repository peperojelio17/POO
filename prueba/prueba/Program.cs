using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace prueba
{
    public class Opciones
    {
        List<opcion> list = new List<opcion>();
        int opS = 0;
        int pos = 0;
        int col = 0;
        public Opciones(Dictionary<int , string> valor) 
        {
            foreach(var a in valor)
            {
                list.Add(new opcion(a.Key, a.Value, col));
                col += a.Value.Length +3;
            }
        }
        public void dibujar()
        {
            foreach (var a in list)
            {
                Console.SetCursorPosition(a.pos, 0);
                
                if(a.valor == opS)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(a.nombre);
                }
                else {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(a.nombre);
                }
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        public void derecha()
        {
            
            
            if (opS > list.Count -1)
            {
                opS = 0;
            }
            else 
            opS ++;
            dibujar();
        }
        public void izquierda()
        {

            opS--;
            if (opS<0)
            {
                opS = list.Count -1;
            }
                
            dibujar();
        }
        public void select(List<ProductoElectronico> productos)
        {
            switch (opS)
            {
                case 0:
                    Console.Clear();
                    foreach (var producto in productos)
                    {
                        producto.MostrarDetalles();
                    }
                    break;
                case 1:
                    Console.Clear();
                    buscar(productos);
                    break;
                case 2: Console.Clear();
                    eliminar(productos);
                    break;
                case 3: Console.Clear();
                    crear(productos);
                    break;  
                    case 4: Console.Clear();
                    total(productos);
                    break;

            }
        }
        public void buscar(List<ProductoElectronico> productos)
        {
            string buscar;
            bool encontrado = true;
            Console.Write("Buscar:");
            buscar = Console.ReadLine();

            foreach (var producto in productos)
            {
                if (producto.Nombre == buscar)
                {
                    producto.MostrarDetalles();
                    encontrado = false;
                }
            }
            if (encontrado) Console.WriteLine("el producto que busca no se encuentra");
        }
        public void eliminar(List<ProductoElectronico> productos)
        {
            string buscar;
            bool encontrado = true;
            Console.Write("Indica como se llama el producto que desea eliminar:");
            buscar = Console.ReadLine();

            for (int i = productos.Count - 1; i > 0; i--)
            {
                if (productos[i].Nombre == buscar)
                {
                    productos.Remove(productos[i]);
                    encontrado = false;
                    Console.WriteLine("----------El producto se ha eliminado correctamente----------");
                    foreach (var producto in productos)
                    {
                        producto.MostrarDetalles();
                    }
                }
            }
            if (encontrado) Console.WriteLine("el producto que quiere eliminar no se encuentra");
        }
        public void crear(List<ProductoElectronico> productos)
        {
            string tipo;
            string nombre;
            double precio;
            string marca;
            string res;
            int mRam;
            string SO;
            Console.Write("Indique el tipo de producto que quiere crear(televisor, celular, laptop):");
            tipo = Console.ReadLine();
            if (tipo != "celular" && tipo != "televisor" && tipo != "laptop")
            {
                Console.WriteLine("No puede agregar ese tipo de producto");
            }
            else
            {
                Console.Write("Nombre del nuevo producto:");
                nombre = Console.ReadLine();
                Console.Write("Precio del nuevo producto:");
                precio = double.Parse(Console.ReadLine());
                Console.Write("Marca del nuevo producto:");
                marca = Console.ReadLine();
                if (tipo == "televisor")
                {
                    Console.Write("resolucion del nuevo producto:");
                    res = Console.ReadLine();
                    productos.Add(new Televisor(nombre, precio, marca, res));
                }
                else if (tipo == "celular")
                {
                    Console.Write("sistema operativo del nuevo producto:");
                    SO = Console.ReadLine();
                    productos.Add(new Telefono(nombre, precio, marca, SO));
                }
                else if (tipo == "laptop")
                {
                    Console.Write("Memoria Ram del nuevo producto:");
                    mRam = int.Parse(Console.ReadLine());
                    productos.Add(new Laptop(nombre, precio, marca, mRam));
                }
                Console.WriteLine("----------el producto se ha creado correctamente---------");
                foreach (var producto in productos)
                {
                    producto.MostrarDetalles();
                }
            }
        }
        public void total(List<ProductoElectronico> productos)
        {
            double total = 0;
            foreach (var producto in productos)
            {
                total += producto.Precio;
            }
            Console.WriteLine("El total de la factura es de $" + total);
        }
    }
    public class opcion
    {
        public string nombre;
        public int valor;
        public int pos;
        public opcion(int valor, string nombre, int pos)
            {
            this.valor = valor;
            this.nombre = nombre; this.pos = pos;
            }
    }
    public abstract class ProductoElectronico
    {
        private string nombre;
        private double precio;
        private string marca;
        public ProductoElectronico(string nombre, double precio, string marca)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.marca = marca;
        }
        
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public double Precio { get { return precio; } set { precio = value; } }
        public string Marca { get { return marca; } set { marca = value; } }

        public abstract void MostrarDetalles();
    }
    public class Telefono : ProductoElectronico 
    {
        private string sistemaOperativo;
        public string SistemaOperativo { get { return sistemaOperativo; } set { sistemaOperativo = value; } }
        public Telefono(string nombre, double precio, string marca, string sistemaOperativo) : base(nombre, precio, marca)
        {
            this.sistemaOperativo = sistemaOperativo;
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine("Nombre:" + Nombre + " - Precio:$" + Precio + " - Marca:" + Marca + " - Sistema Operativo:" + sistemaOperativo);
        }
    }
    public class Laptop : ProductoElectronico
    {
        private int memoriaRam;
        public int MemoriaRam { get { return memoriaRam; } set { memoriaRam = value; } }
        public Laptop(string nombre, double precio, string marca, int memoriaRam) : base(nombre, precio, marca)
        {
            this.memoriaRam = memoriaRam;
        }
        public override void MostrarDetalles()
        {
            Console.WriteLine("Nombre:" + Nombre + " - Precio:$" + Precio + " - Marca:" + Marca + " - Memoria Ram:" + memoriaRam);
        }
    }
    public class Televisor : ProductoElectronico
    {
        private string resolucion;
        public Televisor(string nombre, double precio, string marca, string resolucion) : base(nombre, precio, marca)
        {
            this.resolucion = resolucion;
        }
        public string Resolucion { get { return resolucion; } set { resolucion = value; } }
        public override void MostrarDetalles()
        {
            Console.WriteLine("Nombre:" + Nombre + " - Precio:$" + Precio + " - Marca:" + Marca + " - Resolucion:" + resolucion);
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            bool sel = false;
            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                {0,"productos" },{1,"buscar"},{2,"eliminar"},{3, "crear"},{4,"total"}
            };
            Opciones opciones = new Opciones(dic);
            List<ProductoElectronico> productos = new List<ProductoElectronico>();
            Televisor tv = new Televisor("tele 4k", 2332,"samsum", "1080x123");
            Telefono tf = new Telefono("celu", 21543,"adidas", "android");
            Laptop lp = new Laptop("compu", 200,"nike", 132);
            productos.Add(tv);
            productos.Add(tf);
            productos.Add(lp);
            opciones.dibujar();
            ConsoleKeyInfo tecla;
            while (true)
            {
                tecla = Console.ReadKey();
                if(tecla.Key == ConsoleKey.RightArrow)
                    opciones.derecha();
                if (tecla.Key == ConsoleKey.LeftArrow)
                    opciones.izquierda();
                if (tecla.Key == ConsoleKey.Enter) {
                    if (sel == false)
                        opciones.select(productos);
                    else { 
                        Console.Clear();
                        opciones.dibujar(); 
                    }
                    sel = !sel;
                }
            }
            //foreach(var producto in productos)
            //{
            //    producto.MostrarDetalles();
            //}
            //buscar(productos);
            //eliminar(productos);
            //crear(productos);
            //total(productos);


            Console.ReadKey();
        }
        
    }
}
