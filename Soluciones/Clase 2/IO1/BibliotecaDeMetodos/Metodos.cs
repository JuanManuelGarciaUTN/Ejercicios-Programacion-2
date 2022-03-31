using System;

namespace BibliotecaDeMetodos
{
    public static class Validador
    {
        /// <summary>
        /// Valida si el valor se encuantra dentro del rango expresado
        /// </summary>
        /// <param name="valor">Valor a comprobar</param>
        /// <param name="min">Minimo valor correcto</param>
        /// <param name="max">Maximo valor correcto</param>
        /// <returns>true si el valor se encuentra en el rango, si no false</returns>
        public static bool Validar(int valor, int min, int max)
        {
            return valor >= min && valor <= max;
        }
    }
}
