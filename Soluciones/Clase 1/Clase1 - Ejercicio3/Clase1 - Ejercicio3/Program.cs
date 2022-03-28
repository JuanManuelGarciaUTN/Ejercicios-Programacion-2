using System;

namespace Clase1___Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputUsuario;
            int numeroIngresado;
            bool valorInvalido = true;

            do
            {
                do
                {
                    Console.Write("Ingrese un numero o \"salir\": ");
                    inputUsuario = Console.ReadLine();

                    if (int.TryParse(inputUsuario, out numeroIngresado) == false)
                    {
                        inputUsuario = inputUsuario.ToLower().Trim();

                        if (inputUsuario == "salir")
                        {
                            Environment.Exit(0);
                        }

                        Console.WriteLine("ERROR. Valor invalido \n");
                    }
                    else
                    {
                        valorInvalido = false;
                    }

                } while (valorInvalido);

                Console.WriteLine("Los numeros primos hasta {0} son:", numeroIngresado);

                for (int i = 1; i < numeroIngresado; i++)
                {
                    if (EsPrimo(i))
                    {
                        Console.WriteLine(i);
                    }
                }

                Console.Write("\nSi desea calcular una nueva lista de primos ingrese \"si\": ");
                inputUsuario = Console.ReadLine();
                inputUsuario = inputUsuario.ToLower().Trim();

            } while (inputUsuario == "si");
        }

        static bool EsPrimo(int numero)
        {
            bool esPrimo = true;
            int verificacionMaxima = numero / 2;

            for (int i = 2; i < verificacionMaxima; i++)
            {
                if(numero%i == 0)
                {
                    esPrimo = false; 
                    break;
                }
            }

            return esPrimo;
        }
    }
}
