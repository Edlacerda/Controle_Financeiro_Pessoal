using System;
using Controle_Financeiro_Pessoal.View;
using System.Windows.Forms;

namespace Controle_Financeiro_Pessoal
{
    public partial class frmControleFinanceiro : Form
    {
        public frmControleFinanceiro()
        {
            InitializeComponent();
        }

        private void TSMFluxoDeCaixaAnual_Click(object sender, EventArgs e)
        {
            frmFluxoDeCaixa x = new frmFluxoDeCaixa(this);
            x.Show();
            this.Hide();
        }

        private void TSMNovaConta_Click(object sender, EventArgs e)
        {
            frmNovaConta x = new frmNovaConta(this);
            x.Show();
            this.Hide();

        }

        private void TSMNovaMovimentacao_Click(object sender, EventArgs e)
        {
            frmNovaMovimentacao x = new frmNovaMovimentacao(this);
            x.Show();
            this.Hide();
        }

        private void TSMNovaClassificacao_Click(object sender, EventArgs e)
        {
            frmNovaClassificacao x = new frmNovaClassificacao(this);
            x.Show();
            this.Hide();
        }
    }
}
