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
    public partial class Frm4 : Form
    {
        public Frm4()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int numero;
            if (!int.TryParse(txtNumero.Text.Trim(), out numero) || numero <= 0)
            {
                MessageBox.Show("Ingrese un número entero positivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear objeto de la clase
            NumeroPerfectoClass np = new NumeroPerfectoClass();
            np.Numero = numero;

            // Mostrar en ListBox
            lstDivisores.Items.Clear();
            lstDivisores.Items.Add(np.MostrarInformacion());
        }
    }
}
