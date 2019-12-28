using System;
using System.Windows.Forms;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class frmFluxoDeCaixa : Form
    {
        frmControleFinanceiro formInicial;

        public frmFluxoDeCaixa(frmControleFinanceiro F)
        {
            InitializeComponent();
            formInicial = F;
        }

        private void frmFluxoDeCaixa_FormClosed(object sender, FormClosedEventArgs e)
        {
            formInicial.Show();
        }
    }
}
