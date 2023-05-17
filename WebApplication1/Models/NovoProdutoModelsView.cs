using WebApplication1.Entidades;

namespace WebApplication1.Models
{
    public class NovoProdutoModelsView : Produtos
    {
        public NovoProdutoModelsView()
        {
            ListaCategorias = new List<Categoria>();
        }

        public List<Categoria> ListaCategorias { get; set; }
    }
}
