using System;
using System.Collections.Generic;
using Controle_Financeiro_Pessoal.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Controle_Financeiro_Pessoal.Controller
{
    class Movimentacoes
    {
        public Movimentos movimento { get; set; }
        public List<Movimentos> ListaMovimentacoes { get; set; }
        public Movimentacoes_DAO AcessoDB;

        public Movimentacoes()
        {
            AcessoDB = new Movimentacoes_DAO();
            ListaMovimentacoes = AcessoDB.LerMovimentacoes();
        }

    }
}
