using System.Reflection.Metadata.Ecma335;
using LanchoneteImpacta.Models;

namespace LanchoneteImpacta.ViewModels
{
	public class LancheListViewModel
	{
		public IEnumerable<Lanche> Lanches { get; set; }
		public string CategoriaAtual { get; set; }
	}
}
