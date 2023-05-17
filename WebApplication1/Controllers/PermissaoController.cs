using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entidades;

namespace WebApplication1.Controllers
{
    public class PermissaoController : Controller
    {
        private Contexto contexto;

        public PermissaoController(Contexto db)
        {
            contexto = db;
        }

        public IActionResult Lista()
        {
            return View(contexto.PERMISSAO.ToList());
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarDados(PermissaoEntidade dados)
        {
            contexto.PERMISSAO.Add(dados);
            contexto.SaveChanges();
            return RedirectToAction("Lista");
        }

        public IActionResult Excluir(int id)
        {
            Categoria item = contexto.Categorias.Find(id);
            if (item != null)
            {
                contexto.Categorias.Remove(item);
                contexto.SaveChanges();

            }

            return RedirectToAction("Lista");
        }

    }
}
