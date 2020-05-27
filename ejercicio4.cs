using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Inserte primer numero para validar si es multiplo de 10: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 10 == 0)
            {
                Console.WriteLine("Numero 1 es multiplo de 10");
            }
            else
            
                Console.WriteLine("Numero 1 no es multiplo de 10");

            Console.Write("Inserte segundo numero para validar si es multiplo de 10: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 % 10 == 0)
            {
                Console.WriteLine("Numero2 es multiplo de 10");
            }
            else

                Console.WriteLine("Numero 2 no es multiplo de 10");

            Console.ReadKey();
        }
    }
}
