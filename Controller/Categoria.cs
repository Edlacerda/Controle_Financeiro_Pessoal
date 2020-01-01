using System.Collections.Generic;
using Controle_Financeiro_Pessoal.Model;

namespace Controle_Financeiro_Pessoal.Controller
{
    class Categoria
    {
        List<Categorias> listaCategorias;
        public Categoria()
        {
            // iniciado apenas as categorias de Entradas e Saídas
            listaCategorias = new List<Categorias>()
            { new Categorias {Id_Categoria = 1, Categoria = "ENTRADAS"},
              new Categorias {Id_Categoria = 2, Categoria = "SAIDAS"}
            };
        }

        // método para retornar o nome da categoria através do número da categoria
        public string NomeCategoria (int idCategoria)
        {
            return listaCategorias[idCategoria - 1].Categoria;
        }
    }
}
