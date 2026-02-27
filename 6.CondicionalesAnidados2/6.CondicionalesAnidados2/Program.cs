using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _6.CondicionalesAnidados2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1 = 0;
            float nota3 = 0;
            float nota2 = 0;
            float promedio = 0;

            Console.WriteLine("ingrese la nota numero 1:");
            nota1 = Single.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la nota numero 2:");
            nota2 = Single.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la nota numero 3:");
            nota3 = Single.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) /3;

            if (promedio>=9.5 && promedio<=10.0)
            {
                Console.WriteLine("el promedio es exelente");
            }
            else
            {
                if (promedio>=8.5 && promedio<=9.4)
                {
                    Console.WriteLine("el promedio esta muy bien");
                }
                else 
                {   
                   if (promedio >= 7.5 && promedio < 8.5)
                    {
                        Console.WriteLine("el promedio esta bien");
                    }
                    else
                    {
                        Console.WriteLine("el promedio no esta en el rango de notas");
                    }
 
                }
            }


        }
    }
}
