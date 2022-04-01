using BibliotecaDeClases;
using System;

namespace I03
{
    internal class Consola
    {
        static void Main(string[] args)
        {
            int notaIngresada;

            Estudiante estudianteUno = new Estudiante("Juan Manuel", "Garcia", "102368");
            Estudiante estudianteDos = new Estudiante("Pedro", "Cruz", "120456");
            Estudiante estudianteTres = new Estudiante("Priscila", "Proudmoore", "101867");

            notaIngresada = IngresarNumeroPositivoConRango($"Ingrese la nota del primer parcial Juan: ", 1, 10);
            estudianteUno.SetNotaPrimerParcial(notaIngresada);

            notaIngresada = IngresarNumeroPositivoConRango($"Ingrese la nota del primer parcial Pedro: ", 1, 10);
            estudianteDos.SetNotaPrimerParcial(notaIngresada);

            notaIngresada = IngresarNumeroPositivoConRango($"Ingrese la nota del primer parcial¨Priscila: ", 1, 10);
            estudianteTres.SetNotaPrimerParcial(notaIngresada);

            notaIngresada = IngresarNumeroPositivoConRango($"Ingrese la nota del segundo parcial Juan: ", 1, 10);
            estudianteUno.SetNotaSegundoParcial(notaIngresada);

            notaIngresada = IngresarNumeroPositivoConRango($"Ingrese la nota del segundo parcial Pedro: ", 1, 10);
            estudianteDos.SetNotaSegundoParcial(notaIngresada);

            notaIngresada = IngresarNumeroPositivoConRango($"Ingrese la nota del segundo parcial¨Priscila: ", 1, 10);
            estudianteTres.SetNotaSegundoParcial(notaIngresada);

            Console.WriteLine();
            Console.WriteLine(estudianteUno.Mostrar());
            Console.WriteLine(estudianteDos.Mostrar());
            Console.WriteLine(estudianteTres.Mostrar());

            Console.WriteLine("Presione cualquie tecla para finalizar...");
            Console.ReadKey();
        }
        private static int IngresarNumeroPositivoConRango(string mensaje, int minimo, int maximo)
        {
            string input;
            int numero;
            bool valorInvalido = true;

            do
            {
                Console.Write(mensaje);
                input = Console.ReadLine();

                if (int.TryParse(input, out numero) == true && numero >= minimo && numero <= maximo)
                {
                    valorInvalido = false;
                }
                else
                {
                    Console.WriteLine("ERROR. Valor Fuera de Rango");
                }

            } while (valorInvalido);

            return numero;
        }
    }



}
