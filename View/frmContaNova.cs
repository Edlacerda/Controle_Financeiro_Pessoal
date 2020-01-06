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
                    txtSaldoAtualTransf.Text = x.Saldo.ToString("C");
                    txtNomeContaTransf.Text = x.Conta;
                }
            }
            txtSaldoAtualTransf.Enabled = false;
            txtNomeContaTransf.Enabled = false;
        }

        // método para salvar classe através do click no botão salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaPreenchimento())
            {
            }
        }

        // verifica se todos os campos estão preenchidos
        private bool VerificaPreenchimento()
        {
            // || txtFornecedor.Text == "" || txtDescricao.Text == ""
            if (txtNomeConta.Text == "" || txtSaldoInicial.Text == "")
            {
                return false;
            }
            if (chkTransferencia.Checked && (cmbIdContaTransf.Text == "" || txtSaldoAtualTransf.Text == "" || txtNomeContaTransf.Text == ""))
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
