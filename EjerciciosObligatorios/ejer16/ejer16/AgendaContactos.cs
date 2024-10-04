using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ejer16
{
    public class AgendaContactos
    {
        private List<Contacto> agenda;
        private int tamañoAgenda;
        public AgendaContactos(int _tamañoAgenda) 
        { 
            agenda = new List<Contacto>();
            tamañoAgenda = _tamañoAgenda;
        }
        public AgendaContactos() 
        {
            agenda = new List<Contacto>();
            tamañoAgenda = 10;
        }
        public void añadirContacto(Contacto c)
        {
            if (agenda.Count < tamañoAgenda)
            {
                if (!existeContacto(c))
                {
                    agenda.Add(c);
                    Console.WriteLine("El contacto se ha guardado exitosamente");
                }
                else Console.WriteLine("El contacto ya existe");
            }
                
            else Console.WriteLine("Ya no se pueden agregar más contactos");
        }
        public bool existeContacto(Contacto c) 
        {
            bool existe = false;
            if (agenda.Any())
            {
                foreach (Contacto i in agenda)
                    if (i.Nombre == c.Nombre) existe = true;
            }
         return existe;
        }
        public void listarContactos()
        {
            Console.WriteLine("Lista de telefonos");
            Console.WriteLine();
            foreach(Contacto c in agenda)
            {
                Console.WriteLine($"Nombre: {c.Nombre} --- Num.Telefono: {c.Telefono}");
            }
        }
        public bool buscarContactos(string nombre)
        {
            bool contactoEncontrado = false;
            if (agenda.Any())
            {
                foreach (Contacto i in agenda)
                {
                    if (i.Nombre == nombre)
                    {
                        contactoEncontrado = true;
                        Console.WriteLine($"Nombre: {i.Nombre} --- Num.Telefono: {i.Telefono}");
                    }
                }
                if(!contactoEncontrado) Console.WriteLine($"El contacto que busca no existe");
            }
            else Console.WriteLine($"La agenda no tiene contactos");
            return contactoEncontrado;
        }
        public void eliminarContacto(string c)
        {
            bool contactoeliminado = false;
                for (int e = agenda.Count - 1; e >= 0; e--)
                {
                    if (agenda[e].Nombre == c)
                    {
                        agenda.RemoveAt(e);
                        Console.WriteLine("Se elimino correctamente el contacto");
                        contactoeliminado = true;
                    }
                }
                if (!contactoeliminado) Console.WriteLine("El contacto que esta tratando de eliminar no existe");

        }
        public bool agendaLLena()
        {
            if (agenda.Count >= tamañoAgenda)
            {
                Console.WriteLine("La agenda esta llena");
                return true;
            }
            Console.WriteLine("La agenda no esta llena");
            return false;
        }
        public int huecosLibres()
        {
            int huecos = 0;
            if (agenda.Count < tamañoAgenda)
            {
                huecos = tamañoAgenda - agenda.Count;
                Console.WriteLine($"La agenda tiene {huecos} huecos");
            }
            else Console.WriteLine("La agenda esta llena");
            return huecos;
        }
    }
}
