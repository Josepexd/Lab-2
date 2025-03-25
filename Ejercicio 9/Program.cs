using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Write("Nota examen final: ");
            double notaExamen = double.Parse(Console.ReadLine());
            Console.Write("Nota exámenes parciales: ");
            double notaParciales = double.Parse(Console.ReadLine());
            Console.Write("Nota de prácticas: ");
            double notaPracticas = double.Parse(Console.ReadLine());
            double notaFinal = notaExamen * 0.4 + notaParciales * 0.4 + notaPracticas * 0.2;
            Console.WriteLine($"Nota final: {notaFinal:F2}");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
