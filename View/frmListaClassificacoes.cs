using System;
using System.Windows.Forms;
using Controle_Financeiro_Pessoal.Controller;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class frmListaClassificacoes : Form
    {
        frmControleFinanceiro formInicial;
        Classificacoes classe;
        Categoria categoria;
        
        public frmListaClassificacoes(frmControleFinanceiro F)
        {
            InitializeComponent();
            // iniciado o Form que chamou para voltar nele quando fechar
            formInicial = F;
            // iniciado as classes e categoria para preenchimento da lista
            classe = new Classificacoes();
            categoria = new Categoria();
            PreencherLvwClasses();
        }

        // preenchimento da lista com no ListView com os dados da classe e categoria a qual pertence
        private void PreencherLvwClasses()
        {
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
            frmNovaClassificacao x = new frmNovaClassificacao();
            x.Show();
        }

        // fechando este form, volta para o form inicial (que o chamou)
        private void frmListaClassificacoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            formInicial.Show();
        }
    }
}
