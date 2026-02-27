using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.condicionalesMultiplesOperaorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string diaSemana = "";
            float subTotal = 0;
            float descuento = 0;

            Console.WriteLine("ingrese el monto de la compra;");
            subTotal = Single.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el dia de la semana:");
            diaSemana = Console.ReadLine();

            switch (diaSemana)
            {
                case "lunes":
                    descuento = subTotal * 0.1f; //sufijo f para poder usarlo como float
                    Console.WriteLine($"hoy es lunes, el descuento es de {descuento}, el total a pagar es {subTotal - descuento}");
                    break;
                case "martes":
                    descuento = subTotal * 0.15f; //sufijo f para poder usarlo como float
                    Console.WriteLine($"hoy es mates, el descuento es de {descuento}, el total a pagar es {subTotal - descuento}");
                    break;
                case "miercoles":
                    descuento = subTotal * 0.1f; //sufijo f para poder usarlo como float
                    Console.WriteLine($"hoy es miercoles, el descuento es de {descuento}, el total a pagar es {subTotal - descuento}");
                    break;
                case "jueves":
                    descuento = subTotal * 0.15f; //sufijo f para poder usarlo como float
                    Console.WriteLine($"hoy es jueves, el descuento es de {descuento}, el total a pagar es {subTotal - descuento}");
                    break;
                case "viernes":
                    descuento = subTotal * 0.2f; //sufijo f para poder usarlo como float
                    Console.WriteLine($"hoy es viernes, el descuento es de {descuento}, el total a pagar es {subTotal - descuento}");
                    break;
                case "sabado":
                    descuento = subTotal * 0.2f; //sufijo f para poder usarlo como float
                    Console.WriteLine($"hoy es sabado, el descuento es de {descuento}, el total a pagar es {subTotal - descuento}");
                    break;
                case "domingo":
                    descuento = 0;
                    Console.WriteLine($"hoy es domingo, el descuento es de {descuento}, el total a pagar es {subTotal - descuento}");
                    break;

                default:
                    Console.WriteLine("porfavor imgrese un dia correcto");
                    break;


            }*/

            int numero1 = 0;
            int numero2 = 0;
            int operacion = 0;

            Console.WriteLine("ingrese el numero 1:");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el numero 2:");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("selecione el tipo de operacion que desea hacer:");
            Console.WriteLine("1.Suma");
            Console.WriteLine("2.resta");
            Console.WriteLine("3.multiplicacion");
            Console.WriteLine("4.division");
            operacion = Convert.ToInt32(Console.ReadLine());

            switch (operacion)
            {
                case 1:
                    Console.WriteLine($"la suma de los numeros es {numero1 + numero2}");
                    break;
                    case 2:
                    Console.WriteLine($"la resta de los numeros es {numero1 - numero2}");
                    break;
                    case 3:
                    Console.WriteLine($"la multiplicaciion de los numeros es {numero1 * numero2}");
                    break;
                    case 4:
                    Console.WriteLine($"la division de los numeros es {numero1 / numero2}");
                    break;

                default:
                    Console.WriteLine("ingrese una opcion valida");
                    break;
            }
        }
    }
}
