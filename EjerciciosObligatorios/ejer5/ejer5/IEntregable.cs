using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer5
{
    public interface IEntregable
    {
        void entregar();
        void devolver();
        bool isEntregado();
        int compareTo(int a);
    }
}
