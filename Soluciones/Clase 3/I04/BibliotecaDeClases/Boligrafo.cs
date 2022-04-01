using System;
using System.Text;

namespace BibliotecaDeClases
{
    public class Boligrafo
    {
        //atributos
        public const short cantidadMaximaDeTinta = 100;
        private ConsoleColor color;
        private short tinta;

        //constructores
        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        //metodos publicos
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        public void Recargar()
        {
            SetTinta(cantidadMaximaDeTinta);
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            StringBuilder resultadoDibujo;
            bool seDibujo;
            short tintaAUsar;

            tintaAUsar = GetTinta();
            resultadoDibujo = new StringBuilder();

            if(tintaAUsar > gasto)
            {
                tintaAUsar = (short)(gasto * -1);
            }

            for (int i = 0; i < tintaAUsar; i++)
            {
                resultadoDibujo.Append('*');
            }

            seDibujo = tintaAUsar > 0;
            SetTinta(tintaAUsar);

            dibujo = resultadoDibujo.ToString();

            return seDibujo;
        }


        //metodos privados
        private void SetTinta(short tinta)
        {
            short tintaFinal;

            tintaFinal = (short)(this.tinta + tinta);

            if(tintaFinal >= 0 && tintaFinal <= cantidadMaximaDeTinta)
            {
                this.tinta = tintaFinal;
            }
        }
    }
}
