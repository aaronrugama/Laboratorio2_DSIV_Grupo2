using System;
using System.Windows.Forms;

namespace Laboratorio2_DSV_Grupo2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConjeturaUlam objUlam = new ConjeturaUlam();
            objUlam.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmInvertirNum objInvertiNum = new FrmInvertirNum();
            objInvertiNum.Show();
        }

        private void btnProblema6_Click(object sender, EventArgs e)
        {
            Votos objVotos = new Votos();
            objVotos.Show();
        }
    }
}
