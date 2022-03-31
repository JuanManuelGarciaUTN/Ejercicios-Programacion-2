using BibliotecaDeMetodos;
using System;

namespace IO4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float primerNumero;
            float segundoNumero;
            char operador;
            float resultado;
            bool continuarOperando;

            do
            {
                primerNumero = IngresarNumero("Ingrese el primer numero: ");
                segundoNumero = IngresarNumero("Ingrese el segundo numero: ");
                operador = IngresarOperador("Ingrese la operacion que desea realizar (+ - / *): ");

                resultado = Calculadora.Calcular(primerNumero, segundoNumero, operador);
                Console.WriteLine($"El resultado de {primerNumero} {operador} {segundoNumero} es: {resultado}");

                continuarOperando = IngresarConfirmacion("\nSi desea calcular otra operacio ingrese \"si\": ");

            } while (continuarOperando);
        }

        static char IngresarOperador(string mensaje)
        {
            char operador;
            string inputUsuario;
            bool valorInvalido = true;

            do
            {
                Console.Write(mensaje);
                inputUsuario = Console.ReadLine().Trim();

                if (inputUsuario == "-" || inputUsuario == "+" || inputUsuario == "/" || inputUsuario == "*")
                {
                    valorInvalido = false;
                }
                else
                {
                    Console.WriteLine("ERROR. No ingreso un operando\n");
                }

            } while (valorInvalido);

            operador = inputUsuario[0];

            return operador;
        }
        static float IngresarNumero(string mensaje)
        {
            string inputUsuario;
            float numeroIngresado;
            bool valorInvalido = true;
            do
            {
                Console.Write(mensaje);
                inputUsuario = Console.ReadLine();

                if (float.TryParse(inputUsuario, out numeroIngresado))
                {
                    valorInvalido = false;
                }
                else
                {
                    Console.WriteLine("ERROR. Debe Ingresar un numero\n");
                }
            } while (valorInvalido);

            return numeroIngresado;
        }
        static bool IngresarConfirmacion(string mensaje)
        {
            string inputUsuario;

            Console.Write(mensaje);
            inputUsuario = Console.ReadLine().Trim().ToLower();

            return inputUsuario == "si";
        }
    }
}
