using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserte un numero: ");
           int num = Convert.ToInt32(Console.ReadLine());

            if (num % 4 == 0)
            {
                Console.WriteLine("Es multiplo de 4");

            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Es multiplo de 5");
            }
            else
            {
                Console.WriteLine("No es multiplo ni de 5, ni de 4");
            }

            Console.ReadKey();  
        
        }
    }
}
