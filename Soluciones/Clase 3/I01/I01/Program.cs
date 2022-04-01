using System;
using BibliotecaDeClases;

namespace I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal cantidadSueldos;
            decimal cantidadVentas;
            Cuenta cuentaDeLaEmpresa = new Cuenta("R&J", 21000);

            MostrarInformacionActualDeLaEmpresa(cuentaDeLaEmpresa);

            for (int i = 1; i <= 12; i++)
            {
                cantidadSueldos = IngresarNumero($"Ingrese el gasto en sueldos del mes {i}: ");
                cuentaDeLaEmpresa.Retirar(cantidadSueldos);

                MostrarInformacionActualDeLaEmpresa(cuentaDeLaEmpresa);

                cantidadVentas = IngresarNumero($"Ingrese el ingreso por ventas del mes {i}: ");
                cuentaDeLaEmpresa.Ingresar(cantidadVentas);

                MostrarInformacionActualDeLaEmpresa(cuentaDeLaEmpresa);
            }

            Console.Write("Presione cualquier tecla para finalizar...");
            Console.ReadLine();
        }

        static void MostrarInformacionActualDeLaEmpresa(Cuenta empresa)
        {
            Console.WriteLine($"La informacion actual de la cuenta es: {Environment.NewLine}" +
                              $"{empresa.Mostrar()}{Environment.NewLine}");
               
        }
        static decimal IngresarNumero(string mensaje)
        {
            string input;
            decimal numero;
            bool valorInvalido = true;

            do
            {
                Console.Write(mensaje);
                input = Console.ReadLine();

                if (decimal.TryParse(input, out numero) == true)
                {
                    valorInvalido = false;
                }
                else
                {
                    Console.WriteLine("ERROR. Valor Invalido!");
                }

            } while(valorInvalido);

            return numero;
        }
    }
}
