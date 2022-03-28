using System;

namespace Clase1___Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad;

            cantidad = IngresarEnteroPositivo("Ingrese la altura del triangulo a mostrar: ");

            ImprimirTrianguloEquilateroCaracteres(cantidad, '#');

            PresioneParaFinalizar();
        }

        static void ImprimirTrianguloEquilateroCaracteres(int cantidad, char caracter)
        {
            string lineaTexto = "";
            lineaTexto += caracter;

            for (int i = 0; i < cantidad; i++)
            {
                string separacion = "";
                int espacios = cantidad + 3 - i;

                for (int j = 0; j < espacios; j++)
                {
                    separacion += ' ';
                }

                Console.Write(separacion);
                Console.WriteLine(lineaTexto);

                for (int j = 0; j < 2; j++)
                {
                    lineaTexto += caracter;
                }
            }
        }

        static int IngresarEnteroPositivo(string mensaje)
        {
            int entero;
            string inputUsuario;
            bool valorInvalido = true;

            do
            {
                Console.Write(mensaje);
                inputUsuario = Console.ReadLine();

                if (int.TryParse(inputUsuario, out entero) && entero > 0)
                {
                    valorInvalido = false;
                }
                else
                {
                    Console.WriteLine("ERROR. Valor Invalido\n");
                }

            } while (valorInvalido);

            return entero;
        }

        static void PresioneParaFinalizar()
        {
            Console.Write("\nPresione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
