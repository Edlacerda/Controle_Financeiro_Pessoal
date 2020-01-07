using System;
using System.Windows.Forms;
using Controle_Financeiro_Pessoal.Controller;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class frmContaNova : Form
    {
        frmContaLista frmlistacontas;
        NConta Conta;
        Movimentacoes movimento;

        public frmContaNova(frmContaLista F)
        {
            InitializeComponent();
            // iniciado as classes e categoria para preenchimento do nome da categoria e comparativo se existe outra igual
            frmlistacontas = F;
            Conta = new NConta();
            movimento = new Movimentacoes();
            grpTransferencia.Visible = false;
        }

        //mostrar group box dos dados de transferência, caso seja marcado o checkbox de transferência
        private void chkTransferencia_Click(object sender, EventArgs e)
        {
            if (chkTransferencia.Checked)
            {
                grpTransferencia.Visible = true;
                PreencherCmbIdContaTransf();
                txtSaldoAtualTransf.Enabled = false;
                txtNomeContaTransf.Enabled = false;
            }
            else
            {
                grpTransferencia.Visible = false;
            }
        }

        //preencher o combobox do id da classe de transferência
        private void PreencherCmbIdContaTransf()
        {
            foreach (var x in Conta.ListaContas)
            {
                cmbIdContaTransf.Items.Add(x.Id_Conta);
            }
        }

        // preencher nome e saldo das contas de transferência
        private void cmbIdContaTransf_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSaldoAtualTransf.Enabled = true;
            txtNomeContaTransf.Enabled = true;

            foreach (var x in Conta.ListaContas)
            {
                if (cmbIdContaTransf.Text == x.Id_Conta.ToString())
                {
                    txtSaldoAtualTransf.Text = x.Saldo.ToString("#,###.00");
                    txtNomeContaTransf.Text = x.Conta;
                }
            }
            txtSaldoAtualTransf.Enabled = false;
            txtNomeContaTransf.Enabled = false;
        }

        // método para salvar conta através do click no botão salvar, verificando se conta de transferência possui saldo suficiente
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //verifica se os campos estão preenchidos
            if (VerificaPreenchimento())
            {
                // estando preenchidos, verifica se foi marcado a transferência de outra conta
                if (chkTransferencia.Checked)
                {
                    // sendo transferência, verifica se a conta que será transferida tem saldo suficiente.
                    if (Convert.ToDouble(txtSaldoAtualTransf.Text) > Convert.ToDouble(txtSaldoInicial.Text))
                    {
                        // tendo saldo, realiza movimento para tirar da conta de transferência e cria a nova conta
                        movimento.InserirMovimento(2, 6, Convert.ToInt32(cmbIdContaTransf.Text), Convert.ToDouble(txtSaldoInicial.Text), DateTime.Today, txtNomeConta.Text, "Transferência para a nova conta");
                        CriarNovaConta();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível criar nova conta.\n\nSaldo da conta de transferência insuficiente");
                    }
                }
                else
                {
                    // se não for de transferência, cria a nova conta normalmente
                    CriarNovaConta();
                }
            }
            else
                MessageBox.Show("Não foi possível criar nova conta.\n\nVerifique se todos os campos estão preenchidos corretamente");
        }

        // método para criar nova conta
        private void CriarNovaConta()
        {
            if (Conta.InserirConta(txtNomeConta.Text, Convert.ToDouble(txtSaldoInicial.Text)))
            {
                frmlistacontas.AtualizarLvwConta();
                MessageBox.Show("Conta criada com sucesso!");
                // toda vez que clicar em salvar, fecha o form
                this.Close();
            }
            else
                MessageBox.Show("Não foi possível criar nova conta.\n\nVerifique se todos os campos estão preenchidos corretamente");
        }

        // verifica se todos os campos estão preenchidos
        private bool VerificaPreenchimento()
        {
            // primeiro verifica se todos os campos de transferência estão preenchidos caso o checkbox esteja marcado
            if (chkTransferencia.Checked && (cmbIdContaTransf.Text == "" || txtSaldoAtualTransf.Text == "" || txtNomeContaTransf.Text == ""))
            {
                return false;
            }
            // verifica também se os campoos de criação da nova Conta estão preenchidos (independente dos campos de transferência)
            if (txtNomeConta.Text == "" || txtSaldoInicial.Text == "")
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
