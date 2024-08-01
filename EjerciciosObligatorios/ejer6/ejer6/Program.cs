using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro HP = new Libro(8478884459, "Harry Potter y la piedra filosofal", "J. K. Rowling", 256); 
            Libro Biblia = new Libro(9788425422355, "La Biblia", "Dios", 4138);
            HP.mostrarInformacion();
            Biblia.mostrarInformacion();
            Console.WriteLine(HP.NumPaginas>Biblia.NumPaginas ? $"{HP.Titulo} tiene más paginas que {Biblia.Titulo}" : $"{Biblia.Titulo} tiene más paginas que {HP.Titulo}");
            Console.ReadKey();
        }
    }
}
