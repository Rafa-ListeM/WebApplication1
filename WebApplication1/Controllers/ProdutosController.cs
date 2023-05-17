using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entidades;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProdutosController : Controller
    {
        private Contexto db;

        public ProdutosController(Contexto contexto)
        {
            db = contexto;
        }

        public IActionResult Lista()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            NovoProdutoModelsView model = new NovoProdutoModelsView();
            model.ListaCategorias = db.Categoria.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult SalvarDados(Produtos dados) 
        {
            db.Produtos.Add(dados);
            db.SaveChanges();
            return RedirectToAction("Lista");
        }
    }
}
