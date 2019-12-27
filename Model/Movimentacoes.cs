﻿using System;

namespace Controle_Financeiro_Pessoal.Model
{
    class Movimentacoes
    {
        public int Id_Movimento { get; set; }
        public int Id_Categoria { get; set; }
        public int Id_Classe { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string Fornecedor { get; set; }
        public string Descricao { get; set; }

        public Movimentacoes (int idMovimento, int idCategoria, int idClasse, decimal valor, DateTime data, string fornecedor, string descricao)
        {
            Id_Movimento = idMovimento;
            Id_Categoria = idCategoria;
            Id_Classe = idClasse;
            Valor = valor;
            Data = data;
            Fornecedor = fornecedor;
            Descricao = descricao;
        }


    }
}
