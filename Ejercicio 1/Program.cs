using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            string nombre;
            double salario,incrementoCategoria, incrementoAnios, nuevoSalario;
            int años, categoria;
            Console.Write("Digite el nombre del empleado: ");
            nombre = Console.ReadLine();

            Console.Write("Salario actual: $");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Años trabajados: ");
            años = int.Parse(Console.ReadLine());

            Console.Write("Categoría (1, 2 o 3): ");
            categoria = int.Parse(Console.ReadLine());

            incrementoCategoria = 0;
            if (categoria == 1)
                incrementoCategoria = salario * 0.15;
            else if (categoria == 2)
                incrementoCategoria = salario * 0.10;
            else if (categoria == 3)
                incrementoCategoria = salario * 0.05;
            

            incrementoAnios = salario * 0.05 * años;
            nuevoSalario = salario + incrementoCategoria + incrementoAnios;
            Console.WriteLine($"{nombre}, su nuevo salario será: ${nuevoSalario:F2}");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
