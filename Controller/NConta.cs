using System;
using System.Collections.Generic;
using Controle_Financeiro_Pessoal.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Financeiro_Pessoal.Controller
{
    class NConta
    {
        public Contas Conta { get; set; }
        public Movimentacoes movimentos { get; set; }
        public List<Contas> ListaContas { get; set; }
        public NConta_DAO AcessoDB;

        public NConta()
        {
            AcessoDB = new NConta_DAO();
            ListaContas = AcessoDB.LerContas();
        }

        public bool InserirConta(Contas novaConta)
        {
            if (AcessoDB.GravarConta(novaConta.Conta, novaConta.Saldo))
            {
                ListaContas.Add(novaConta);
                return true;
            }
            return false;
        }

        private Contas AcessarConta(int idConta)
        {
            foreach (var x in AcessoDB.LerContas())
            {
                if (x.Id_Conta == idConta)
                {
                    return x;
                }
            }
            return null;
        }

        //
        public bool AlterarSaldo(int idCategoria, int idConta, double valor)
        {
            Conta = AcessarConta(idConta);

            if (idCategoria == 2)
            {
                if (Conta.Saldo < valor)
                    return false;
                Conta.Saldo -= valor;
            }
            else
            {
                Conta.Saldo += valor;
            }
            if (!AcessoDB.AlterarSaldo(idConta, Conta.Saldo))
                return false;
            return true;
        }

        // para excluir conta é necessário primeiro ver se não tem movimentos com a conta selecionada e se consegue excluir do DB
        public bool ExcluirConta(int IdConta)
        {
            if (!VerificaContaNosMovimentos(IdConta))
            {
                if (AcessoDB.DeletarConta(IdConta))
                {
                    foreach (Contas x in ListaContas)
                    {
                        if (x.Id_Conta == IdConta)
                        {
                            ListaContas.Remove(x);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        // para alterar conta também é necessário ver se não tem movimentos com a conta selecionada e se consegue alterar no DB
        public bool AlterarNomeConta(int IdConta, string Conta)
        {
            if (!VerificaContaNosMovimentos(IdConta))
            {
                if (AcessoDB.AlterarNomeConta(IdConta, Conta))
                {
                    foreach (Contas x in ListaContas)
                    {
                        if (x.Id_Conta == IdConta)
                        {
                            x.Conta = Conta;
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        // método para verificar se tem alguma movimentação com a conta desejada
        private bool VerificaContaNosMovimentos(int IdConta)
        {
            movimentos = new Movimentacoes();
            foreach (Movimentos x in movimentos.ListaMovimentacoes)
            {
                if (x.Id_Conta == IdConta)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
