using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _8.TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1,
            numero2, numero3 respectivamente.El algoritmo debe comprobar si los números son
            diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
            pantalla los números de menor a mayor.
            Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben
            ingresar números diferentes.*/

            /*int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;

            Console.WriteLine("ingrese el numero 1:");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el numero 2:");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el numero 3:");
            numero3 = Convert.ToInt32(Console.ReadLine());*/



            /*El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si
            cuenta con munición y si se encuentra en estado invencible, crear un programa que:
            a.Permita ingresar por teclado si el personaje está en estado invencible(True).
            b.La cantidad de munición que tiene el personaje en el momento será calculada por el
            sistema por medio de un número aleatorio, para ello utilizar la clase Random de C#.*/

            bool invencibilidad = true;
            int CantidadMunicion = 0;

            Random rnd = new Random();
            CantidadMunicion = rnd.Next(0, 10);

            Console.WriteLine("ingrese el estado de invencibilidad del personaje");
            Console.WriteLine("1. es invencible");
            Console.WriteLine("2. no es invencible");
            int respuesta = Convert.ToInt32(Console.ReadLine());

            if (respuesta == 1)
            {
                invencibilidad &= true;
                
                if (CantidadMunicion >=1)
                {
                    Console.WriteLine($"el personaje esta disparando y tiene {CantidadMunicion} de municion");
                }
                else
                {
                    Console.WriteLine("el personaje no tiene municion");
                }
            }
            else
            {
                if (respuesta == 2)
                {
                    invencibilidad &= false;
                    Console.WriteLine("el personaje no puede disparar poque no es invencible");
                }
                else
                {
                    if (respuesta >= 3)
                    {
                        Console.WriteLine("ingrese una opcion valida");
                    }
                }
            }

            /*El personaje de un juego, solo se puede mover en forma horizontal(Izquierda o Derecha),
            crear un programa que muestre en la consola un mensaje diciendo si el personaje se mueve
            hacia la izquierda o hacia la derecha, según la tecla que se presione en el teclado.
             Si se ingresa el carácter ‘d’, se muestra el mensaje “El personaje se mueve hacia la
            derecha
             Si se ingresa el carácter ‘i’, se muestra el mensaje “El personaje se mueve hacia la derecha
             En caso contrario, se debe mostrar un mensaje de error “No me puedo mover en otra
            dirección” */

            string direccion = "";

            Console.WriteLine("ingrese la direccion hacia la que se mueve el personaje:");
            Console.WriteLine("i: izquierda");
            Console.WriteLine("d. derecha");
            direccion = Convert.ToString(Console.ReadLine());

            switch (direccion)
            {
                case "i": 
                    Console.WriteLine("el personaje avanza hacia la izquierda");
                    break;

                case "d":
                    Console.WriteLine("el personaje avanza hacia la derecha");
                    break;

                default:
                    Console.WriteLine("no me puedo mover en otra direccion");
                    break;
            }

        }
    }
}
