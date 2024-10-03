using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AgendaContactos agenda = new AgendaContactos(4);
            //agenda.añadirContacto(new Contacto("Manuel", 143));
            //agenda.añadirContacto(new Contacto("Mariano", 112));
            //agenda.añadirContacto(new Contacto("Manuel", 143));
            //agenda.añadirContacto(new Contacto("Mirando", 143));
            //agenda.añadirContacto(new Contacto("Rodrigo", 112));
            //agenda.añadirContacto(new Contacto("Sofia", 143));
            //agenda.añadirContacto(new Contacto("Milanesa", 143));
            //agenda.añadirContacto(new Contacto("Hernesto", 112));

            //agenda.eliminarContacto(new Contacto("Milanesa", 143));

            //agenda.listarContactos();
            //Console.WriteLine();
            //agenda.buscarContactos("Mariano");
            //agenda.agendaLLena();
            //agenda.huecosLibres();
            MenuAgenda menuAgenda = new MenuAgenda();
            menuAgenda.dibujar();
            while (true) 
            {
                menuAgenda.controles(Console.ReadKey());
            }
        }
    }
}
