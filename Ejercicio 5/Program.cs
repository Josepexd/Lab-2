using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Write("Digite base (real): ");
            double baseNum = double.Parse(Console.ReadLine());
            Console.Write("Ingrese exponente (entero): ");
            int exponente = int.Parse(Console.ReadLine());
            double resultado = 1;
            int exp = exponente;
            if (exp < 0) exp = -exp;
            for (int i = 0; i < exp; i++)
                resultado *= baseNum;
            if (exponente < 0) resultado = 1 / resultado;
            Console.WriteLine($"Resultado: {resultado}");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
