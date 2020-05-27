using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            int producto;

            Console.Write("Inserte primer numero para realizar la multiplicacion: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 == 0)

            {
                Console.WriteLine("Todo numero multiplicado por 0 es igual a 0");
            }
            else
                Console.Write("Inserte segundo numero para realizar la multiplicacion: ");
                  int num2 = Convert.ToInt32(Console.ReadLine());

            producto = num1 * num2;

            Console.WriteLine("El producto de los numeros es: " + producto);

            Console.ReadKey();
     
        }
    }
}
