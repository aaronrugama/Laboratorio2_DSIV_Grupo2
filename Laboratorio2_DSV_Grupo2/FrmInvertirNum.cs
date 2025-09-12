using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio2_DSV_Grupo2
{
    public partial class FrmInvertirNum : Form
    {
        public FrmInvertirNum()
        {
            InitializeComponent();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            int n = 0;
            string num = txtNum.Text;
            if (Validaciones.EsNumeroEntero(num))
            {
                
                int resultado = Invertir(int.Parse(num), n);
                txtResultado.Text = $"El numero invertido es: {resultado}";
            }
            
        }

        static int Invertir(int n, int resultado)
        {
            if (n == 0)
            {
                return resultado;
            }

            int digito = n % 10;
            resultado = resultado * 10 + digito;

            return Invertir(n / 10, resultado);
        }
    }
}
