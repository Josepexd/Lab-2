using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Write("Ingrese primer número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            if (n1 < n2) Console.WriteLine($"Ordenados: {n1}, {n2}");
            else Console.WriteLine($"Ordenados: {n2}, {n1}");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
