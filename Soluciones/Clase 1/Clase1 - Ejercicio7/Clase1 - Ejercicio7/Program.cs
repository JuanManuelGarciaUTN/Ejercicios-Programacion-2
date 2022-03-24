using System;

namespace Clase1___Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadEmpleados;
            string reciboFinal;

            IngresarPorConsola("Ingrese la cantiad de empleados: ", out cantidadEmpleados);

            reciboFinal = string.Format("{0,-25} {1,10} {2,10} {3,12} {4,11}\n", "Nombre", "Antiguedad", "Valor Hora", "Sueldo Bruto", "Sueldo Neto");

            for (int i = 0; i < cantidadEmpleados; i++)
            {
                Console.WriteLine("\nEmpleado {0}: ", i+1);
                reciboFinal += AgregarEmpleadoAlRecibo();
            }

            Console.WriteLine("\n\nEl recibo final es: \n{0}", reciboFinal);

            Console.Write("\nPresione cualquier tecla para finalizar...");
            Console.ReadKey();

        }

        static string AgregarEmpleadoAlRecibo()
        {
            string entradaRecibo;
            string nombre;
            int antiguedad;
            double valorHora;
            int cantidadHoras;

            IngresarPorConsola("Ingrese el nombre del empleado: ", out nombre);
            IngresarPorConsola("Ingrese la antigüedad del empleado: ", out antiguedad);
            IngresarPorConsola("Ingrese el valor de la hora de trabajo del empleado: ", out valorHora);
            IngresarPorConsola("Ingrese la cantidad de horas trabajadas del empleado: ", out cantidadHoras);

            entradaRecibo = FormatearReciboEmpleado(nombre, antiguedad, valorHora, cantidadHoras, 13);

            return entradaRecibo;
        }
        static string FormatearReciboEmpleado(string nombre, int antiguedad, double valorHora, int cantidadHoras, int descuento)
        {
            string entradaRecibo = "";
            double sueldoBruto;
            double sueldoNeto;

            sueldoBruto = valorHora * cantidadHoras + antiguedad * 150;
            sueldoNeto = sueldoBruto - sueldoBruto * descuento / 100;

            entradaRecibo = string.Format("{0,-25} {1,10} {2,10:N2} {3,12:N2} {4,11:N2}\n", nombre, antiguedad, valorHora, sueldoBruto, sueldoNeto);

            return entradaRecibo;
        }
        static int IngresarPorConsola(string mensaje, out double numero)
        {
            string inputUsuario;
            bool valorInvalido = true;
            int intentosRestantes = 5;

            do
            {
                Console.Write(mensaje);
                inputUsuario = Console.ReadLine();

                if(double.TryParse(inputUsuario, out numero))
                {
                    return 1;
                }

                intentosRestantes--;
                Console.WriteLine("ERROR. Valor invalido. Intentos restantes {0}", intentosRestantes);

            } while (valorInvalido && intentosRestantes > 0);

            return 0;
        }

        static int IngresarPorConsola(string mensaje, out int numero)
        {
            string inputUsuario;
            bool valorInvalido = true;
            int intentosRestantes = 5;

            do
            {
                Console.Write(mensaje);
                inputUsuario = Console.ReadLine();

                if (int.TryParse(inputUsuario, out numero))
                {
                    return 1;
                }

                intentosRestantes--;
                Console.WriteLine("ERROR. Valor invalido. Intentos restantes {0}", intentosRestantes);

            } while (valorInvalido && intentosRestantes > 0);

            return 0;
        }

        static void IngresarPorConsola(string mensaje, out string texto)
        {
            Console.Write(mensaje);
            texto = Console.ReadLine();
        }
    }
}
