using System;
using System.Windows.Forms;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class frmNovaClassificacao : Form
    {
        frmControleFinanceiro formInicial;

        public frmNovaClassificacao(frmControleFinanceiro F)
        {
            InitializeComponent();
            formInicial = F;
        }

        private void frmNovaClassificacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            formInicial.Show();
        }
    }
}
