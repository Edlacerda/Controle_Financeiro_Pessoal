using System;

namespace Controle_Financeiro_Pessoal.Model
{
    class Classes
    {
        public int Id_Categoria { get; set; }
        public int IdClasse { get; set; }
        public string Classe { get; set; }

        public Classes(int idClasse, int idCategoria,  string classe)
        {
            Id_Categoria = idCategoria;
            IdClasse = idClasse;
            Classe = classe;
        }
    }
}
