using System;
using System.Windows.Forms;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class frmNovaMovimentacao : Form
    {
        frmControleFinanceiro formInicial;

        public frmNovaMovimentacao(frmControleFinanceiro F)
        {
            InitializeComponent();
            formInicial = F;
        }

        private void frmNovaMovimentacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            formInicial.Show();
        }
    }
}
