using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ejer15
{
    public class Almacen
    {
        private Bebida b1;
        private Bebida b2;
        private Bebida b3;
        private Bebida b4;
        public List<List<Bebida>> bebidas;
        private int cantBebidasPorEstante;
        private int estante;
        private int posicion;

        private bool insertar;
        private int[] posI;
        public Almacen()
        {
            b1 = new Bebida(0, 0, 0, "");
            estante = 0;
            posicion = 0;
            insertar = false;
            posI = new int[1];
            bebidas = new List<List<Bebida>>() { new List<Bebida>() { b1, b1, b1, b1, b1 } };
        }
        public void mostrarInformacion()
        {
            int estante = 0;
            foreach (var item in bebidas)
            {
                
                Console.WriteLine($"Estanteria {estante++}");
                foreach (var i in item)
                {
                    
                    if (i != b1) 
                    {
                        if (i is BebidasAzucarada)
                        {
                            BebidasAzucarada ba = (BebidasAzucarada)i;
                            Console.WriteLine($"Bebida {i.Id} (Bebida Azucarada) --- Marca: {i.Marca} --- Precio: ${i.Precio} --- Cantidad de litros: {i.CantLitros} --- Porc. de azucar: %{ba.PorcentajeAzucar}" + ((ba.Promocion) ? " --- Tiene promocion" : ""));
                        }
                        else if (i is AguaMineral)
                        {
                            AguaMineral am = (AguaMineral)i;
                            Console.WriteLine($"Bebida {i.Id} (Agua Mineral) --- Marca: {i.Marca} --- Precio: ${i.Precio} --- Cantidad de litros: {i.CantLitros} --- Origen: {am.Origen}" );
                        }
                        else Console.WriteLine($"Bebida {i.Id} --- Marca: {i.Marca} --- Precio: ${i.Precio} --- Cantidad de litros: {i.CantLitros}");
                    } 
                }
                Console.WriteLine();
            }
        }
        public void AgregarProducto(Bebida b)
        {
            bool idRepetido = false;
            for (int e = 0; e < bebidas.Count; e++)
            {
                for (int i = 0; i < bebidas[0].Count; i++)
                {
                    if (bebidas[e][i] == b1 && !insertar)
                    {
                        posI = new int[] { e, i };
                        insertar = true;
                    }
                    if (bebidas[e][i].Id == b.Id && !insertar)
                        idRepetido = true;
                }
            }
            if (!idRepetido)
            {
                if (insertar) bebidas[posI[0]][posI[1]] = b;
                else
                {
                    posicion = 0;
                    estante++;
                    bebidas.Add(new List<Bebida>() { b1, b1, b1, b1, b1 });
                    bebidas[estante][posicion] = b;
                    posicion++;
                }
            }
            else Console.WriteLine("El Id de esta bebida ya existe");
            insertar = false;

        }
        public void EliminarProducto(int id)
        {
            for (int e = bebidas.Count - 1; e >= 0; e--)
            {
                for (int i = bebidas[0].Count - 1; i >= 0; i--)
                {
                    if (bebidas[e][i].Id == id)
                    {
                        bebidas[e][i] = b1;
                    }
                }
            }
        }
        public int precioBebidas()
        {
            int precioTotal = 0;
            for (int e = 0; e < bebidas.Count; e++)
                for (int i = 0; i < bebidas[0].Count; i++)
                    precioTotal += bebidas[e][i].Precio;
            return precioTotal;
        }
        public int precioMarca(string marca)
        {
            int pMarca = 0;
            for (int e = 0; e < bebidas.Count; e++)
                for (int i = 0; i < bebidas[0].Count; i++)
                    pMarca += (bebidas[e][i].Marca == marca) ? bebidas[e][i].Precio : 0;
            return pMarca;
        }
        public string precioEstanteria(int estanteria)
        {
            string pEstanteria = "";
            if (estanteria <= bebidas.Count)
            {
                int precioEstanteria = 0;
                for (int i = 0; i < bebidas[estanteria].Count; i++)
                    precioEstanteria += bebidas[estanteria][i].Precio;
                pEstanteria = precioEstanteria.ToString();
            }
            else pEstanteria = "Esa estanteria esta fuera de rango";
            return pEstanteria;
        }
    }
}
