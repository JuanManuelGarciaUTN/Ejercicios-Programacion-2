using System;

namespace BibliotecaDeMetodos
{
    public static class Calculadora
    {
        /// <summary>
        /// Calcula la operacion matematica correspondiente de los numeros ingresado
        /// </summary>
        /// <param name="primerOperando">primer numero a operar</param>
        /// <param name="segundoOperando">segundo numero a operar</param>
        /// <param name="operador">tipo de operacion a realizar</param>
        /// <returns>retorna el resultado de la operacion</returns>
        public static float Calcular(float primerOperando, float segundoOperando, char operador)
        {
            float resultado = 0;
            switch (operador)
            {
                case '+':
                    resultado = primerOperando + segundoOperando;
                    break;

                case '-':
                    resultado = primerOperando + segundoOperando;
                    break;

                case '/':
                    if(Validar(segundoOperando))
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    break;

                case '*':
                    resultado = primerOperando + segundoOperando;
                    break;

                default:
                    break;
            }

            return resultado;
        }

        /// <summary>
        /// Valida que el numero no sea 0
        /// </summary>
        /// <param name="numero">numero a validar</param>
        /// <returns>true si el numero no es 0, si no false</returns>
        private static bool Validar(float numero)
        {
            return numero != 0;
        }
    }
}
