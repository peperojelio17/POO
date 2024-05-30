using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia24_5
{
    public class Animales
    {
        private string nombre; // nombre es un atributo

        public string Nombre {  get { return nombre; } set { nombre = value; } } //Nombre es un propiedad
        public void comer()
        {

        }
        public void caminar()
        {

        }
    }
    public class Felino : Animales { }
    public class Canino : Animales {
    public Canino(string nombre) {
            base.Nombre = nombre;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Canino perro1 = new Canino("perroBlanco");
            Canino perro2 = new Canino("perroNegro");
            Felino gato1 = new Felino();
            perro1.Nombre = "hola";
        }
    }
}
