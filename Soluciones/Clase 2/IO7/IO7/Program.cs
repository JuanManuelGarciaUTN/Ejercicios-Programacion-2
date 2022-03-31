using System;

namespace IO7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double longitudBase = 0;
            double longitudAltura = 0;
            double hipotenusa;

            do
            {
                Console.Write("Ingrese la longitud de la base del triangulo: ");
                longitudBase = double.Parse(Console.ReadLine());

            }   while (longitudBase <= 0);

            do
            {
                Console.Write("Ingrese la longitud de la altura del triangulo: ");
                longitudAltura = double.Parse(Console.ReadLine());

            } while (longitudBase <= 0);

            hipotenusa = Math.Pow(longitudBase,2) + Math.Pow(longitudAltura,2);
            hipotenusa = Math.Sqrt(hipotenusa);

            Console.WriteLine($"La hipotenusa del triangulo es {hipotenusa}");

            Console.Write("Presione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
