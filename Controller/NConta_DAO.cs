using System;
using System.Collections.Generic;
using Controle_Financeiro_Pessoal.Model;
using System.Data.SqlClient;
using System.Data;

namespace Controle_Financeiro_Pessoal.Controller
{
    class NConta_DAO
    {
        public Data DBContas { get; set; }

        public NConta_DAO()
        {
            DBContas = new Data();
        }

        private bool conexão(SqlCommand comando)
        {
            try
            {
                DBContas.sqlConn.Open();
                comando.ExecuteNonQuery();
                DBContas.sqlConn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // método booleano para informar ao usuário se obteve sucesso ao salvar as informações no banco de dado
        public bool GravarConta(string conta)
        {
            // definindo sql de insersão e atribuindo os parâmetros
            DBContas.cmd = new SqlCommand("insert into Conta(Conta) values (@conta)", DBContas.sqlConn);
            DBContas.cmd.Parameters.Add("@conta", SqlDbType.VarChar).Value = conta;

            if (conexão(DBContas.cmd))
                return true;
            return false;
        }

        // Método de alteração, necessário informar todos os parâmetros, considerando que não se sabe qual será alterado
        public bool AlterarConta(int id_Conta, string conta)
        {
            //colocar verificação de se existir movimentações dentro da conta


            DBContas.cmd = new SqlCommand("use DB_Financeiro UPDATE Conta SET IdConta = " + id_Conta + ", Conta = '" + conta + "' WHERE IdClasse = " + id_Conta, DBContas.sqlConn);
            if (conexão(DBContas.cmd))
                return true;
            return false;
        }

        // Método para excluir a movimentação financeira
        public bool DeletarConta(int Id_Conta)
        {
            //colocar verificação de se existir movimentações dentro da conta

            DBContas.cmd = new SqlCommand("use DB_Financeiro DELETE FROM Conta WHERE IdConta = " + Id_Conta, DBContas.sqlConn);
            if (conexão(DBContas.cmd))
                return true;
            return false;
        }

        // método para ler todo banco de dados e retornar as informações em uma lista
        public List<Contas> LerContas()
        {
            List<Contas> lista = new List<Contas>();

            DBContas.sqlConn.Open();
            DBContas.cmd = new SqlCommand("select * from Contas", DBContas.sqlConn);
            SqlDataReader dr = DBContas.cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Contas(Convert.ToInt32(dr[0]), Convert.ToString(dr[1])));
            }
            DBContas.sqlConn.Close();
            Console.ReadKey();

            return lista;
        }
    }
}
