using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Inserte primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserte segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 % num2 == 0)
            {
                Console.WriteLine("Es multiplo");
            }
            else 

                Console.WriteLine("No es multiplo");

            Console.ReadKey();

        }
    }
}
