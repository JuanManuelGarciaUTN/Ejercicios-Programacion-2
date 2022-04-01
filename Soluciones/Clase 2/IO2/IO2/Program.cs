using System;

namespace IO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar;
            double numeroUno;
            double numeroDos;
            double resultado;

            do
            {
                numeroUno = IngresarNumero("Ingrese el primer numero a sumar: ");
                numeroDos = IngresarNumero("Ingrese el segundo numero a sumar: ");

                resultado = Sumar(numeroUno, numeroDos);
                Console.WriteLine($"{numeroUno} + {numeroDos} = {resultado}");

                continuar = IngresarContinuar("¿Desea continuar? (S/N): ");
                Console.WriteLine();
            } while (continuar);
        }
        public static double Sumar(double numeroUno, double numeroDos)
        {
            return numeroUno + numeroDos;
        }

        public static bool IngresarContinuar(string mensaje)
        {
            string inputUsuario;

            Console.Write(mensaje);
            inputUsuario = Console.ReadLine().ToUpper().Trim();

            return Validador.ValidarRespuesta(inputUsuario);
        }

        public static double IngresarNumero(string mensaje)
        {
            bool valorInvalido = true;
            string inputUsuario;
            double numero;
            do
            {
                Console.Write(mensaje);
                inputUsuario=Console.ReadLine().Trim();

                if(double.TryParse(inputUsuario, out numero) == true)
                {
                    valorInvalido = false;
                }
                else
                {
                    Console.WriteLine($"ERROR. Valor Invalido{Environment.NewLine}");
                }

            } while (valorInvalido);

            return numero;
        }
    }

    public static class Validador
    {
        public static bool ValidarRespuesta(string input)
        {
            return input == "S";
        }
    }
}
