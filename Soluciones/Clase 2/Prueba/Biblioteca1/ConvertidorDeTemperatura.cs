using System;

namespace Biblioteca1
{
    public static class ConvertidorDeTemperatura
    {
        private const float ceroAbsoluto = 273.15f;
        public static float ConvertirTemperaturaDeCelciusAKelvin(float temperaturaCelcius)
        {
            return temperaturaCelcius + ceroAbsoluto;
        }

        public static float ConvertirTemperaturaDeKelvinACelcius(float temperaturaKelvin)
        {
            return temperaturaKelvin - ceroAbsoluto;
        }
    }
}
