using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Inserte primer numero: ");
            decimal num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserte segundo numero: ");
            decimal num2 = Convert.ToInt32(Console.ReadLine());
            

            if (num2 == 0)
            {
                Console.WriteLine("No es posible dividir entre cero");
               

            }
            else
                Console.WriteLine("El resultado de la division es: " + num1/num2);

            Console.ReadKey();
        
        
        }
    }
}
