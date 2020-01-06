using System;
using System.Windows.Forms;
using Controle_Financeiro_Pessoal.Controller;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class frmContaEditar : Form
    {
        frmContaLista frmlistacontas;
        NConta conta;

        public frmContaEditar(frmContaLista F)
        {
            InitializeComponent();
            // iniciado as classes e categoria para preenchimento do nome da categoria e comparativo se existe outra igual
            frmlistacontas = F;
            conta = new NConta();
            PreencherCmbIdConta();
        }

        // botão cancelar fecha o form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //preenchendo ids da conta no combobox
        private void PreencherCmbIdConta()
        {
            foreach (var x in conta.ListaContas)
            {
                cmbIdConta.Items.Add(x.Id_Conta);
            }
        }

        // preecher nome da categoria no textbox caso mudaça de valor do combobox
        private void cmbIdConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var x in conta.ListaContas)
            {
                if(Convert.ToInt32(cmbIdConta.Text) == x.Id_Conta)
                {
                    txtNomeConta.Text = x.Conta;
                }
            }
        }

        // método para salvar alterações do nome da conta através do click no botão salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (conta.AlterarNomeConta(Convert.ToInt32(cmbIdConta.Text), txtNomeConta.Text))
            {
                frmlistacontas.AtualizarLvwConta();
                MessageBox.Show("Nome da Conta alterado com sucesso!");
            }
            else
                MessageBox.Show("Não foi possível alterar o nome da Conta.\n\nVerifique se todos os campos estão preenchidos corretamente");
            // toda vez que clicar em salvar, fecha o form
            this.Close();
        }
    }
}
