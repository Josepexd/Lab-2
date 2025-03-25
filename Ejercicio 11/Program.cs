using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Write("Ingrese número 1: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Ingrese número 2: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Ingrese número 3: ");
            z = int.Parse(Console.ReadLine());
            if (x < y && y < z)
                Console.WriteLine("Orden ascendente");
            else if (x > y && y > z)
                Console.WriteLine("Orden descendente");
            else
                Console.WriteLine("Desordenados");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
