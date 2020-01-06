using System;
using System.Collections.Generic;
using Controle_Financeiro_Pessoal.Model;

namespace Controle_Financeiro_Pessoal.Controller
{
    class Movimentacoes
    {
        public Movimentos movimento { get; set; }
        public NConta novaConta { get; set; }
        public List<Movimentos> ListaMovimentacoes { get; set; }
        public Movimentacoes_DAO AcessoDB;

        public Movimentacoes()
        {
            AcessoDB = new Movimentacoes_DAO();
            ListaMovimentacoes = AcessoDB.LerMovimentacoes();
        }

        public bool InserirMovimento(int idCategoria, int idClasse, int idConta, double valor, DateTime data, string fornecedor, string descricao)
        {
            novaConta = new NConta();
            if (novaConta.AlterarSaldo(idCategoria, idConta, valor))
            {
                if (AcessoDB.GravarMovimentacao(idCategoria, idClasse, idConta, valor, data, fornecedor, descricao))
                {
                    return true;
                }
            }
            return false;
        }

        // Exclui movimento caso consiga excluir do DB
        public bool ExcluirMovimentacao(int IdMovimentação)
        {
            novaConta = new NConta();
            foreach (Movimentos x in ListaMovimentacoes)
            {
                if (x.Id_Movimento == IdMovimentação)
                {
                    int idcateg;
                    if (x.Id_Categoria == 1)
                        idcateg = 2;
                    else
                        idcateg = 1;
                    if (novaConta.AlterarSaldo(idcateg, x.Id_Conta, x.Valor))
                    {
                        if (AcessoDB.DeletarMovimentacao(IdMovimentação))
                        {
                            ListaMovimentacoes.Remove(x);
                            return true;
                        }
                    }

                }
            }
            return false;
        }

        // Modifica movimento caso consiga alterar no DB
        public bool AlterarMoviventacao(int Id_Movimento, int Id_Categoria, int Id_Classe, int Id_Conta, double Valor, DateTime Data, string Fornecedor, string Descricao)
        {
            if (AcessoDB.AlterarMovimentacao(Id_Movimento, Id_Categoria, Id_Classe, Id_Conta, Valor, Data, Fornecedor, Descricao))
            {
                foreach (Movimentos x in ListaMovimentacoes)
                {
                    if (x.Id_Movimento == Id_Movimento)
                    {
                        x.Id_Categoria = Id_Categoria;
                        x.Id_Classe = Id_Classe;
                        x.Id_Conta = Id_Conta;
                        x.Valor = Valor;
                        x.Data = Data;
                        x.Fornecedor = Fornecedor;
                        x.Descricao = Descricao;
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
