using System;

namespace Clase1___Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = @"Programa, Lista de Años Bisiestos";
            uint anioInicial;
            uint anioFinal;

            anioInicial = IngresarNumeroNatural("Ingrese año inicial del calculo: ");
            anioFinal = IngresarNumeroNatural("Ingrese año final del calculo: ");


            Console.WriteLine("\nLa Lista de años bisiestos entre {0} y {1} es: ", anioInicial, anioFinal);
            for (uint i = anioInicial + 1; i < anioFinal; i++)
            {
                if (EsBisiesto(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.Write("Presione una tecla para finalizar... ");
            Console.ReadKey();
        }

        static bool EsBisiesto(uint numero)
        {
            return numero % 4 == 0 && (numero % 100 != 0 || numero % 400 == 0);
        }

        static uint IngresarNumeroNatural(string mensaje)
        {
            uint numeroNatural;
            string inputUsuario;
            bool valorInvalido = true;

            do
            {
                Console.Write(mensaje);
                inputUsuario = Console.ReadLine();

                if (uint.TryParse(inputUsuario, out numeroNatural))
                {
                    valorInvalido = false;
                }
                else
                {
                    Console.WriteLine("ERROR. Valor Invalido\n");
                }

            } while (valorInvalido);

            return numeroNatural;
        }
    }
}
