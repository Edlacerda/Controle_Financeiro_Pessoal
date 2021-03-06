﻿using System;

namespace Controle_Financeiro_Pessoal.Model
{
    class Movimentos
    {
        public int Id_Movimento { get; set; }
        public int Id_Categoria { get; set; }
        public int Id_Classe { get; set; }
        public int Id_Conta { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public string Fornecedor { get; set; }
        public string Descricao { get; set; }

        public Movimentos (int idMovimento, int idCategoria, int idClasse, int idConta, double valor, DateTime data, string fornecedor, string descricao)
        {
            Id_Movimento = idMovimento;
            Id_Categoria = idCategoria;
            Id_Conta = idConta;
            Id_Classe = idClasse;
            Valor = valor;
            Data = data;
            Fornecedor = fornecedor;
            Descricao = descricao;
        }
    }
}
