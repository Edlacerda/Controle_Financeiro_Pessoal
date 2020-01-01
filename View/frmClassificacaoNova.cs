using System;
using System.Windows.Forms;
using Controle_Financeiro_Pessoal.Controller;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class frmClassificacaoNova : Form
    {
        frmClassificacoesLista frmlistaclasses;
        Classificacoes classe;
        Categoria categoria;

        public frmClassificacaoNova(frmClassificacoesLista F)
        {
            InitializeComponent();
            // iniciado as classes e categoria para preenchimento do nome da categoria e comparativo se existe outra igual
            frmlistaclasses = F;
            classe = new Classificacoes();
            categoria = new Categoria();
            PreencherCmbCategoria();
            txtNomeCategoria.Enabled = false;
        }

        //preenchendo categorias do 1 = ENTRADAS, 2 = SAÍDAS
        private void PreencherCmbCategoria()
        {
            cmbCategoria.Items.Add(1);
            cmbCategoria.Items.Add(2);
        }

        // método para salvar classe através do click no botão salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int cont = 1;
            //verifica se as caixas de texto não estão vazias
            if (cmbCategoria.Text != "" && txtNomeClasse.Text != "")
            {
                // não estando, seta o valor de cont a 0
                cont -= 1;
                // e busca na lista de classses se em alguma com a mesma categoria e nome
                foreach (var x in classe.ListaClasses)
                {
                    if (x.Id_Categoria == Convert.ToInt32(cmbCategoria.Text) && x.Classe == txtNomeClasse.Text)
                    {
                        // se tiver volta o valor de cont a 1
                        cont += 1;
                        break;
                    }
                }
            }
            // so grava nova classe se o valor de cont for 0 (textos estando preenchidos e diferentes dos da lista
            if (cont == 0)
                if (classe.InserirClasse(Convert.ToInt32(cmbCategoria.Text), txtNomeClasse.Text))
                {
                    frmlistaclasses.AtualizarLvwClasses();
                    MessageBox.Show("Classe inserida com sucesso!");
                }
                else
                    MessageBox.Show("Não foi possível salvar a Classe.\n\nVerifique se todos os campos estão preenchidos \nou se a Classe já existe na categoria");
            // toda vez que clicar em salvar, fecha o form
            this.Close();
        }

        // botão cancelar fecha o form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // preecher nome da categoria no textbox caso mudaça de valor do combobox
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNomeCategoria.Enabled = true;

            txtNomeCategoria.Text = categoria.NomeCategoria(Convert.ToInt32(cmbCategoria.Text));

            txtNomeCategoria.Enabled = false;
        }
    }

}
