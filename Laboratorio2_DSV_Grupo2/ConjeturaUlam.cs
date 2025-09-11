using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio2_DSV_Grupo2
{
    public partial class ConjeturaUlam : Form
    {
        public ConjeturaUlam()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            String num = txtNumero.Text;

            if (Validaciones.EsNumeroEntero(num))
            {
                conjeturaUlam(int.Parse(num));
            }
        }

        private void conjeturaUlam (int numero)
        {
            listResultados.Items.Clear();
            while (numero != 1)
            {
                if (numero % 2 == 0)
                {
                    numero /= 2;
                }
                else
                {
                    numero = 3 * numero + 1;
                }
                listResultados.Items.Add($"{numero}");
            }
        }
    }
}
