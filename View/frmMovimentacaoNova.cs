using System;
using System.Windows.Forms;
using Controle_Financeiro_Pessoal.Controller;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class frmMovimentacaoNova : Form
    {
        frmMovimentacaoLista frmlistamovimentos;
        Classificacoes classe;
        Categoria categoria;
        Movimentacoes novoMovimento;
        NConta conta;

        public frmMovimentacaoNova(frmMovimentacaoLista F)
        {
            InitializeComponent();
            frmlistamovimentos = F;
            classe = new Classificacoes();
            categoria = new Categoria();
            conta = new NConta();
            novoMovimento = new Movimentacoes();
            PreencherCmbIdCategoria();
            PreencherCmbIdConta();
            txtNomeCategoria.Enabled = false;
            txtNomeClasse.Enabled = false;
            cmbIdClasse.Enabled = false;
            txtConta.Enabled = false;
        }

        //preenchendo categorias do 1 = ENTRADAS, 2 = SAÍDAS
        private void PreencherCmbIdCategoria()
        {
            cmbIdCategoria.Items.Add(1);
            cmbIdCategoria.Items.Add(2);
        }

        //preenchendo combobox das classes de acordo com a categoria indicada
        private void PreencherCmbIdClasse()
        {
            foreach (var x in classe.ListaClasses)
            {
                if (cmbIdCategoria.Text == x.Id_Categoria.ToString())
                    cmbIdClasse.Items.Add(x.IdClasse);
            }
        }
       
        //preenchendo combobox das contas
        private void PreencherCmbIdConta()
        {
            foreach (var x in conta.ListaContas)
            {
                cmbIdConta.Items.Add(x.Id_Conta);
            }
        }

        // preenche o nome da Categoria e libera o combobox de classe quando muda o combobox de id da Categoria
        private void cmbIdCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNomeCategoria.Enabled = true;

            txtNomeCategoria.Text = categoria.NomeCategoria(Convert.ToInt32(cmbIdCategoria.Text));
            cmbIdClasse.Items.Clear();
            cmbIdClasse.Text = "";
            txtNomeClasse.Text = "";
            PreencherCmbIdClasse();
            cmbIdClasse.Enabled = true;

            txtNomeCategoria.Enabled = false;
        }

        // preenche o nome da Classe quando muda o combobox de id da classe
        private void cmbIdClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtNomeClasse.Enabled = true;

            foreach (var x in classe.ListaClasses)
            {
                if (cmbIdClasse.Text == x.IdClasse.ToString())
                {
                    txtNomeClasse.Text = x.Classe;
                    break;
                }
            }

            //txtNomeClasse.Enabled = false;
        }

        // preenche o nome da Conta quando muda o combobox de id da Conta
        private void cmbIdConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtConta.Enabled = true;

            foreach (var x in conta.ListaContas)
            {
                if (cmbIdConta.Text == x.Id_Conta.ToString())
                {
                    txtConta.Text = x.Conta;
                    break;
                }
            }
            txtConta.Enabled = false;
        }

        // método para editar movimentacão através do click no botão salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (novoMovimento.InserirMovimento(Convert.ToInt32(cmbIdCategoria.Text), Convert.ToInt32(cmbIdClasse.Text), Convert.ToInt32(cmbIdConta.Text), Convert.ToDouble(txtValor.Text), Convert.ToDateTime(txtData.Text), txtFornecedor.Text, txtDescricao.Text))
            {
                frmlistamovimentos.AtualizarLvwmMovimentacoes();
                MessageBox.Show("Movimentação inserida com sucesso!");
            }
            else
                MessageBox.Show("Não foi possível inserir a movimentação.\n\nVerifique se todos os campos estão preenchidos corretamente");
            // toda vez que clicar em salvar, fecha o form
            this.Close();
        }

        // botão cancelar fecha o form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
