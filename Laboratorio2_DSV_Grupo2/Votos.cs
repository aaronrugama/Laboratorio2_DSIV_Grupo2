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
    public partial class Votos : Form
    {
        public Votos()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
                String[] aspirantes = new string[4];
                int[] votos = new int[4];
                int mayor = 0, menor = 0;

                aspirantes[0] = txtAsp1.Text;
                aspirantes[1] = txtAsp2.Text;
                aspirantes[2] = txtAsp3.Text;
                aspirantes[3] = txtAsp4.Text;

                if (!int.TryParse(txtVot1.Text, out votos[0]) ||
                    !int.TryParse(txtVot2.Text, out votos[1]) ||
                    !int.TryParse(txtVot3.Text, out votos[2]) ||
                    !int.TryParse(txtVot4.Text, out votos[3]))
                {
                    MessageBox.Show("Por favor ingrese valores numéricos válidos.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = 0; i < votos.Length; i++)
                {
                    for (int j = i + 1; j < votos.Length; j++)
                    {
                        if (votos[i] == votos[j])
                        {
                            MessageBox.Show("Valide los números ingresados. No puede haber empate entre aspirantes.",
                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                for (int i = 0; i < votos.Length; i++)
                {
                    if (votos[i] > votos[mayor])
                    {
                        mayor = i;
                    }
                    if (votos[i] < votos[menor])
                    {
                        menor = i;
                    }
                }

                txtResulMasVot.Text = $"El aspirante con mayor cantidad de votos es {aspirantes[mayor]} con {votos[mayor]} votos";
                txtResulMenVot.Text = $"El aspirante con menor cantidad de votos es {aspirantes[menor]} con {votos[menor]} votos";
            }
        }
}
