using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer2
{
    public class Persona
    {
        private string nombre = "";
        private int edad = 0;
        private string dni;
        private char sexo;
        private double peso = 0;
        private double altura = 0;
        public Persona() {
            dni = generaDNI();
            Sexo = comprobarSexo(' ');
        }
        public Persona(string _nombre, int _edad, char _sexo)
        {
            Nombre = _nombre;
            Edad = _edad;
            Sexo = comprobarSexo(_sexo);
            dni = generaDNI();
        }
        public Persona(string _nombre, int _edad, char _sexo, double _peso, double _altura) {
            Nombre = _nombre;
            Edad = _edad;
            dni = generaDNI();
            Sexo = comprobarSexo(_sexo);
            Peso = _peso;
            Altura = _altura;
        }
        
        public string Nombre{ get {  return nombre; } set { nombre = value; }}
        public int Edad{ get { return edad; } set { edad = value; } }
        public double Peso{ get { return peso; } set { peso = value; } }
        public double Altura { get { return altura; } set { altura = value; } }
        public char Sexo { get { return sexo; } set { sexo = value; } }
        public string DNI { get { return dni; }}

        public int calcularIMC()
        {
            double imc = peso / (altura * altura);
            if (imc < 20) return -1;
            if (imc >= 20 && imc <= 25) return 0;
            else if (imc > 25) return 1;
            else return 2;
        }
        public bool esMayorDeEdad()
        {
            if(edad > 18) return true;
            else return false;
        }
        private char comprobarSexo(char _sexo)
        {
            char hombre = 'H';
            if (_sexo == 'H' || _sexo == 'M') return _sexo;
            else return hombre;
        }
        public string generaDNI()
        {
            // Esto esta para asegurar que el numero sea aleatorio porque el dni no me estaba dando numeros aleatorios y al investigar parece
            // que Random es pseudoaleatorio porque genera un valor a partir del reloj del sistema (probablemente haya mejores formas de hacerlo
            // pero esta fue la más fiable que encontre)
            var guid = Guid.NewGuid();
            var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 4));


            Random r = new Random(seed);
            int dnin = r.Next(10000000, 99999999);
            string[] letras = { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "ñ", "z", "x", "c", "v", "b", "n", "m" };
            int letra = dnin % 23;
            string dnil = letras[letra];
            return dnin + dnil;
        }
    }
}
