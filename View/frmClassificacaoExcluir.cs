using System;
using System.Windows.Forms;
using Controle_Financeiro_Pessoal.Controller;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class frmClassificacaoExcluir : Form
    {
        frmClassificacoesLista frmlistaclasses;
        Classificacoes classe;
        Categoria categoria;

        public frmClassificacaoExcluir(frmClassificacoesLista F)
        {
            InitializeComponent();
            // iniciado as classes e categoria para preenchimento do nome da categoria e comparativo se existe outra igual
            frmlistaclasses = F;
            classe = new Classificacoes();
            categoria = new Categoria();
            PreencherCmbIdClasse();
            PreencherCmbIdCategoria();
            txtNomeClasse.Enabled = false;
            cmbIdCategoria.Enabled = false;
            txtNomeCategoria.Enabled = false;
        }

        //preenchendo das classses, conforme lista
        private void PreencherCmbIdClasse()
        {
            foreach (var x in classe.ListaClasses)
            {
                cmbIdClasse.Items.Add(x.IdClasse);
            }
            cmbIdClasse.Items.Remove(6);
            cmbIdClasse.Items.Remove(1);
        }

        // botão cancelar fecha o form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // preecher nome da classe e Id da categoria nos textboxs caso mudaça de valor do combobox
        private void cmbIdClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNomeClasse.Enabled = true;
            cmbIdCategoria.Enabled = true;

            foreach (var x in classe.ListaClasses)
            {
                if (cmbIdClasse.Text == Convert.ToString(x.IdClasse))
                {
                    txtNomeClasse.Text = x.Classe;
                    cmbIdCategoria.Text = Convert.ToString(x.Id_Categoria);
                    txtNomeCategoria.Text = categoria.NomeCategoria(Convert.ToInt32(cmbIdCategoria.Text));
                    break;
                }
            }

            txtNomeClasse.Enabled = false;
            cmbIdCategoria.Enabled = false;
        }

        //preenchendo categorias do 1 = ENTRADAS, 2 = SAÍDAS
        private void PreencherCmbIdCategoria()
        {
            cmbIdCategoria.Items.Add(1);
            cmbIdCategoria.Items.Add(2);
        }

        // método para exlcluir classe através do click no botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (cmbIdClasse.Text != "")
            {
                if (classe.ExcluirClasse(Convert.ToInt32(cmbIdClasse.Text)))
                {
                    frmlistaclasses.AtualizarLvwClasses();
                    MessageBox.Show("Classe excluída com sucesso!");
                    // fecha o form quando consegue excluir classe
                    this.Close();
                }
            }
            else
                MessageBox.Show("Não foi possível alterar a Classe.\n\nVerifique se todos os campos estão preenchidos corretamente");
        }

    }

}
