using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer2
{
    public class Persona
    {
        private const string hombre = "";
        
        private string nombre = "";
        private int edad = 0;
        private int dni = 0;
        private char sexo;
        private int peso = 0;
        private int altura = 0;


        public Persona() { }
        public Persona(string _nombre, int _edad, char _sexo)
        {
            Nombre = _nombre;
            Edad = _edad;
            Sexo = comprobarSexo(_sexo);
        }        
        public Persona(string _nombre, int _edad, int _dni, char _sexo, int _peso, int _altura) {
                Nombre = _nombre;
                Edad = _edad;
                Dni = _dni;
                Sexo = comprobarSexo(_sexo);
                Peso = _peso;
                Altura = _altura;
        }
        
        public string Nombre{ get {  return nombre; } set { nombre = value; }}
        public int Edad{ get { return edad; } set { edad = value; } }
        public int Dni{ get { return dni; } set { dni = value; } }
        public int Peso{ get { return peso; } set { peso = value; } }
        public int Altura { get { return altura; } set { altura = value; } }
        public char Sexo { get { return sexo; } set { sexo = value; } }

        public int calcularIMC()
        {
            int imc = peso / (altura * altura);
            if (imc < 20) return -1;
            if (imc >= 20 && imc <= 25) return 0;
            else return 1;
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
            Random r = new Random();
            int dniN = r.Next(10000000, 99999999);
            string[] letras = { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Ñ", "Z", "X", "C", "V", "B", "N", "M" };
            int letra = dniN % 23;
            string dniL = letras[letra];
            return dniN + dniL;
        }
    }
}
