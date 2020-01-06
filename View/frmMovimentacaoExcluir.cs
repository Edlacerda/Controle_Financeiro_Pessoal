using System;
using System.Windows.Forms;
using Controle_Financeiro_Pessoal.Controller;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class frmMovimentacaoExcluir : Form
    {
        frmMovimentacaoLista frmlistamovimentos;
        Classificacoes classe;
        Categoria categoria;
        Movimentacoes movimento;
        NConta conta;

        public frmMovimentacaoExcluir(frmMovimentacaoLista F)
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
                    txtValor.Text = x.Valor.ToString("C");
                    txtData.Text = x.Data.ToString("dd/MM/yyyy");
                    txtFornecedor.Text = x.Fornecedor;
                    txtDescricao.Text = x.Descricao;
                    break;
                }
            }

            cmbIdCategoria.Enabled = false;
            txtNomeCategoria.Enabled = false;
            cmbIdClasse.Enabled = false;
            cmbIdConta.Enabled = false;
            txtValor.Enabled = false;
            txtData.Enabled = false;
            txtFornecedor.Enabled = false;
            txtDescricao.Enabled = false;
        }

        // preenche o nome da Classe quando muda o combobox de id da classe
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

        // preenche o nome da Conta quando muda o combobox de id da Conta
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

        // método para exlcluir movimentacão através do click no botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (movimento.ExcluirMovimentacao(Convert.ToInt32(cmbIdMovimento.Text)))
            {
                frmlistamovimentos.AtualizarLvwmMovimentacoes();
                MessageBox.Show("Movimento excluída com sucesso!");
                // fecha o form quando consegue excluir classe
                this.Close();
            }
            else
                MessageBox.Show("Não foi possível excluir o Movimento.");
        }

        // botão cancelar fecha o form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
