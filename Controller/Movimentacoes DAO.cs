﻿using System;
using System.Collections.Generic;
using Controle_Financeiro_Pessoal.Model;
using System.Data.SqlClient;
using System.Data;


namespace Controle_Financeiro_Pessoal.Controller
{
    class Movimentacoes_DAO
    {
        public Data DBMovimentacoes { get; set; }

        public Movimentacoes_DAO ()
        {
            DBMovimentacoes = new Data();
        }

        private bool conexão(SqlCommand comando)
        {
            try
            {
                DBMovimentacoes.sqlConn.Open();
                comando.ExecuteNonQuery();
                DBMovimentacoes.sqlConn.Close();
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
            DBMovimentacoes.cmd = new SqlCommand("insert into Movimentacoes(Id_Categoria, Id_Classe, Valor, Data, Fornecedor, Descricao) values (@idCategoria, @idClasse, @valor, @data, @fornecedor, @descricao)", DBMovimentacoes.sqlConn);
            DBMovimentacoes.cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = id_Categoria;
            DBMovimentacoes.cmd.Parameters.Add("@idClasse", SqlDbType.Int).Value = id_Classe;
            DBMovimentacoes.cmd.Parameters.Add("@valor", SqlDbType.Decimal).Value = valor;
            DBMovimentacoes.cmd.Parameters.Add("@data", SqlDbType.DateTime).Value = data;
            DBMovimentacoes.cmd.Parameters.Add("@fornecedor", SqlDbType.VarChar).Value = fornecedor;
            DBMovimentacoes.cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = descricao;

            if (conexão(DBMovimentacoes.cmd))
                return true;
            return false;
        }

        // Método de alteração, necessário informar todos os parâmetros, considerando que não se sabe qual será alterado
        public bool AlterarMovimentacao(int id_Movimento, int id_Categoria, int id_Classe, decimal valor, DateTime data, string fornecedor, string descricao)
        {
            DBMovimentacoes.cmd = new SqlCommand("use DB_Financeiro UPDATE Movimentacoes SET Id_Categoria = " + id_Categoria + ", Id_Classe = " + id_Classe + ", Valor = " + valor + ", Data = " + data + ", Fornecedor = '" + fornecedor + "', Descricao = '" + descricao + "' WHERE IDMovimento = " + id_Movimento, DBMovimentacoes.sqlConn);
            if (conexão(DBMovimentacoes.cmd))
                return true;
            return false;
        }

        // Método para excluir a movimentação financeira
        public bool DeletarMovimentacao(int id_Movimento)
        {
            DBMovimentacoes.cmd = new SqlCommand("use DB_Financeiro DELETE FROM Movimentacoes WHERE IDMovimento = " + id_Movimento, DBMovimentacoes.sqlConn);
            if (conexão(DBMovimentacoes.cmd))
                return true;
            return false;
        }

        // método para ler todo banco de dados e retornar as informações em uma lista
        public List<Movimentacoes> GravarMovimentacao()
        {
            List<Movimentacoes> lista = new List<Movimentacoes>();

            DBMovimentacoes.sqlConn.Open();
            DBMovimentacoes.cmd = new SqlCommand("select * from Movimentacoes", DBMovimentacoes.sqlConn);
            SqlDataReader dr = DBMovimentacoes.cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Movimentacoes(Convert.ToInt32(dr[0]), Convert.ToInt32(dr[1]), Convert.ToInt32(dr[2]), Convert.ToDecimal(dr[3]), Convert.ToDateTime(dr[4]), Convert.ToString(dr[5]), Convert.ToString(dr[6])));
            }
            DBMovimentacoes.sqlConn.Close();
            Console.ReadKey();

            return lista;
        }
    }
}