using LanchoneteImpacta.Repositories;
using LanchoneteImpacta.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchoneteImpacta.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly IcategoriaRepository _categoriaRepository;

        public CategoriaMenu(IcategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _categoriaRepository.Categorias.OrderBy(c => c.CategoriaNome);
            return View(categorias);
        }
    }

}
