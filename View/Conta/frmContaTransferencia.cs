using System;
using System.Windows.Forms;
using Controle_Financeiro_Pessoal.Controller;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class frmContaTransferencia : Form
    {
        frmContaLista frmlistaContas;
        Movimentacoes novoMovimento;
        NConta conta;

        public frmContaTransferencia(frmContaLista F)
        {
            InitializeComponent();
            frmlistaContas = F;
            conta = new NConta();
            novoMovimento = new Movimentacoes();
            PreencherCmbIdContas(cmbIDContaATransferir);
            PreencherCmbIdContas(cmbIDContaTransfencia);

            txtContaATransferir.Enabled = false;
            txtSaldoContaATransferir.Enabled = false;
            txtContaTransfencia.Enabled = false;
            txtSaldoContaTransfencia.Enabled = false;
        }

        //preenchendo combobox das contas
        private void PreencherCmbIdContas(ComboBox nomeCmb)
        {
            foreach (var x in conta.ListaContas)
            {
                nomeCmb.Items.Add(x.Id_Conta);
            }
        }

        // preenche o nome da Conta e saldo quando muda o combobox de id
        private void cmbIDContaATransferir_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var x in conta.ListaContas)
            {
                if (cmbIDContaATransferir.Text == x.Id_Conta.ToString())
                {
                    txtSaldoContaATransferir.Text = x.Saldo.ToString("#,###.00");
                    txtContaATransferir.Text = x.Conta;
                    break;
                }
            }
        }
        private void cmbIDContaTransfencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var x in conta.ListaContas)
            {
                if (cmbIDContaTransfencia.Text == x.Id_Conta.ToString())
                {
                    txtSaldoContaTransfencia.Text = x.Saldo.ToString("#,###.00");
                    txtContaTransfencia.Text = x.Conta;
                    break;
                }
            }
        }

        // método para criar movimentações de entrada (conta a transferir) e saida (conta transferencia) do  através do click no botão Transferir
        private void btnTransferir_Click(object sender, EventArgs e)
        {
            if (VerificaPreenchimento())
            {
                double valor = Convert.ToDouble(txtValor.Text);
                if (Convert.ToDouble(txtSaldoContaTransfencia.Text) >= valor)
                {
                    novoMovimento.InserirMovimento(1, 2, Convert.ToInt32(cmbIDContaATransferir.Text), valor, DateTime.Today, txtContaTransfencia.Text, "Transferência entre contas");
                    novoMovimento.InserirMovimento(2, 3, Convert.ToInt32(cmbIDContaTransfencia.Text), valor, DateTime.Today, txtContaATransferir.Text, "Transferência entre contas");
                    frmlistaContas.AtualizarLvwConta();
                    MessageBox.Show("Movimentação inserida com sucesso!");
                    // toda vez que clicar em salvar, fecha o form
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não foi possível inserir a movimentação.\n\nValor a ser transferido maior que saldo da conta de transferencia");
                }
            }
            else
                MessageBox.Show("Não foi possível inserir a movimentação.\n\nVerifique se todos os campos estão preenchidos corretamente");
        }

        // verifica se todos os campos estão preenchidos
        private bool VerificaPreenchimento()
        {
            if (cmbIDContaATransferir.Text == "" || cmbIDContaTransfencia.Text == "" || txtValor.Text == "")
            {
                return false;
            }
            return true;
        }

        // botão cancelar fecha o form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
