using System;

namespace Clase1___Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numeroIngresado;
            float numeroMaximo;
            float numeroMinimo;
            float promedio;

            const int cantidadNumeros = 5;

            promedio = 0;
            numeroMaximo = float.MinValue;
            numeroMinimo = float.MaxValue;

            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.Write("Ingrese un numero: ");
                numeroIngresado = float.Parse(Console.ReadLine());

                if(numeroIngresado < numeroMinimo )
                {
                    numeroMinimo = numeroIngresado;
                }
                if (numeroIngresado > numeroMaximo)
                {
                    numeroMaximo = numeroIngresado;
                }

                promedio += numeroIngresado;
            }

            promedio = promedio / cantidadNumeros;

            Console.WriteLine("\nEl numero maximo ingresado es: {0}", numeroMaximo);
            Console.WriteLine("El numero minimo ingresado es: {0}", numeroMinimo);
            Console.WriteLine("El promedio de los numeros ingresados es: {0}", promedio);

            Console.ReadKey();
        }
    }
}
