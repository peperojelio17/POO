using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forVSforeach
{
    internal class Program
    {

        /*-----------------------------Conclusion: El foreach toma se toma mas tiempo que el for-------------------------------*/
        static void Main(string[] args)
        {
            Stopwatch timeMeasure = new Stopwatch();
            int[] numeros = { 1, 2, 3, 4, 5 };
            int suma = 0;
            for (int i = 0; i< 5; i++)
            {
                timeMeasure.Start();
                suma = numeros[0] + numeros[2];
                suma = suma + numeros[3];
                suma = suma - numeros[0];
                suma = suma / numeros[1];
                timeMeasure.Stop();
                Console.WriteLine("El tiempo transcurrido en for es " + timeMeasure.Elapsed.TotalMilliseconds);
            }
            timeMeasure.Start();
            foreach(int num in numeros)
            {
                
                suma = numeros[0] + numeros[2];
                suma = suma + numeros[3];
                suma = suma - numeros[0];
                suma = suma / numeros[1];
                timeMeasure.Stop();
                Console.WriteLine( "El tiempo transcurrido en foreach es "+ timeMeasure.Elapsed.TotalMilliseconds);
            }
        }
    }
}
