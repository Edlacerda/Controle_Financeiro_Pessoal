using System;
using System.Windows.Forms;
using Controle_Financeiro_Pessoal.Controller;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class frmClassificacoesLista : Form
    {
        frmControleFinanceiro formInicial;
        Classificacoes classe;
        Categoria categoria;
        
        public frmClassificacoesLista(frmControleFinanceiro F)
        {
            InitializeComponent();
            // iniciado o Form que chamou para voltar nele quando fechar
            formInicial = F;
            PreencherLvwClasses();
        }

        public void AtualizarLvwClasses()
        {
            lvwClasses.Items.Clear();
            PreencherLvwClasses();
        }

        // preenchimento da lista com no ListView com os dados da classe e categoria a qual pertence
        public void PreencherLvwClasses()
        {
            // iniciado as classes e categoria para preenchimento da lista
            classe = new Classificacoes();
            categoria = new Categoria();

            foreach (var x in classe.ListaClasses)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(x.IdClasse));
                item.SubItems.Add(Convert.ToString(x.Id_Categoria));
                item.SubItems.Add(categoria.NomeCategoria(x.Id_Categoria));
                item.SubItems.Add(Convert.ToString(x.Classe));
                lvwClasses.Items.Add(item);
            }
        }

        // botão Nova Classe abre o forme para criar classe, sem fechar a lista de forms
        private void btnNovaClasse_Click(object sender, EventArgs e)
        {
            frmClassificacaoNova x = new frmClassificacaoNova(this);
            x.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmClassificacaoEditar x = new frmClassificacaoEditar(this);
            x.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmClassificacaoExcluir x = new frmClassificacaoExcluir(this);
            x.Show();
        }

        // fechando este form, volta para o form inicial (que o chamou)
        private void frmListaClassificacoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            formInicial.Show();
        }
    }
}
