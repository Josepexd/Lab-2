using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, absoluto;
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Write("Ingrese un número (entero o real): ");
            valor = double.Parse(Console.ReadLine());
            absoluto = valor < 0 ? -valor : valor;
            Console.WriteLine($"Valor absoluto: {absoluto}");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
