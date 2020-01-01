using System;
using System.Collections.Generic;
using Controle_Financeiro_Pessoal.Model;
using System.Data.SqlClient;
using System.Data;

namespace Controle_Financeiro_Pessoal.Controller
{
    class Classificacoes_DAO
    {
        public Data DBClassificacoes { get; set; }
                public Classes classificacao { get; set; }

        public Classificacoes_DAO()
        {
            DBClassificacoes = new Data();
        }

        private bool conexão(SqlCommand comando)
        {
            try
            {
                DBClassificacoes.sqlConn.Open();
                comando.ExecuteNonQuery();
                DBClassificacoes.sqlConn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // método booleano para informar ao usuário se obteve sucesso ao salvar as informações no banco de dado
        public bool GravarClasse(int id_Categoria,  string classe)
        {
            // definindo sql de insersão e atribuindo os parâmetros
            DBClassificacoes.cmd = new SqlCommand("insert into Classe(Id_Categoria, Classe) values (@idCategoria, @classe)", DBClassificacoes.sqlConn);
            DBClassificacoes.cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = id_Categoria;
            DBClassificacoes.cmd.Parameters.Add("@classe", SqlDbType.VarChar).Value = classe;

            if (conexão(DBClassificacoes.cmd))
                return true;
            return false;
        }

        // Método de alteração, necessário informar todos os parâmetros, considerando que não se sabe qual será alterado
        public bool AlterarClasse(int id_Classe, int id_Categoria, string classe)
        {
            DBClassificacoes.cmd = new SqlCommand("use DB_Financeiro UPDATE Classe SET Id_Categoria = " + id_Categoria + ", IdClasse = " + id_Classe + ", Classe = '" + classe + "' WHERE IdClasse = " + id_Classe, DBClassificacoes.sqlConn);
            if (conexão(DBClassificacoes.cmd))
                return true;
            return false;
        }

        // Método para excluir a movimentação financeira
        public bool DeletarClasse(int Id_Classe)
        {
            DBClassificacoes.cmd = new SqlCommand("use DB_Financeiro DELETE FROM Classe WHERE IdClasse = " + Id_Classe, DBClassificacoes.sqlConn);
            if (conexão(DBClassificacoes.cmd))
                return true;
            return false;
        }

        // método para ler todo banco de dados e retornar as informações em uma lista
        public List<Classes> LerClasses()
        {
            List<Classes> lista = new List<Classes>();

            DBClassificacoes.sqlConn.Open();
            DBClassificacoes.cmd = new SqlCommand("use DBFinanceiro select * from Classe", DBClassificacoes.sqlConn);
            SqlDataReader dr = DBClassificacoes.cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Classes(Convert.ToInt32(dr[0]), Convert.ToInt32(dr[1]), Convert.ToString(dr[2])));
            }
            DBClassificacoes.sqlConn.Close();
            return lista;
        }

    }
}
