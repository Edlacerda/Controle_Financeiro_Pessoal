using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace Controle_Financeiro_Pessoal.Model
{
    class Data
    {
        static string connectionString;
        static SqlConnection sqlConn;
        private SqlCommand cmd;

        //construtor de definição dos parâmetros de conexão
        public Data()
        {
            //definindo conexão com banco de dados, conforme string de conexão DB local
            connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DBFinanceiro;Data Source=DESKTOP-9GTTT8Q";
            sqlConn = new SqlConnection(connectionString);
        }

        // Método para executar o comando no banco de dados, caso consiga, retorna True. Se falhar, retorna False
        private bool conexão(SqlCommand comando)
        {
            try
            {
                sqlConn.Open();
                comando.ExecuteNonQuery();
                sqlConn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // método booleano para informar ao usuário se obteve sucesso ao salvar as informações no banco de dado
        public bool GravarMovimentacao(int id_Categoria, int id_Classe, decimal valor, DateTime data, string fornecedor, string descricao)
        {
            // definindo sql de insersão e atribuindo os parâmetros
            cmd = new SqlCommand("insert into Movimentacoes(Id_Categoria, Id_Classe, Valor, Data, Fornecedor, Descricao) values (@idCategoria, @idClasse, @valor, @data, @fornecedor, @descricao)", sqlConn);
            cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = id_Categoria;
            cmd.Parameters.Add("@idClasse", SqlDbType.Int).Value = id_Classe;
            cmd.Parameters.Add("@valor", SqlDbType.Decimal).Value = valor;
            cmd.Parameters.Add("@data", SqlDbType.DateTime).Value = data;
            cmd.Parameters.Add("@fornecedor", SqlDbType.VarChar).Value = fornecedor;
            cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = descricao;

            if (conexão(cmd))
                return true;
            return false;
        }

        // Método de alteração, necessário informar todos os parâmetros, considerando que não se sabe qual será alterado
        public bool AlterarMovimentacao(int id_Movimento, int id_Categoria, int id_Classe, decimal valor, DateTime data, string fornecedor, string descricao)
        {
            cmd = new SqlCommand("use DB_Financeiro UPDATE Movimentacoes SET Id_Categoria = " + id_Categoria + ", Id_Classe = " + id_Classe + ", Valor = " + valor + ", Data = " + data + ", Fornecedor = '" + fornecedor + "', Descricao = '" + descricao + "' WHERE IDMovimento = " + id_Movimento, sqlConn);
            if (conexão(cmd))
                return true;
            return false;
        }

        // Método para excluir a movimentação financeira
        public bool DeletarMovimentacao(int id_Movimento)
        {
            cmd = new SqlCommand("use DB_Financeiro DELETE FROM Movimentacoes WHERE IDMovimento = " + id_Movimento, sqlConn);
            if (conexão(cmd))
                return true;
            return false;
        }

        // método para ler todo banco de dados e retornar as informações em uma lista
        public List<Movimentacoes> GravarMovimentacao()
        {
            List<Movimentacoes> lista = new List<Movimentacoes>();

            sqlConn.Open();
            cmd = new SqlCommand("select * from Movimentacoes", sqlConn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Movimentacoes(Convert.ToInt32(dr[0]), Convert.ToInt32(dr[1]), Convert.ToInt32(dr[2]), Convert.ToDecimal(dr[3]), Convert.ToDateTime(dr[4]), Convert.ToString(dr[5]), Convert.ToString(dr[6])));
            }
            sqlConn.Close();
            Console.ReadKey();

            return lista;
        }
    }
}
