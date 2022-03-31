using System;
using BibliotecaDeMetodos;

namespace IO1
{
    internal class Consola
    {
        private static int numeroMaximoIngresado = int.MinValue;
        private static int numeroMinimoIngresado = int.MaxValue;
        static void Main(string[] args)
        {
            int numeroIngresado;
            int sumaTotalIngresada = 0;
            const int cantidadDeNumeros = 10;

            float promedio;

            bool valorInvalido;

            for (int i = 0; i < cantidadDeNumeros; i++)
            {
                valorInvalido = true;

                do
                {
                    numeroIngresado = IngresarNumeroEntero($"Ingrese {i + 1}° numero entero entre -100 y 100 inclusive: ");

                    if(Validador.Validar(numeroIngresado, -100, 100))
                    {
                        valorInvalido = false;
                    }
                    else
                    {
                        Console.WriteLine("ERROR. Valor Fuera de Rango\n");
                    }

                } while (valorInvalido);

                ObtenerMinimo(numeroIngresado);
                ObtenerMaximo(numeroIngresado);

                sumaTotalIngresada += numeroIngresado;
            }
            promedio = (float)sumaTotalIngresada / cantidadDeNumeros;

            Console.WriteLine($"\nEl maximo valor ingresado es: {numeroMaximoIngresado}\n" +
                              $"El minimo valor ingresado es: {numeroMinimoIngresado}\n" +
                              $"El promedio de los valores ingresados es: {promedio}");

            PresionarTeclaParaFinalizar();
        }

        private static void ObtenerMinimo(int numero)
        {
            numeroMinimoIngresado = Math.Min(numero, numeroMinimoIngresado);
        }
        private static void ObtenerMaximo(int numero)
        {
            numeroMaximoIngresado = Math.Max(numero, numeroMaximoIngresado);
        }
        static int IngresarNumeroEntero(string mensaje)
        {
            string inputUsuario;
            int numeroIngresado;
            bool valorInvalido = true;
            do
            {
                Console.Write(mensaje);
                inputUsuario = Console.ReadLine();

                if(int.TryParse(inputUsuario, out numeroIngresado))
                {
                    valorInvalido = false;
                }
                else
                {
                    Console.WriteLine("ERROR. Debe Ingresar un entero\n");
                }
            } while (valorInvalido);

            return numeroIngresado;
        }
        static void PresionarTeclaParaFinalizar()
        {
            Console.Write("\nPresione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
