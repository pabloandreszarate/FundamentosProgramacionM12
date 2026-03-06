using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* A continuación, encontrará el enunciado que debe utilizar para realizar un programa en C#, que dé solución al problema allí planteado. (70%)
            Un conjunto de personas ha sido clasificado en cuatro grupos denominados A, B, C y D, según tres criterios: sexo, edad y último dígito del documento de identidad. La asignación a los grupos se realiza de acuerdo con las siguientes reglas:
            Grupo A
            Pertenecen al grupo A las personas que cumplan alguna de estas dos condiciones:
            Mujeres con edad entre 16 y 20 años (inclusive), y cuyo documento de identidad termine en 0, 4 o 8.
            Hombres con edad entre 18 y 22 años (inclusive), y cuyo documento de identidad termine en 1, 5 o 9.
            Grupo B
            Pertenecen al grupo B las personas que cumplan alguna de estas dos condiciones:
            Mujeres con edad entre 21 y 25 años (inclusive), y cuyo documento de identidad termine en 3 o 7.
            Hombres con edad entre 23 y 26 años (inclusive), y cuyo documento de identidad termine en 2 o 6.
            Grupo C
            Pertenecen al grupo C las personas de cualquier sexo que cumplan ambas condiciones:
            Tienen 15 años de edad
            Dominen el idioma inglés
            Nota: Solo se debe preguntar sobre el dominio del inglés si la persona tiene 15 años.
            Grupo D
            Pertenecen al grupo D todas aquellas personas que no cumplen con ninguno de los criterios anteriores.
            Objetivo del programa
            Desarrolla un programa que:
            Solicite al usuario los siguientes datos:
            Sexo (masculino o femenino)
            Edad (número entero positivo)
            Último dígito del documento de identidad (número del 0 al 9)
            Dominio del idioma inglés (solo si tiene 15 años, como “sí” o “no”)
            Analice la información ingresada y determine a qué grupo pertenece la persona.
            Muestre en pantalla el grupo correspondiente.*/

            int sexo = 0;
            int edad = 0;
            int NumIdentidad = 0;
            int ingles = 0;

            Console.WriteLine("Seleccione su sexo:");
            Console.WriteLine("1.Fmenino");
            Console.WriteLine("2.Masculino");
            sexo = Convert.ToInt32(Console.ReadLine());

            switch (sexo)
            {
                case 1:
                    Console.WriteLine("ingrese su edad:");
                    edad = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ingrese el ultimo digito de su ducumento de identidad");
                    NumIdentidad = Convert.ToInt32(Console.ReadLine());

                    if (edad == 15)
                    {
                        Console.WriteLine("Usted posee dominio del idioma ingles:");
                        Console.WriteLine("1.Si");
                        Console.WriteLine("2.No");
                        ingles = Convert.ToInt32(Console.ReadLine());

                        if (ingles == 1)
                        {
                            Console.WriteLine("usted pertenece al grupo C");
                        }
                        else
                        {
                            if (ingles == 2)
                            {
                                Console.WriteLine("usted pertenece al grupo D");
                            }
                        }
                    }
                    if (edad > 15)
                    {
                        if (edad <= 20)
                        {
                            switch(NumIdentidad)
                            {
                                case 0:
                                    Console.WriteLine("usted pertenece al grupo A");
                                    break;

                                    case 4:
                                    Console.WriteLine("usted pertenece al grupo A");
                                    break;

                                    case 8:
                                    Console.WriteLine("usted pertenece al grupo A");
                                    break;

                                default:
                                    Console.WriteLine("usted pertenece al grupo D");
                                    break;
                            }

                        }
                        else
                        {
                            if (edad >=25)
                            {
                                switch (NumIdentidad)
                                {
                                    case 3:
                                        Console.WriteLine("usted pertenece al grupo B");
                                        break;

                                    case 7:
                                        Console.WriteLine("usted pertenece al grupo B");
                                        break;

                                    default:
                                        Console.WriteLine("usted pertenece al grupo D");
                                        break;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (edad < 15)
                        {
                            Console.WriteLine("Usted pertenece al grupo D");
                        }

                    }
                    break;

                    case 2:
                    Console.WriteLine("ingrese su edad:");
                    edad = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ingrese el ultimo digito de su ducumento de identidad");
                    NumIdentidad = Convert.ToInt32(Console.ReadLine());

                    if (edad == 15)
                    {
                        Console.WriteLine("Usted posee dominio del idioma ingles:");
                        Console.WriteLine("1.Si");
                        Console.WriteLine("2.No");
                        ingles = Convert.ToInt32(Console.ReadLine());

                        if (ingles == 1)
                        {
                            Console.WriteLine("usted pertenece al grupo C");
                        }
                        else
                        {
                            if (ingles == 2)
                            {
                                Console.WriteLine("usted pertenece al grupo D");
                            }
                        }
                    }
                    if (edad > 17)
                    {
                        if (edad <= 22)
                        {
                            switch (NumIdentidad)
                            {
                                case 1:
                                    Console.WriteLine("usted pertenece al grupo A");
                                    break;

                                case 5:
                                    Console.WriteLine("usted pertenece al grupo A");
                                    break;

                                case 9:
                                    Console.WriteLine("usted pertenece al grupo A");
                                    break;

                                default:
                                    Console.WriteLine("usted pertenece al grupo D");
                                    break;
                            }

                        }
                        else
                        {
                            if (edad >= 26)
                            {
                                switch (NumIdentidad)
                                {
                                    case 2:
                                        Console.WriteLine("usted pertenece al grupo B");
                                        break;

                                    case 6:
                                        Console.WriteLine("usted pertenece al grupo B");
                                        break;

                                    default:
                                        Console.WriteLine("usted pertenece al grupo D");
                                        break;
                                }
                            }
                        }

                    }
                    else
                    {
                        if (edad < 15)
                        {
                            Console.WriteLine("Usted pertenece al grupo D");
                        }

                    }
                    break;

                default:
                    Console.WriteLine("Usted pertenece al grupo D");
                    break;
            }
        }
    }
}
