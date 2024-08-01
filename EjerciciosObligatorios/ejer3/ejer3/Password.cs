using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer3
{
    public class Password
    {
        private int longitud;
        private string contraseña;
        private string[] mayusculas = { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Ñ", "Z", "X", "C", "V", "B", "N", "M" };
        private string[] minusculas = { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "ñ", "z", "x", "c", "v", "b", "n", "m" };
        
        public int Longitud { get { return longitud; } set {  longitud = value; } }
        public string Contraseña { get { return contraseña; } }
        public Password()
        {
            longitud = 8;
            contraseña = generarPassword();
        }
        public Password(int _longitud)
        {
            longitud = _longitud;
            contraseña = generarPassword();
        }
        private string generarPassword()
        {
            var guid = Guid.NewGuid();
            var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 4));

            Random r = new Random(seed);
            string[] letras = mayusculas.Union(minusculas).ToArray();
            for (int i = 0; i < longitud; i++) { 
                int num = r.Next(0,99);
                contraseña += (num < letras.Length) ? letras[num]: r.Next(0, 9).ToString();
            }
            return contraseña;
        }
        public bool esFuerte()
        {
            int lMay = 0;
            int lMin = 0;
            int lNum = 0;
            int valor = 0;
            bool fuerte = false;
            foreach (var letra in contraseña) 
            {
                foreach(var may in mayusculas)
                {
                    if (may == letra.ToString())
                    {
                        lMay += 1;
                        valor = 1;
                    }
                }
                if (valor != 1)
                {
                    foreach (var min in minusculas)
                    {
                        if (min == letra.ToString())
                        {
                            lMin += 1;
                            valor = 1;
                        }
                    }
                }
                if (valor != 1)
                {
                    for (int i = 0; i <= 9; i++)
                    {
                        if (i == int.Parse(letra.ToString()))
                        {
                            lNum += 1;
                        }
                    }
                }
                valor = 0;
            }
            if(lMay > 2 && lMin > 1 && lNum > 5) fuerte = true;
            return fuerte;
        }

    }
}
