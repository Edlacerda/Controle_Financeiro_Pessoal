using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace Controle_Financeiro_Pessoal.Model
{
    class Data
    {
        static string connectionString;
        public SqlConnection sqlConn;
        public SqlCommand cmd;

        //construtor de definição dos parâmetros de conexão
        public Data()
        {
            //definindo conexão com banco de dados, conforme string de conexão DB local
            connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DBFinanceiro;Data Source=DESKTOP-9GTTT8Q";
            sqlConn = new SqlConnection(connectionString);
        }
    }
}
