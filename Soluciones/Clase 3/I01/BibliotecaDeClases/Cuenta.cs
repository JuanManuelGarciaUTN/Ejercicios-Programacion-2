using System;
using System.Text;

namespace BibliotecaDeClases
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public decimal GetCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            StringBuilder informacionEmpresa = new StringBuilder();
            informacionEmpresa.Append($"Titular: {GetTitular()}{Environment.NewLine}" +
                                      $"Dinero Actual: {GetCantidad()}");

            return informacionEmpresa.ToString();
        }

        public void Ingresar(decimal montoAIngresar)
        {
            if(montoAIngresar > 0)
            {
                cantidad += montoAIngresar;
            }
        }

        public void Retirar(decimal montoARetirar)
        {
            if (montoARetirar > 0)
            {
                cantidad -= montoARetirar;
            }
        }
    }
}
