using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia24_5
{
    public class Animales
    {
        private string cuentabancaria; // nombre es un atributo
        public int valornumerico;

        public void comer()
        {

        }
        public void caminar()
        {

        }
        private void ordenar()
        {
            for (int i = 0; i < 10; i++)
            {
                if(cuentabancaria == "hola")
                {

                }
            }
        }

        public string Nombre { get { return cuentabancaria; } set { cuentabancaria = value; } } //Nombre es un propiedad
    }
    public class Perro : Animales
    {
        
    }
}
