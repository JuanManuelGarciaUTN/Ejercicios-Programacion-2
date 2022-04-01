using System;

namespace IO8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dia;

            Console.WriteLine($"Determinar cuantos dias pasaron desde una fechas hasta hoy:{Environment.NewLine}");
            Console.WriteLine(DeterminarCuantosDiasPasaronHastaHoy(dia));
            Console.ReadKey();
        }

        public static DateTime IngresarFecha()
        {

        }

        public static int IngresarEnteroPositivo(string mensaje)
        {
            string input;
            int numero;
            bool valorInvalido = true;

            do
            {
                Console.WriteLine(mensaje);
                input = Console.ReadLine().Trim();

                if(int.TryParse(input, out numero) == true)
                {

                }
            } while (valorInvalido);

        }
        public static int DeterminarCuantosDiasPasaronHastaHoy(DateTime fecha)
        {
            return DetermianarCuantosDiasPasaron(fecha, DateTime.Now);
        }

        private static int DetermianarCuantosDiasPasaron(DateTime desdeFecha, DateTime hastaFecha)
        {
            int aniosEntreAmbasFechas;
            int totalDeDiasEntreFechas = 0;

            if (desdeFecha.Year == hastaFecha.Year)
            {
                totalDeDiasEntreFechas = hastaFecha.DayOfYear - desdeFecha.DayOfYear;
            }
            else
            {
                totalDeDiasEntreFechas += hastaFecha.DayOfYear;
                totalDeDiasEntreFechas += DeterminarCuantosDiasQuedanDelAnio(desdeFecha);

                aniosEntreAmbasFechas = hastaFecha.Year - desdeFecha.Year - 1;

                for (int i = 1; i <= aniosEntreAmbasFechas; i++)
                {
                    totalDeDiasEntreFechas += 365;
                    if(DateTime.IsLeapYear(desdeFecha.Year + i))
                    {
                        totalDeDiasEntreFechas++;
                    }
                }
            }

            return totalDeDiasEntreFechas;
        }

        private static int DeterminarCuantosDiasQuedanDelAnio(DateTime fecha)
        {
            int diasQueQuedan = 365 - fecha.DayOfYear;

            if (DateTime.IsLeapYear(fecha.Year))
            {
                diasQueQuedan += 1;
            }

            return diasQueQuedan;
        }
    }
}
