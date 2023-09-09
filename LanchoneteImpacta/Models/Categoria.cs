using System.Reflection.Metadata.Ecma335;

namespace LanchoneteImpacta.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }
        public List<Lanche> Lanches { get; set; }

    }
}
