using System;

namespace A01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int numero = 8;
            int factorialDeCinco = CalcularFactorial(numero);
            Console.WriteLine("El factorial de {0} es {1}", numero, factorialDeCinco);

            Console.Write("Presione una tecla para finalizar...");
            Console.ReadKey();
        }

        static int CalcularFactorial(int numero)
        {
            int factorial = 1;
            numero++;

            for (int i = 2; i < numero; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
