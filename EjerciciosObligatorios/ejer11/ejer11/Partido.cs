using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer11
{
    public class Partido
    {
        private Random r;
        private string equipoA;
        private string equipoB;
        private string[] resultados = new string[] {"perdió", "ganó","empató"};
        public string EquipoA { get { return equipoA; } }
        public string EquipoB { get { return equipoB; } }
        public Partido() 
        { 
            r = new Random();
            resultado();
        }
        private void resultado()
        {
            var guid = Guid.NewGuid();
            var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 4));
            r = new Random(seed);
            int n = 0;
            n = r.Next(0,100);

            if (n <= 33)
            {
                equipoA = resultados[0];
                equipoB = resultados[1];
            }
            else if (n > 33 && n < 66)
            {
                equipoA = resultados[1];
                equipoB = resultados[0];
            }
            else 
            {
                equipoA = resultados[2];
                equipoB = resultados[2];
            }

        }
    }
}
