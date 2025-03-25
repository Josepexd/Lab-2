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
            if (exp < 0)
            {
                exp = -exp;
                baseNum = 1.0 / baseNum;
            }

            if (exp == 1)
            {
                resultado = baseNum;
            }
            else if (exp == 2)
            {
                resultado = baseNum * baseNum;
            }
            else if (exp == 3)
            {
                resultado = baseNum * baseNum * baseNum;
            }
            else if (exp == 4)
            {
                resultado = baseNum * baseNum * baseNum * baseNum;
            }
            else if (exp == -1)
            {
                resultado = resultado = -(baseNum);
            }
            else if (exp == -2)
            {
                resultado = baseNum - (baseNum);
            }
            else if (exp == -3)
            {
                resultado = baseNum - (baseNum * baseNum);
            }
            else if (exp == -4)
            {
                resultado = baseNum - (baseNum * baseNum * baseNum);
              }
                {
            }


                Console.WriteLine($"Resultado: {resultado}");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
