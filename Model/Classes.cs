using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Financeiro_Pessoal.Model
{
    class Classes
    {
        public int Id_Categoria { get; set; }
        public int IdClasse { get; set; }
        public string Classe { get; set; }

        public Classes(int idCategoria, int idClasse, string classe)
        {
            Id_Categoria = idCategoria;
            IdClasse = idClasse;
            Classe = classe;
        }

        public Classes()
        {

        }


    }
}
