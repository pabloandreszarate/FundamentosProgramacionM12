using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CondicionalesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("ingrese el valor 1:");
            num1  = Int32.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el valor numero 2:");
            num2 = Convert.ToInt32((string)Console.ReadLine());

            Console.WriteLine("ingrese el valor 3:");
            num3 = Convert.ToInt32((string)Console.ReadLine());

            if (num1<num2)
            {
                if (num1>num3)
                {
                    Console.WriteLine($"el mayor es el: {num1}");
                }
                else
                {
                    Console.WriteLine($"el mayor es el: {num3}");
                }
            }
            else
            {
                if (num2>num3)
                {
                    Console.WriteLine($"el mayor es el: {num2}");
                }
                else
                {
                    Console.WriteLine($"el mayor es el {num3}");
                }
            }
        }
    }
}
