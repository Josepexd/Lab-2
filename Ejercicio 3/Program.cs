using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Write("Digite la temperatura en Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"Temperatura en Celsius: {celsius:F2} °C");
            if (celsius <= 0) Console.WriteLine("Color: Azul - Frío extremo");
            else if (celsius <= 15) Console.WriteLine("Color: Celeste - Frío");
            else if (celsius <= 25) Console.WriteLine("Color: Verde - Templado");
            else if (celsius <= 35) Console.WriteLine("Color: Amarillo - Calor moderado");
            else Console.WriteLine("Color: Rojo - Calor extremo");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
