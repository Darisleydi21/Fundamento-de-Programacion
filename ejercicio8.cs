using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserte primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserte segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if ((num1 > 0) && (num2 > 0))
            {
                Console.WriteLine("Ambos numero son positivos");
            }
            else if ((num1 < 0) && (num2 < 0))
            {
                Console.WriteLine("Ambos son negativos");
            }
            else 
            
                Console.WriteLine("Uno de ellos es positivo");
            
              
            Console.ReadKey();
        }
    }
}
