﻿
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entidades;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CategoriasController : Controller
    {
        private Contexto contexto;

        public CategoriasController(Contexto _db)
        {
            contexto = _db;
        }

        public IActionResult Lista()
        {
            return View( contexto.Categoria.ToList() );
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarDados(CategoriaViewModels dados)
        {
            Categoria entidade = new Categoria();
            entidade.Nome = dados.Nome;
            entidade.Id = dados.Id;
            entidade.Ativo = dados.Ativo;

            if (entidade.Id > 0)
            {
                contexto.Categoria.Update(entidade);
                contexto.SaveChanges();
            }
            else
            {
                contexto.Categoria.Add(entidade);
                contexto.SaveChanges();
            }


            return RedirectToAction("Lista");
        }

        public IActionResult Excluir(int id)
        {
            Categoria item = contexto.Categoria.Find(id);
            if (item != null)
            {
                contexto.Categoria.Remove(item);
                contexto.SaveChanges();

            }

            return RedirectToAction("Lista");
        }

        public IActionResult Editar(int id)
        {
            Categoria item = contexto.Categoria.Find(id);
            if (item != null)
            {
                return View(item);
            }
            else
            {
                return RedirectToAction("Lista");
            }
        }
    }
}
