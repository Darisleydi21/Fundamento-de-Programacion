using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserte el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserte el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("El mayor es: " + num1);
  
            }
            else
                Console.WriteLine("El numero mayor es: " + num2);

                Console.ReadKey();
            
        }
    }
}
