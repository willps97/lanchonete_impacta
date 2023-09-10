using LanchoneteImpacta.Context;
using LanchoneteImpacta.Models;
using LanchoneteImpacta.Repositories.Interfaces;

namespace LanchoneteImpacta.Repositories
{
    public class CategoriaRepository : IcategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
