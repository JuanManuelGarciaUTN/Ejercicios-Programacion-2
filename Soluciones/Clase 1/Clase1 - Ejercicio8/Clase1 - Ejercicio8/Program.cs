using System;

namespace Clase1___Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            string inputUsuario;
            bool valorInvalido = true;

            do
            {
                Console.Write("Ingrese la altura del triangulo a mostrar: ");
                inputUsuario = Console.ReadLine();

                if (int.TryParse(inputUsuario, out cantidad) && cantidad > 0)
                {
                    valorInvalido = false;
                }
                else
                {
                    Console.WriteLine("ERROR. Valor Invalido\n"); 
                }

            } while(valorInvalido);

            ImprimirTrianguloEscalenoCaracteres(cantidad, '*');

            Console.Write("\nPresione una tecla para finalizar...");
            Console.ReadKey();
        }

        static void ImprimirTrianguloEscalenoCaracteres(int cantidad, char caracter)
        {
            string lineaTexto = "";
            lineaTexto += caracter;

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(lineaTexto);

                for (int j = 0; j < 2; j++)
                {
                    lineaTexto += caracter;
                }  
            }
        }
    }
}
