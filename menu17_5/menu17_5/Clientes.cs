using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu17_5
{
    internal class Clientes
    {
        public int numCli;
        public string nombreCli;
        public int dni;
        public Clientes(int numCli, string nombreCli, int dni)
        {
            this.numCli = numCli;
            this.nombreCli = nombreCli;
            this.dni = dni;
        }
    }
}
