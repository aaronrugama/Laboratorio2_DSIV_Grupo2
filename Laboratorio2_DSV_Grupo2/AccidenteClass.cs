using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2_DSV_Grupo2
{
    internal class AccidenteClass
    {
        private int genero; // 1 mujer, 2 hombre
        private int edad;

        public int Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        // Método para mostrar la información
        public string MostrarAccidente()
        {
            string descripcionGenero;

            if (genero == 1)
            {
                descripcionGenero = "Mujer";
            }
            else if (genero == 2)
            {
                descripcionGenero = "Hombre";
            }
            else
            {
                descripcionGenero = "Género inválido";
            }

            return "Género: " + descripcionGenero + ", Edad: " + edad + " años";
        }

        // Método para validar si es mujer entre 18 y 25 años
        public bool MujerJoven()
        {
            if (genero == 1 && edad >= 18 && edad <= 25)
                return true;
            else
                return false;
        }

        // Método para validar si es hombre mayor de 40 años
        public bool HombreMayores()
        {
            if (genero == 2 && edad > 40)
                return true;
            else
                return false;
        }
    }
}
