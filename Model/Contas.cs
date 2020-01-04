using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Financeiro_Pessoal.Model
{
    class Contas
    {
        public int Id_Conta { get; set; }
        public string Conta { get; set; }
        public double Saldo { get; set; }


        public Contas(int idConta, string conta, double saldo)
        {
            Id_Conta = idConta;
            Conta = conta;
            Saldo = saldo;
        }
    }
}
