using System;

namespace Clase1___Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float numeroIngresado = 0;
            float potencia;
            bool valorInvalido = true;

            while (valorInvalido)
            {
                Console.Write("Ingrese un numero positivo a calcular potencia: ");
                numeroIngresado = float.Parse(Console.ReadLine());

                if(numeroIngresado > 0)
                {
                    valorInvalido = false;
                }
                else
                {
                    Console.WriteLine("\nERROR ¡Reingresar número!\n");
                }
            }

            potencia = (float)Math.Pow(numeroIngresado, 2);
            Console.WriteLine("{0} elevado al cuadrado es igual a: {1}", numeroIngresado, potencia);

            potencia = (float)Math.Pow(numeroIngresado, 3);
            Console.WriteLine("{0} elevado al cubo es igual a: {1}", numeroIngresado, potencia);

            Console.ReadKey();
        }
    }
}
