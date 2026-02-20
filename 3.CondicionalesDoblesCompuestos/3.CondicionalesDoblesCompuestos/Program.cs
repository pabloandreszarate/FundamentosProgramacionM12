using System;

namespace _3.CondicionalesDoblesCompuestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*crear un algoritmo que permita intrducir el nombre y sueldo de una persona y si el sueldo supera los 3000 mostrar el mensaje que diga que debe abonar impuestos, de lo contrario mostar un mensaje que diga que la persona esta exenta*/

            /*string nombre = "";
            float sueldo = 0;

            Console.WriteLine("ingrese el nombre del usario");
            nombre = Console.ReadLine();

            Console.WriteLine("ingrese el valor del sueldo");
            sueldo = Single.Parse(Console.ReadLine());

            if (sueldo >= 3000)
            {
                Console.WriteLine($"el usuario {nombre} debe pagarimpuestos"); //si la condicion es verdadera
            }
            else
            {
                Console.WriteLine($"el usuario {nombre} esta exento de pagar impuestos"); //si la condicion es falsa
            }*/

            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("ingrese el primer numero:");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero:");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine($"la suma de los dos numeros es {numero1 + numero2} y la diferencia entre ambos es {numero1 - numero2}");
            }
            else
            {
                Console.WriteLine($"la division entre amobos numeros es {numero1/numero2} y wl producto entre ambos es {numero1*numero2}");
            }
        }
    }
}
