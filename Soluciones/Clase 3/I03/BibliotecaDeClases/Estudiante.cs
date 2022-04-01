using System;
using System.Text;

namespace BibliotecaDeClases
{
    public class Estudiante
    {
        //atributos
        private string apellido;
        private string nombre;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        //constructores
        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        //metodos publicos
        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }
        public double CalcularNotaFinal()
        {
            double notaFinal = -1;

            if (CalcularPromedio() >= 4)
            {
                notaFinal = random.Next(4, 11);
            }

            return notaFinal;
        }
        public string Mostrar()
        {
            StringBuilder informacionEstudiante = new StringBuilder();
            double notaFinal = CalcularNotaFinal();

            informacionEstudiante.AppendLine($"Nombre: {this.nombre}{Environment.NewLine}" +
                                             $"Apellido: {this.apellido}{Environment.NewLine}" +
                                             $"Legajo: {this.legajo}{Environment.NewLine}" +
                                             $"Nota Primer Parcial: {this.notaPrimerParcial}{Environment.NewLine}" +
                                             $"Nota Segundo Parcial: {this.notaSegundoParcial}{Environment.NewLine}" +
                                             $"Promedio: {CalcularPromedio()}");

            informacionEstudiante.Append("Nota Final: ");

            if (notaFinal == -1)
            {
                informacionEstudiante.AppendLine("Alumno desaprobado");
            }
            else
            {
                informacionEstudiante.AppendLine($"{notaFinal}");
            }

            return informacionEstudiante.ToString();
        }

        //metodos privados
        private float CalcularPromedio()
        {
            float promedio;
            promedio = (this.notaPrimerParcial + this.notaSegundoParcial) / 2f;

            return promedio;
        }
    }
}
