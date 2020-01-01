﻿using System;
using Controle_Financeiro_Pessoal.View;
using System.Windows.Forms;

namespace Controle_Financeiro_Pessoal
{
    public partial class frmControleFinanceiro : Form
    {
        public frmControleFinanceiro()
        {
            InitializeComponent();
        }

        private void tsmiMovimentacoes_Click(object sender, EventArgs e)
        {
            frmMovimentacaoNova x = new frmMovimentacaoNova(this);
            x.Show();
            this.Hide();
        }

        private void tmsiContas_Click(object sender, EventArgs e)
        {
            frmContaNova x = new frmContaNova(this);
            x.Show();
            this.Hide();
        }

        private void tsmiClasses_Click(object sender, EventArgs e)
        {
            frmClassificacoesLista x = new frmClassificacoesLista(this);
            x.Show();
            this.Hide();
        }
        private void tsmiFluxoDeCaixa_Click(object sender, EventArgs e)
        {
            frmFluxoDeCaixa x = new frmFluxoDeCaixa(this);
            x.Show();
            this.Hide();
        }

        private void tsmiInformacoes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por Eduardo Lacerda Ribeiro!", "INFORMAÇÕES");
        }
    }
}
