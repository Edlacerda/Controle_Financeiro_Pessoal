using System;
using System.Windows.Forms;
using Controle_Financeiro_Pessoal.Controller;


namespace Controle_Financeiro_Pessoal.View
{
    public partial class frmFluxoDeCaixa : Form
    {
        frmControleFinanceiro formInicial;
        Movimentacoes movimentos;
        Classificacoes classes;
        Categoria categorias;

        public frmFluxoDeCaixa(frmControleFinanceiro F)
        {
            InitializeComponent();
            formInicial = F;
            movimentos = new Movimentacoes();
            classes = new Classificacoes();
            categorias = new Categoria();

            PreencherCmbAno();
            PreencherFluxos(DateTime.Today.Year);
        }

        private void PreencherFluxos(int ano)
        {
            PreencherCategorias(lvwmEntrada, 1, ano);
            PreencherClasses(lvwmClassesEntrada, 1, ano);
            PreencherCategorias(lvwmSaida, 2, ano);
            PreencherClasses(lvwmClassesSaida, 2, ano);
            PreencherAcumulado(lvwmSaldo, ano);
        }

        private void PreencherClasses(ListView lvwn, int categoria, int ano)
        {
            lvwn.Items.Clear();

            foreach (var x in classes.ListaClasses)
            {
                ListViewItem item = new ListViewItem(x.Classe);
                for (int i = 1; i <= 12; i++)
                {
                    item.SubItems.Add(movimentos.FluxoClasses(categoria, x.IdClasse, i, ano));
                }
                lvwn.Items.Add(item);
            }
        }

        private void PreencherCategorias(ListView lvwn, int categoria, int ano)
        {
            lvwn.Items.Clear();

            ListViewItem item = new ListViewItem(categorias.NomeCategoria(categoria));
            for (int i = 1; i <= 12; i++)
            {
                item.SubItems.Add(movimentos.FluxoCategoria(categoria, i, ano));
            }
            lvwn.Items.Add(item);
        }

        private void PreencherAcumulado(ListView lvwn, int ano)
        {
            double saldo = SaldoAcumuladoAnterior(ano);
            lvwn.Items.Clear();

            ListViewItem item = new ListViewItem("ACUMULADO");
            for (int i = 1; i <= 12; i++)
            {
                saldo += Convert.ToDouble(movimentos.FluxoCategoria(1, i, ano));
                saldo -= Convert.ToDouble(movimentos.FluxoCategoria(2, i, ano));
                item.SubItems.Add(saldo.ToString("#,###.00"));
            }
            lvwn.Items.Add(item);
        }

        private double SaldoAcumuladoAnterior(int ano)
        {
            double saldo = 0;
            foreach (var valor in movimentos.AnosMovimentos())
            {
                if (valor < ano)
                {
                    for (int i = 1; i <= 12; i++)
                    {
                        saldo += Convert.ToDouble(movimentos.FluxoCategoria(1, i, valor));
                        saldo -= Convert.ToDouble(movimentos.FluxoCategoria(2, i, valor));
                    }
                }
            }
            return saldo;
        }

        private void PreencherCmbAno()
        {
            cmbAno.Items.Add(DateTime.Today.Year.ToString());
            foreach (var valor in movimentos.AnosMovimentos())
            {
                if (DateTime.Today.Year != valor)
                    cmbAno.Items.Add(valor.ToString());
            }
            cmbAno.SelectedIndex = 0;
        }

        private void cmbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencherFluxos(Convert.ToInt32(cmbAno.Text));
        }

        private void frmFluxoDeCaixa_FormClosed(object sender, FormClosedEventArgs e)
        {
            formInicial.Show();
        }
    }
}