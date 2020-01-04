using System;
using System.Windows.Forms;
using Controle_Financeiro_Pessoal.Controller;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class frmMovimentacaoLista : Form
    {
        frmControleFinanceiro formInicial;
        Classificacoes classe;
        Categoria categoria;
        Movimentacoes movimento;
        NConta conta;

        public frmMovimentacaoLista(frmControleFinanceiro F)
        {
            InitializeComponent();
            // iniciado o Form que chamou para voltar nele quando fechar
            formInicial = F;
            PreencherLvwMovimentos();
        }

        public void AtualizarLvwmMovimentacoes()
        {
            lvwmMovimentacoes.Items.Clear();
            PreencherLvwMovimentos();
        }

        // preenchimento da lista com no ListView com os dados da classe e categoria a qual pertence
        public void PreencherLvwMovimentos()
        {
            // iniciado as classes e categoria para preenchimento da lista
            classe = new Classificacoes();
            categoria = new Categoria();
            conta = new NConta();
            movimento = new Movimentacoes();

            foreach (var x in movimento.ListaMovimentacoes)
            {
                ListViewItem item = new ListViewItem(x.Id_Movimento.ToString());
                item.SubItems.Add(conta.ListaContas[x.Id_Conta - 1].Conta);
                item.SubItems.Add(categoria.NomeCategoria(x.Id_Categoria));
                item.SubItems.Add(classe.ListaClasses[x.Id_Classe - 1].Classe);
                item.SubItems.Add(x.Valor.ToString("C"));
                item.SubItems.Add(x.Data.ToString("dd/MM/yyyy"));
                item.SubItems.Add(x.Fornecedor);
                item.SubItems.Add(x.Descricao);
                lvwmMovimentacoes.Items.Add(item);
            }
        }


        private void btnNovoMovimento_Click(object sender, EventArgs e)
        {
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmMovimentacaoExcluir x = new frmMovimentacaoExcluir(this);
            x.Show();
        }

        // fechando este form, volta para o form inicial (que o chamou)
        private void frmMovimentacaoLista_FormClosed(object sender, FormClosedEventArgs e)
        {
            formInicial.Show();
        }
    }
}
