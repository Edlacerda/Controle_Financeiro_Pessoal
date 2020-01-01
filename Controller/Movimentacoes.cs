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

        public bool InserirConta(Movimentos novoMovimento)
        {
            if (AcessoDB.GravarMovimentacao(novoMovimento.Id_Categoria, novoMovimento.Id_Classe, novoMovimento.Id_Conta, novoMovimento.Valor, novoMovimento.Data, novoMovimento.Fornecedor, novoMovimento.Descricao))
            {
                ListaMovimentacoes.Add(novoMovimento);
                return true;
            }
            return false;
        }

        // Exclui movimento caso consiga excluir do DB
        public bool ExcluirMovimentacao(int IdMovimentação)
        {
            if (AcessoDB.DeletarMovimentacao(IdMovimentação))
            {
                foreach (Movimentos x in ListaMovimentacoes)
                {
                    if (x.Id_Movimento == IdMovimentação)
                    {
                        ListaMovimentacoes.Remove(x);
                        return true;
                    }
                }
            }
            return false;
        }

        // Modifica movimento caso consiga alterar no DB
        public bool AlterarMoviventacao(int Id_Movimento, int Id_Categoria, int Id_Classe, int Id_Conta, decimal Valor, DateTime Data, string Fornecedor, string Descricao)
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
