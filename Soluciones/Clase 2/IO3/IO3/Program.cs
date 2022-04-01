using System;
using System.Text;

namespace IO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Conversor.ConvertirBinarioADecimal(-1111001));
            Console.WriteLine(Conversor.ConvertirDecimalABinario(-121));
            Console.ReadKey();
        }
    }

    public static class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string numeroBinario;
            bool agregarSimboloMenos;

            agregarSimboloMenos = numeroEntero < 0;
            do
            {
                if(numeroEntero % 2 == 0)
                {
                    stringBuilder.Append('0');
                }
                else
                {
                    stringBuilder.Append('1');
                }

                numeroEntero = numeroEntero / 2;

            } while (numeroEntero != 0);

            if (agregarSimboloMenos)
            {
                stringBuilder.Append('-');
            }

            numeroBinario = InvertirString(stringBuilder.ToString());

            return numeroBinario;
        }

        public static string InvertirString(string texto)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int cantidadDeSwapeos;
            char caracterAuxiliar;
            int longitudString;

            stringBuilder.Append(texto);

            longitudString = stringBuilder.Length;

            cantidadDeSwapeos = longitudString / 2;

            for (int i = 0; i < cantidadDeSwapeos; i++)
            {
                caracterAuxiliar = stringBuilder[i];
                stringBuilder[i] = stringBuilder[longitudString - i-1];
                stringBuilder[longitudString - i-1] = caracterAuxiliar;
            }

            return stringBuilder.ToString();
        }

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            string numeroBinario;
            int numeroDecimal = 0;
            int longitudString;
            bool esNegativo;

            esNegativo = numeroEntero < 0;
            
            if(esNegativo)
            {
                numeroEntero *= -1;
            }

            numeroBinario = numeroEntero.ToString();
            longitudString = numeroBinario.Length;

            for (int i = 0; i < longitudString; i++)
            {
                if(numeroBinario[i]=='1')
                {
                    numeroDecimal += (int)Math.Pow(2, longitudString-i-1);
                }
            }
            if(esNegativo)
            {
                numeroDecimal *= -1;
            }

            return numeroDecimal;
        }
    }
}
