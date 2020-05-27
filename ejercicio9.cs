using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Inserte primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserte segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserte tercer numero: ");
            int num3 = Convert.ToInt32(Console.ReadLine());


            if (num1 < num2)
            {
                if (num2 < num3)
                {
                    Console.WriteLine("{0} es mayor", num3);
                }
                else
                    Console.WriteLine("{0} es mayor", num2);
            }
            else if (num1 > num2)
            {
                if (num1 < num3)
                {
                    Console.WriteLine("{0} es mayor", num3);
                }
                else
                    Console.WriteLine("{0} es mayor", num1);
            }
            Console.ReadKey();
        }
    }
}
