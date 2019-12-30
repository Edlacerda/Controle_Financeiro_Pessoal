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

        public Contas(int idConta, string conta)
        {
            Id_Conta = idConta;
            Conta = conta;
        }
    }
}
