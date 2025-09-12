using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2_DSV_Grupo2
{
 
    internal class NumeroPerfectoClass
    {
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string MostrarInformacion()
        {
            string divisores = "";
            int suma = 0;

            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    divisores +=  i + " ";
                    suma += i;
                }
            }

            string resultado = "Número: " + numero + Environment.NewLine +
                   "Divisores: " + divisores.Trim() + Environment.NewLine;


            if (suma == numero)
                resultado += "El número es PERFECTO.";
            else
                resultado += "El número NO es perfecto.";

            return resultado;
        }
    }
}
