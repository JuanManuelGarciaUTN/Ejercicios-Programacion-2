using System;

namespace IO6
{
    internal class Program
    {
        private static string formaACalcular;
        static void Main(string[] args)
        {
            double area = 0;

            Console.WriteLine($"Programa calculo de area de formas simples: {Environment.NewLine}");

            IngresarFormaGeometrica();
            CalcularArea();


            Console.WriteLine($"El area del {formaACalcular} es: {area}");

        }

        private static double CalcularArea()
        {
            double area = 0;
            double longitudBase;
            double altura;
            double radio;

            switch (formaACalcular)
            {
                case "circulo":
                    radio = IngresarDouble("Ingrese el radio del circulo: ");
                    area = CalculadoraDeArea.CalcularAreaCirculo(radio);
                    break;

                case "cuadrado":
                    longitudBase = IngresarDouble("Ingrese la longitud de los lados del cuadrado: ");
                    area = CalculadoraDeArea.CalcularAreaCuadrado(longitudBase);
                    break;

                case "triangulo":
                    longitudBase = IngresarDouble("Ingrese la base del triangulo: ");
                    altura = IngresarDouble("Ingrese la altura del triangulo: ");
                    area = CalculadoraDeArea.CalcularAreaTriangulo(longitudBase, altura);
                    break;
            }

            return area;
        }

        private static void IngresarFormaGeometrica()
        {
            string inputUsuario;
            bool valorInvalido = true;
            do
            {
                inputUsuario = IngresarString($"Ingrese la forma que desea calcular el area: {Environment.NewLine}" +
                    $"  -circulo{Environment.NewLine}" +
                    $"  -cuadrado{Environment.NewLine}" +
                    $"  -triangulo");

                inputUsuario.Trim().ToLower();

                if (inputUsuario == "circulo" || inputUsuario == "cuadrado" || inputUsuario == "triangulo")
                {
                    valorInvalido = false;
                    formaACalcular = inputUsuario;
                }
                else
                {
                    Console.WriteLine($"ERROR. Forma invalida. {Environment.NewLine}");
                }
            } while (valorInvalido);
        }
        private static string IngresarString(string mensaje)
        {
            Console.WriteLine(mensaje);
            return Console.ReadLine();
        }

        private static double IngresarDouble(string mensaje)
        {
            double numero;
            string inputUsuario;
            bool valorInvalido = true;

            do
            {
                Console.WriteLine(mensaje);
                inputUsuario = Console.ReadLine();

                if (double.TryParse(inputUsuario, out numero))
                {
                    valorInvalido = false;
                }
                else
                {
                    Console.WriteLine($"ERROR. No ingreso un numero {Environment.NewLine}");
                }
            } while (valorInvalido);
            
            return numero;
        }
    }

    public static class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            return longitudLado * longitudLado;
        }
        public static double CalcularAreaTriangulo(double longitudBase, double altura)
        {
            return longitudBase * altura / 2;
        }
        public static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * radio * radio;
        }
    }

    
}
