using System;
using System.Windows.Forms;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class frmContaNova : Form
    {
        frmControleFinanceiro formInicial;

        public frmContaNova(frmControleFinanceiro F)
        {
            InitializeComponent();
            formInicial = F;
        }

        private void frmNovaConta_FormClosed(object sender, FormClosedEventArgs e)
        {
            formInicial.Show();
        }
    }
}
