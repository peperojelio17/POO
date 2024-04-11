using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num <= 100)
            {
                Console.WriteLine(num);
                num = num + 1;
            }
            Console.ReadKey();
        }
    }
}
