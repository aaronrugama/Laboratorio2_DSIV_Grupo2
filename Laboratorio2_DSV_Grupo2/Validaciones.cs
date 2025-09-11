using System;
using System.Windows.Forms;

    public static class Validaciones
    {
        public static bool EsNumeroEntero(string num)
        {
            if (int.TryParse(num, out int valor) && valor > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show(
                    "Por favor, ingrese un número entero válido y mayor a 0.", 
                    "Entrada inválida", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return false;
            }
            
            
        }

        public static bool EsNumeroDecimal(string input)
        {
            if(double.TryParse(input, out _))
            {
                return true;
            }
            else
            {
                MessageBox.Show(
                    "Por favor, ingrese un número decimal válido.", 
                    "Entrada inválida", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return false;
            }
        }
    }
