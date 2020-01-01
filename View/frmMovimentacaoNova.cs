using System;
using System.Windows.Forms;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class frmMovimentacaoNova : Form
    {
        frmControleFinanceiro formInicial;

        public frmMovimentacaoNova(frmControleFinanceiro F)
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
