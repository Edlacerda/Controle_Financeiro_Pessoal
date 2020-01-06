using System.Collections.Generic;
using Controle_Financeiro_Pessoal.Model;

namespace Controle_Financeiro_Pessoal.Controller
{
    class Classificacoes
    {
        public Classes classificacao { get; set; }
        public Movimentacoes movimentos { get; set; }
        public List<Classes> ListaClasses { get; set; }
        public Classificacoes_DAO AcessoDB;

        // no construtor é necessário acessar o banco de dados pela classe DAO e preencher a lista de classes existentes
        public Classificacoes()
        {
            AcessoDB = new Classificacoes_DAO();
            ListaClasses = AcessoDB.LerClasses();
        }

        // inserção da nova classe na lista, verificando primeiramente a inserção no DataBase
        public bool InserirClasse(int IDCategoria, string Classe)
        {
            if (AcessoDB.GravarClasse(IDCategoria, Classe))
            {
                return true;
            }
            return false;
        }

        // para excluir classe é necessário primeiro ver se não tem movimentos com a classe selecionada e se consegue excluir do DB
        public bool ExcluirClasse(int IdClasse)
        {
            if (!VerificaClasseNosMovimentos(IdClasse))
            {
                if (AcessoDB.DeletarClasse(IdClasse))
                {
                    foreach (Classes x in ListaClasses)
                    {
                        if (x.IdClasse == IdClasse)
                        {
                            ListaClasses.Remove(x);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        // para alterar classe também é necessário ver se não tem movimentos com a classe selecionada e se consegue alterar no DB
        public bool AlterarClasse(int IdClasse, int IDCategoria, string Classe)
        {
            if (!VerificaClasseNosMovimentos(IdClasse))
            {
                if (AcessoDB.AlterarClasse(IdClasse, IDCategoria, Classe))
                {
                    foreach (Classes x in ListaClasses)
                    {
                        if (x.IdClasse == IdClasse)
                        {
                            x.Id_Categoria = IDCategoria;
                            x.Classe = Classe;
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        // método para verificar se tem alguma movimentação com a classe desejada
        private bool VerificaClasseNosMovimentos(int IdClasse)
        {
            movimentos = new Movimentacoes();
            foreach (Movimentos x in movimentos.ListaMovimentacoes)
            {
                if (x.Id_Classe == IdClasse)
                {
                    return true;
                }
            }
            return false;
        }

        // retorna o nome da classe conforme id
        public string NomeClasse(int idClasse)
        {
            foreach (var x in ListaClasses)
            {
                if (x.IdClasse == idClasse)
                {
                    return x.Classe;
                }
            }
            return "";
        }
    }
}
