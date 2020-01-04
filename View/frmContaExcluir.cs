using System;
using System.Windows.Forms;
using Controle_Financeiro_Pessoal.Controller;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class frmContaExcluir : Form
    {
        frmContaLista frmlistacontas;
        NConta Conta;

        public frmContaExcluir(frmContaLista F)
        {
            InitializeComponent();
            // iniciado as classes e categoria para preenchimento do nome da categoria e comparativo se existe outra igual
            frmlistacontas = F;
            Conta = new NConta();
            PreencherCmbIdConta();
            txtSaldoAtual.Enabled = false;
            txtNomeConta.Enabled = false;
        }

        //preencher o combobox do id da classe de transferência
        private void PreencherCmbIdConta()
        {
            foreach (var x in Conta.ListaContas)
            {
                cmbIdConta.Items.Add(x.Id_Conta);
            }
        }

        // preencher nome e saldo das contas de transferência
        private void cmbIdConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSaldoAtual.Enabled = true;
            txtNomeConta.Enabled = true;

            foreach (var x in Conta.ListaContas)
            {
                if (cmbIdConta.Text == x.Id_Conta.ToString())
                {
                    txtSaldoAtual.Text = x.Saldo.ToString("C");
                    txtNomeConta.Text = x.Conta;
                }
            }
            txtSaldoAtual.Enabled = false;
            txtNomeConta.Enabled = false;
        }

        // método para exlcluir clonta através do click no botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtSaldoAtual.Text) > 0)
            {
                MessageBox.Show("Não é possível excluir conta com saldo positivo.");
            }
            else
            {
                if (Conta.ExcluirConta(Convert.ToInt32(cmbIdConta.Text)))
                {
                    frmlistacontas.AtualizarLvwConta();
                    MessageBox.Show("Conta excluída com sucesso!");
                    // fecha o form quando consegue excluir conta
                    this.Close();
                }
                else
                    MessageBox.Show("Não foi possível alterar a Conta.");
            }
        }

        // botão cancelar fecha o form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
