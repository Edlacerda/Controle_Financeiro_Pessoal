using System;
using System.Windows.Forms;
using Controle_Financeiro_Pessoal.Controller;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class frmMovimentacaoEditar : Form
    {
        frmMovimentacaoLista frmlistamovimentos;
        Classificacoes classe;
        Categoria categoria;
        Movimentacoes movimento;
        NConta conta;

        public frmMovimentacaoEditar(frmMovimentacaoLista F)
        {
            InitializeComponent();
            frmlistamovimentos = F;
            classe = new Classificacoes();
            categoria = new Categoria();
            movimento = new Movimentacoes();
            conta = new NConta();
            PreencherCmbIdMovimentacao();

            cmbIdCategoria.Enabled = false;
            txtNomeCategoria.Enabled = false;
            cmbIdClasse.Enabled = false;
            txtNomeClasse.Enabled = false;
            cmbIdConta.Enabled = false;
            txtConta.Enabled = false;
            txtValor.Enabled = false;
            txtData.Enabled = false;
            txtFornecedor.Enabled = false;
            txtDescricao.Enabled = false;
        }

        //preenchendo dos IDs de Movimento na combobox, conforme lista de movimentações
        private void PreencherCmbIdMovimentacao()
        {
            foreach (var x in movimento.ListaMovimentacoes)
            {
                cmbIdMovimento.Items.Add(x.Id_Movimento);
            }
        }

        // preecher dados da movimentação nos textboxs caso mudaça de valor do combobox
        private void cmbIdMovimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIdCategoria.Enabled = true;
            txtNomeCategoria.Enabled = true;
            cmbIdClasse.Enabled = true;
            cmbIdConta.Enabled = true;
            txtValor.Enabled = true;
            txtData.Enabled = true;
            txtFornecedor.Enabled = true;
            txtDescricao.Enabled = true;

            foreach (var x in movimento.ListaMovimentacoes)
            {
                if (cmbIdMovimento.Text == x.Id_Movimento.ToString())
                {
                    cmbIdCategoria.Text = x.Id_Categoria.ToString();
                    txtNomeCategoria.Text = categoria.NomeCategoria(x.Id_Categoria);
                    cmbIdClasse.Text = x.Id_Classe.ToString();
                    cmbIdClasse_SelectedIndexChanged();
                    cmbIdConta.Text = x.Id_Conta.ToString();
                    cmbIdConta_SelectedIndexChanged();
                    txtValor.Text = x.Valor.ToString("0.00");
                    txtData.Text = x.Data.ToString("dd/mm/yyyy");
                    txtFornecedor.Text = x.Fornecedor;
                    txtDescricao.Text = x.Descricao;
                    break;
                }
            }
        }

        // preenche o nome da Classe quando muda o combobox de id da classe
        private void cmbIdClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIdClasse_SelectedIndexChanged();
        }
        private void cmbIdClasse_SelectedIndexChanged()
        {
            txtNomeClasse.Enabled = true;

            foreach (var x in classe.ListaClasses)
            {
                if (cmbIdClasse.Text == x.IdClasse.ToString())
                {
                    txtNomeClasse.Text = x.Classe;
                    break;
                }
            }

            txtNomeClasse.Enabled = false;
        }

        // preenche o nome da Categoria quando muda o combobox de id da Categoria
        private void cmbIdCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoria.NomeCategoria(Convert.ToInt32(cmbIdCategoria));
        }

        // preenche o nome da Conta quando muda o combobox de id da Conta
        private void cmbIdConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIdConta_SelectedIndexChanged();
        }
        private void cmbIdConta_SelectedIndexChanged()
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
            if (movimento.AlterarMoviventacao(Convert.ToInt32(cmbIdMovimento.Text), Convert.ToInt32(cmbIdCategoria.Text), Convert.ToInt32(cmbIdClasse.Text), Convert.ToInt32(cmbIdConta.Text), Convert.ToDouble(txtValor.Text), Convert.ToDateTime(txtData.Text), txtFornecedor.Text, txtDescricao.Text))
            {
                frmlistamovimentos.AtualizarLvwmMovimentacoes();
                MessageBox.Show("Nome da Conta alterado com sucesso!");
            }
            else
                MessageBox.Show("Não foi possível alterar o nome da Conta.\n\nVerifique se todos os campos estão preenchidos corretamente");
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
