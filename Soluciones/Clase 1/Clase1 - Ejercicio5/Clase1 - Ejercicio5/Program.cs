using System;

namespace Clase1___Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputUsuario;
            int numeroIngresado;
            bool valorInvalido = true;
            bool ningunCentroNumerico = true;

            do
            {
                Console.Write("Ingrese un numero entero positivo o salir: ");
                inputUsuario = Console.ReadLine();

                if(int.TryParse(inputUsuario, out numeroIngresado) == false)
                {
                    inputUsuario = inputUsuario.ToLower();

                    if(inputUsuario == "salir")
                    {
                        Environment.Exit(0);
                    }
                    Console.WriteLine("ERROR. Valor Invalido\n");
                }
                else
                {
                    valorInvalido = false;
                }

            } while(valorInvalido);

            Console.WriteLine("\nLa Lista de Centros Numericos hasta {0} es: \n", numeroIngresado);

            for (int i = 1; i < numeroIngresado; i++)
            {
                if(EsCentroNumerico(i))
                {
                    Console.WriteLine(i);
                    ningunCentroNumerico = false;
                }
            }

            if(ningunCentroNumerico)
            {
                Console.WriteLine("Ninguno");
            }

            Console.Write("\nPresiene una tecla para finalizar...");
            Console.ReadKey();
        }


        static int ObtenerSecuenciaTriangular(int numero)
        {
            if(numero > 0)
            {
                return numero*(numero+1)/2;
            }
            else
            {
                return 0;
            }    
        }

        static bool EsCentroNumerico(int numero)
        {
            int sumatoriaMenor = ObtenerSecuenciaTriangular(numero - 1);
            int sumatoriaMayor = 0;

            if (numero > 0)
            {
                while(sumatoriaMayor < sumatoriaMenor)
                {
                    numero++;
                    sumatoriaMayor += numero;

                    if(sumatoriaMayor == sumatoriaMenor)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
