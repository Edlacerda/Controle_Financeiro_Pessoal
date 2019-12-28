using System.Data.SqlClient;

namespace Controle_Financeiro_Pessoal.Model
{
    class Data
    {
        private string connectionString { get; set; }
        public SqlConnection sqlConn { get; set; }
        public SqlCommand cmd { get; set; }

        //construtor de definição dos parâmetros de conexão
        public Data()
        {
            //definindo conexão com banco de dados, conforme string de conexão DB local
            connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DBFinanceiro;Data Source=DESKTOP-9GTTT8Q";
            sqlConn = new SqlConnection(connectionString);
        }
    }
}
