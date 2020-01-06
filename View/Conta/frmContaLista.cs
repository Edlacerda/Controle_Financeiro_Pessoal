using System;
using System.Windows.Forms;
using Controle_Financeiro_Pessoal.Controller;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class frmContaLista : Form
    {
        frmControleFinanceiro formInicial;
        NConta conta;
        
        public frmContaLista(frmControleFinanceiro F)
        {
            InitializeComponent();
            // iniciado o Form que chamou para voltar nele quando fechar
            formInicial = F;
            PreencherLvwContas();
        }

        public void AtualizarLvwConta()
        {
            lvwContas.Items.Clear();
            PreencherLvwContas();
        }

        // preenchimento da lista com no ListView com os dados da conta
        public void PreencherLvwContas()
        {
            // iniciado a conta para preenchimento da lista
            conta = new NConta();

            foreach (var x in conta.ListaContas)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(x.Id_Conta));
                item.SubItems.Add(x.Conta);
                item.SubItems.Add(x.Saldo.ToString("C"));
                lvwContas.Items.Add(item);
            }
        }

        // botão Nova Classe abre o forme para criar classe, sem fechar a lista de forms
        private void btnNovaConta_Click(object sender, EventArgs e)
        {
            frmContaNova x = new frmContaNova(this);
            x.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmContaEditar x = new frmContaEditar(this);
            x.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmContaExcluir x = new frmContaExcluir(this);
            x.Show();
        }

        // fechando este form, volta para o form inicial (que o chamou)
        private void frmContaLista_FormClosed(object sender, FormClosedEventArgs e)
        {
            formInicial.Show();
        }
    }
}
