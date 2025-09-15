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

        private void btnSolucion1_Click(object sender, EventArgs e)
        {
            FrmPTSD objPTSD = new FrmPTSD();
            objPTSD.Show();
        }

        private void btnSolucion3_Click(object sender, EventArgs e)
        {
            Fmr3 objForm3 = new Fmr3();
            objForm3.Show();
        }

        private void btnSolucion4_Click(object sender, EventArgs e)
        {
            Frm4 frm4 = new Frm4();
            frm4.Show();
        }


    }
}
