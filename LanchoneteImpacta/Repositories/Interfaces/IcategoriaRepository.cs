using LanchoneteImpacta.Models;

namespace LanchoneteImpacta.Repositories.Interfaces
{
    public interface IcategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
