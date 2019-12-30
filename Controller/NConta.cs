using System;
using System.Collections.Generic;
using Controle_Financeiro_Pessoal.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Financeiro_Pessoal.Controller
{
    class NConta
    {
        public Contas Conta { get; set; }
        public List<Contas> ListaContas { get; set; }
        public NConta_DAO AcessoDB;

        public NConta()
        {
            AcessoDB = new NConta_DAO();
            ListaContas = AcessoDB.LerContas();
        }
    }
}
