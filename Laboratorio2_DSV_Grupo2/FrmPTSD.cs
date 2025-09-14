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
    public partial class FrmPTSD : Form
    {
        public FrmPTSD()
        {
            InitializeComponent();
        }

        ListaDatos objMontos = new ListaDatos();


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (double.TryParse(txtMonto.Text, out double monto))
            {
                objMontos.agregarDato(monto);
                txtMonto.Text = "";
                MessageBox.Show("Ya se agregó");

            }
            else
            {
                MessageBox.Show("Por favor ingrese un monto válido");
                txtMonto.Focus();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtMenoresQuinientos.Visible = true;
            txtMenoresMil.Visible = true;
            txtMayoresMil.Visible = true;
            lblMayMi.Visible = true;
            lblMenMi.Visible = true;
            lblMenQ.Visible = true;
            txtMayoresMil.Text = objMontos.CategorizarMontos().mayMil.ToString();
            txtMenoresMil.Text = objMontos.CategorizarMontos().menMil.ToString();
            txtMenoresQuinientos.Text = objMontos.CategorizarMontos().menQuin.ToString();
        }
    }
}