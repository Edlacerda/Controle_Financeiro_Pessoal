using System;
using System.Windows.Forms;
using Controle_Financeiro_Pessoal.Controller;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class frmClassificacaoEditar : Form
    {
        frmClassificacoesLista frmlistaclasses;
        Classificacoes classe;
        Categoria categoria;

        public frmClassificacaoEditar(frmClassificacoesLista F)
        {
            InitializeComponent();
            // iniciado as classes e categoria para preenchimento do nome da categoria e comparativo se existe outra igual
            frmlistaclasses = F;
            classe = new Classificacoes();
            categoria = new Categoria();
            PreencherCmbIdClasse();
            PreencherCmbIdCategoria();
            txtNomeCategoria.Enabled = false;
        }

        //preenchendo categorias do 1 = ENTRADAS, 2 = SAÍDAS
        private void PreencherCmbIdClasse()
        {
            foreach (var x in classe.ListaClasses)
            {
                cmbIdClasse.Items.Add(x.IdClasse);
            }
        }

        // botão cancelar fecha o form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // preecher nome da classe e Id da categoria nos textboxs caso mudaça de valor do combobox
        private void cmbIdClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var x in classe.ListaClasses)
            {
                if (cmbIdClasse.Text == Convert.ToString(x.IdClasse))
                {
                    txtNomeClasse.Text = x.Classe;
                    cmbIdCategoria.Text = Convert.ToString(x.Id_Categoria);
                    break;
                }
            }
        }

        //preenchendo categorias do 1 = ENTRADAS, 2 = SAÍDAS
        private void PreencherCmbIdCategoria()
        {
            cmbIdCategoria.Items.Add(1);
            cmbIdCategoria.Items.Add(2);
        }

        // preecher nome da categoria no textbox caso mudaça de valor do combobox
        private void cmbIdCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNomeCategoria.Enabled = true;

            txtNomeCategoria.Text = categoria.NomeCategoria(Convert.ToInt32(cmbIdCategoria.Text));

            txtNomeCategoria.Enabled = false;
        }

        // método para salvar alterações da classe através do click no botão salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (classe.AlterarClasse(Convert.ToInt32(cmbIdClasse.Text), Convert.ToInt32(cmbIdCategoria.Text), txtNomeClasse.Text))
            {
                frmlistaclasses.AtualizarLvwClasses();
                MessageBox.Show("Classe alterada com sucesso!");
            }
            else
                MessageBox.Show("Não foi possível alterar a Classe.\n\nVerifique se todos os campos estão preenchidos corretamente");
            // toda vez que clicar em salvar, fecha o form
            this.Close();
        }
    }

}
