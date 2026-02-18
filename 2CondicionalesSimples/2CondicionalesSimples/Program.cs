using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2CondicionalesSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string nombre = "";
            float sueldo = 0;

            Console.WriteLine("ingrese el nombre del usuario");
            nombre = Console.ReadLine();//lo que llega desde la consola es de tipo string
            Console.WriteLine("ingrese el sueldo del usuario");
            sueldo = Convert.ToSingle(Console.ReadLine());

            if (sueldo>=3000)
            {
                Console.WriteLine($"La persona {nombre}, deberia abonar impuestos");
            }*/

            //crear un algoritmo que lea la edad de un usuario y si es mayor de 18 años mostrar "bienvenido a mi web

            float edad = 0;

            Console.WriteLine("ingrese la edad del usuario");
            edad = Convert.ToSingle(Console.ReadLine());

            if (edad >=18)
            {
                Console.WriteLine("vienvenido a mi web");
            } else
            {
                Console.WriteLine("el usuario no esta autorizado a entrar en esta web");
            }
        }
    }
}
