using System;
using System.Collections.Generic;
using Controle_Financeiro_Pessoal.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Financeiro_Pessoal.Controller
{
    class Classificacoes
    {
        public Classes classificacao { get; set; }
        public List<Classes> ListaClasses { get; set; }
        public Classificacoes_DAO AcessoDB;

        public Classificacoes()
        {
            AcessoDB = new Classificacoes_DAO();
            ListaClasses = AcessoDB.LerClasses();
        }

    }
}
