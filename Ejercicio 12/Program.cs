using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Write("Lado 1: ");
            int l1 = int.Parse(Console.ReadLine());
            Console.Write("Lado 2: ");
            int l2 = int.Parse(Console.ReadLine());
            Console.Write("Lado 3: ");
            int l3 = int.Parse(Console.ReadLine());

            if (l1 + l2 > l3 && l1 + l3 > l2 && l2 + l3 > l1)
            {
                if (l1 == l2 && l2 == l3)
                    Console.WriteLine("Triángulo equilátero");
                else if (l1 == l2 || l1 == l3 || l2 == l3)
                    Console.WriteLine("Triángulo isósceles");
                else
                    Console.WriteLine("Triángulo escaleno");
            }
            
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
