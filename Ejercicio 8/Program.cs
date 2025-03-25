using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Write("Ingrese primer número: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese segundo número: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Operación (+, -, *, /): ");
            char op = char.Parse(Console.ReadLine());
            switch (op)
            {
                case '+': Console.WriteLine($"Resultado: {a + b}"); break;
                case '-': Console.WriteLine($"Resultado: {a - b}"); break;
                case '*': Console.WriteLine($"Resultado: {a * b}"); break;
                case '/':
                    if (b != 0) Console.WriteLine($"Resultado: {a / b}");
                    else Console.WriteLine("No se puede dividir entre cero.");
                    break;
                default: Console.WriteLine("Operación inválida"); break;
            }
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
