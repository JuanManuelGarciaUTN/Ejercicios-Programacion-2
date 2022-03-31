using System;
using System.Text;

namespace IO5
{
    internal class Program
    {
        private static int numero;

        static void Main(string[] args)
        {
            string tablaDeMultiplicar;

            IngresarNumeroEntero("Ingrese el numero que desea calcular la tabla de multiplicar: ");
            tablaDeMultiplicar = GenerarTablaDeMultiplicar();
            Console.WriteLine(tablaDeMultiplicar);
            PresionarTeclaParaFinalizar();
        }

        public static string GenerarTablaDeMultiplicar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            int producto;

            for (int i = 1; i < 10; i++)
            {
                producto = i * numero;
                stringBuilder.AppendLine($"{numero} x {i} = {producto}");
            }

            return stringBuilder.ToString();
        }

        private static void IngresarNumeroEntero(string mensaje)
        {
            bool valorInvalido = true;
            string inputUsuario;

            do
            {
                Console.Write(mensaje);
                inputUsuario = Console.ReadLine();

                if(int.TryParse(inputUsuario, out numero) == true)
                {
                    valorInvalido = false;
                }
                else
                {
                    Console.WriteLine($"ERROR. No ingreso un entero. {Environment.NewLine}");
                }

            } while (valorInvalido);
        }

        public static void PresionarTeclaParaFinalizar()
        {
            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
