using System;

namespace Clase1___Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int cantidadNumerosPerfectos = 4;

            Console.WriteLine("Los primeros 4 numeros perfectos son:");

            while(cantidadNumerosPerfectos > 0)
            {
                if( EsNumeroPerfecto(i))
                {
                    Console.WriteLine(i);
                    cantidadNumerosPerfectos--;
                }
                i++;
            }

            Console.Write("\nPresione una tecla para finalizar... ");
            Console.ReadKey();
        }

        static bool EsNumeroPerfecto(int numero)
        {
            int sumatoriaDivisores = 0;
            int numeroVerificarMaximo = numero / 2 + 1;

            if(numero == 1 || numero == 2)
            {
                return false;
            }

            for (int i = 1; i < numeroVerificarMaximo; i++)
            {
                if(numero % i == 0)
                {
                    sumatoriaDivisores += i;
                }
            }

            return numero == sumatoriaDivisores;
        }
    }
}
