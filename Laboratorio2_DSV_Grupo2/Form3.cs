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
    public partial class Fmr3 : Form
    {
        // Lista para guardar los accidentes
        List<AccidenteClass> lista = new List<AccidenteClass>();

        public Fmr3()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            int genero;
            if (!int.TryParse(txtGenero.Text.Trim(), out genero))
            {
                MessageBox.Show("Ingrese un número válido para el género.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int edad = 0;
            if (genero != 0) 
            {
                if (!int.TryParse(txtEdad.Text.Trim(), out edad))
                {
                    MessageBox.Show("Ingrese un número válido para la edad.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Se ingresa 0 para hacer las estadisticas
            if (genero == 0)
            {
                int cantMujeres = 0, cantHombres = 0, mujeres18y25 = 0, hombres40 = 0;

                foreach (var accidente in lista)
                {
                    if (accidente.Genero == 1)
                    {
                        cantMujeres++;
                        if (accidente.MujerJoven()) mujeres18y25++;
                    }
                    else if (accidente.Genero == 2)
                    {
                        cantHombres++;
                        if (accidente.HombreMayores()) hombres40++;
                    }
                }

                double porcMujeres = (cantMujeres > 0) ? mujeres18y25 * 100.0 / cantMujeres : 0;
                double porcHombres = (cantHombres > 0) ? hombres40 * 100.0 / cantHombres : 0;

                lstResultados.Items.Clear();
                lstResultados.Items.Add("Cantidad de Mujeres: " + cantMujeres);
                lstResultados.Items.Add("Cantidad de Hombres: " + cantHombres);
                lstResultados.Items.Add("Mujeres 18-25: " + porcMujeres.ToString("F2"));
                lstResultados.Items.Add("Hombres >40: " + porcHombres.ToString("F2"));


                MessageBox.Show("Se mostraron las estadísticas.");
            }
            else if (genero == 1 || genero == 2)
            {
                AccidenteClass accidente = new AccidenteClass();
                accidente.Genero = genero;
                accidente.Edad = edad;

                lista.Add(accidente);
                lstAccidentes.Items.Add(accidente.MostrarAccidente());

                txtGenero.Clear();
                txtEdad.Clear();
            }
            else
            {
                MessageBox.Show("Verifique sus datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

