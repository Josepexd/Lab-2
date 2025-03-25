using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Write("Nota teoría: ");
            double teoria = double.Parse(Console.ReadLine());
            Console.Write("Nota prácticas: ");
            double practicas = double.Parse(Console.ReadLine());
            double notaFinal2 = teoria * 0.6 + practicas * 0.4;
            Console.WriteLine($"Nota final: {notaFinal2:F2}");
            if (notaFinal2 >= 9)
                Console.WriteLine("Sobresaliente");
            else if (notaFinal2 >= 7)
                Console.WriteLine("Notable");
            else if (notaFinal2 >= 5)
                Console.WriteLine("Aprobado");
            else
                Console.WriteLine("Suspenso");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
