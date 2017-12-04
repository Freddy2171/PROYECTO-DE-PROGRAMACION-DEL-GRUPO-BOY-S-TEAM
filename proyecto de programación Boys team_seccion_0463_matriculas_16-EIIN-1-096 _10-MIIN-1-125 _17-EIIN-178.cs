using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string linea;
            Console.Write("Ingrese Multiplicacdor: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);

            for(int i=1; i<=15; i++)
            {
                Console.Write(i + " x " + n + " = " + i * n + "\n");
            }
            Console.ReadKey();
        }
    }
}
